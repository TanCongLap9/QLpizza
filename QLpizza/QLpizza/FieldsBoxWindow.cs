using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLpizza.CustomComponents
{
    public partial class FieldsBoxWindow : Panel
    {
        #region Fields

        private string _insertCommand, _selectCommand, _updateCommand, _deleteCommand, _tableName;
        private bool _readOnly, _unsavedChanges;
        private int _selectedIndex, _rowsAffected;
        private Button _newButton, _updateButton, _deleteButton;
        private ToolStripLabel _statusLabel;
        private ListBox _listBox;
        private Exception _exc;

        #endregion
        /*
         * Input fields:
         * Control          ReadOnly        Value           Type
         * -------          --------        -----           ----
         * DateTimePicker   Enabled         Value           DateTime
         * TextBox          ReadOnly        Text            string
         * CheckBox         Enabled         Checked         bool
         * RadioButton      Enabled         Checked         bool
         * NumericUpDown    ReadOnly        Value           decimal
         * TrackBar         Enabled         Value           int
         * MaskedTextBox    ReadOnly        Value           int
         * ComboBox         Enabled         SelectedValue   any
         */
        #region Constructors

        public FieldsBoxWindow()
        {
            InitializeComponent();
            _selectedIndex = -1;
        }

        public FieldsBoxWindow(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            _selectedIndex = -1;
        }

        #endregion
        #region Properties - Controls

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Control> Fields { get; } = new List<Control>();

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Control> IdFields { get; set; } = new List<Control>();

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Control> NoUpdateFields { get; set; } = new List<Control>();

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Control> DisabledFields { get; set; } = new List<Control>();

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<Control, Func<Task<object>>> AutoFields { get; } = new Dictionary<Control, Func<Task<object>>>();

        [DefaultValue(null)]
        public Button NewButton
        {
            get { return _newButton; }
            set
            {
                if (!DesignMode)
                {
                    if (_newButton != null) _newButton.Click -= newButton_Click;
                    if (value != null) value.Click += newButton_Click;
                }
                _newButton = value;
            }
        }

        [DefaultValue(null)]
        public Button UpdateButton
        {
            get { return _updateButton; }
            set
            {
                if (!DesignMode)
                {
                    if (_updateButton != null) _updateButton.Click -= Update;
                    if (value != null) value.Click += Update;
                }
                _updateButton = value;
            }
        }

        [DefaultValue(null)]
        public Button DeleteButton
        {
            get { return _deleteButton; }
            set
            {
                if (!DesignMode)
                {
                    if (_deleteButton != null) _deleteButton.Click -= deleteButton_Click;
                    if (value != null) value.Click += deleteButton_Click;
                }
                _deleteButton = value;
            }
        }

        [DefaultValue(null)]
        public ListBox ListBox
        {
            get { return _listBox; }
            set
            {
                if (!DesignMode)
                {
                    if (_listBox != null) _listBox.Click -= ListBox_Click;
                    if (value != null) value.Click += ListBox_Click;
                }
                _listBox = value;
            }
        }

        [DefaultValue(null)]
        public ToolStripLabel StatusLabel
        {
            get { return _statusLabel; }
            set { _statusLabel = value; }
        }

        #endregion
        #region Properties - Table

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataTable Table { get; } = new DataTable();

        [Category("Data")]
        [DefaultValue(null)]
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        #endregion
        #region Properties - Commands

        [DefaultValue(null)]
        public string SelectCommand
        {
            get { return _selectCommand; }
            set {
                _selectCommand = value;
                if (DataAdapter.SelectCommand != null)
                    DataAdapter.SelectCommand.CommandText = value;
            }
        }

        [DefaultValue(null)]
        public string UpdateCommand
        {
            get { return _updateCommand; }
            set {
                _updateCommand = value;
                if (DataAdapter.UpdateCommand != null)
                    DataAdapter.UpdateCommand.CommandText = value;
            }
        }

        [DefaultValue(null)]
        public string InsertCommand
        {
            get { return _insertCommand; }
            set {
                _insertCommand = value;
                if (DataAdapter.InsertCommand != null)
                    DataAdapter.InsertCommand.CommandText = value;
            }
        }

        [DefaultValue(null)]
        public string DeleteCommand
        {
            get { return _deleteCommand; }
            set {
                _deleteCommand = value;
                if (DataAdapter.DeleteCommand != null)
                    DataAdapter.DeleteCommand.CommandText = value;
            }
        }

        #endregion
        #region Properties - Other

        [Category("Behavior")]
        [DefaultValue(false)]
        [Description("Controls whether the text in writable fields can be changed or not.")]
        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;
                if (Fields != null)
                    foreach (Control ctl in Fields)
                        if (IdFields.Contains(ctl)) continue;
                        else if (NoUpdateFields.Contains(ctl)) continue;
                        else if (DisabledFields.Contains(ctl)) continue;
                        else SetFieldReadOnly(ctl, value);
                if (UpdateButton != null) UpdateButton.Enabled = !value;
                if (NewButton != null) NewButton.Enabled = !value;
                if (DeleteButton != null) DeleteButton.Enabled = !value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set {
                if (value < -1 && value >= Table.Rows.Count)
                    throw new IndexOutOfRangeException();

                EventHandler selectedIndexChanged = _selectedIndex != value ? SelectedIndexChanged : null;
                _selectedIndex = value;
                if (ListBox != null)
                    ListBox.SelectedIndex = value;
                // Đặt SelectedIndex = -1 để vào chế độ chèn dữ liệu
                if (value == -1)
                {
                    Clear(null, null);
                    selectedIndexChanged?.Invoke(this, new EventArgs());
                    _unsavedChanges = false;
                }
                else
                {
                    FillFields().ContinueWith(result =>
                    {
                        selectedIndexChanged?.Invoke(this, new EventArgs());
                        _unsavedChanges = false;
                    });
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataRow SelectedRow
        {
            get { return Table.Rows[_selectedIndex]; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int RowsAffected
        {
            get { return _rowsAffected; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool UnsavedChanges
        {
            get { return _unsavedChanges; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Exception Exception
        {
            get { return _exc; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SqlDataAdapter DataAdapter { get; } = new SqlDataAdapter();

        #endregion
        #region Methods - Load

        public async Task Load(int selectedIndex = 0)
        {
            Fields.Clear();
            IdFields.Clear();
            NoUpdateFields.Clear();
            DisabledFields.Clear();
            Table.Columns.Clear();
            Table.Clear();
            SqlCommandBuilder _commandBuilder = new SqlCommandBuilder(DataAdapter);
            await LoadFields(this.Controls);
            ReadOnly = ReadOnly; // Kích hoạt hàm set

            DataAdapter.SelectCommand = SqlUtils.GetCommand(
                SelectCommand != null ?
                SelectCommand : 
                "SELECT " +
                string.Join(", ", from field in Fields select $"[{GetFieldName(field)}]") +
                $" FROM {TableName}"
            );

            DataAdapter.InsertCommand = _commandBuilder.GetInsertCommand(true);
            if (InsertCommand != null) DataAdapter.InsertCommand.CommandText = InsertCommand;
            
            DataAdapter.UpdateCommand = _commandBuilder.GetUpdateCommand(true);
            if (UpdateCommand != null) DataAdapter.UpdateCommand.CommandText = UpdateCommand;
            
            DataAdapter.DeleteCommand = _commandBuilder.GetDeleteCommand(true);
            if (DeleteCommand != null) DataAdapter.DeleteCommand.CommandText = DeleteCommand;
            
            
            await UpdateTable();
            if (ListBox != null)
                ListBox.DataSource = Table;
            SelectedIndex = Table.Rows.Count == 0 ? -1 : selectedIndex;
        }

        private async Task LoadFields(ControlCollection controls)
        {
            TextBoxBase txt;
            CheckBox chk;
            DateTimePicker dtp;
            RadioButton rad;
            NumericUpDown nud;
            TrackBar trb;
            ComboBox cbo;

            foreach (Control ctl in controls)
            {
                if (ctl is Panel ||
                    ctl is TabControl ||
                    ctl is GroupBox ||
                    ctl is SplitContainer)
                    await LoadFields(ctl.Controls);
                else if (ctl.Tag != null && !string.IsNullOrEmpty(ctl.Tag.ToString()) && !string.IsNullOrEmpty(GetFieldName(ctl)))
                {
                    if ((chk = ctl as CheckBox) != null)
                    {
                        Fields.Add(ctl);
                        chk.CheckedChanged += ctl_TextChanged;
                    }
                    else if ((cbo = ctl as ComboBox) != null)
                    {
                        Fields.Add(ctl);
                        cbo.SelectedIndexChanged += ctl_TextChanged;
                    }
                    else if ((dtp = ctl as DateTimePicker) != null)
                    {
                        Fields.Add(ctl);
                        dtp.ValueChanged += ctl_TextChanged;
                    }
                    else if ((nud = ctl as NumericUpDown) != null)
                    {
                        Fields.Add(ctl);
                        nud.ValueChanged += ctl_TextChanged;
                    }
                    else if ((rad = ctl as RadioButton) != null)
                    {
                        Fields.Add(ctl);
                        rad.CheckedChanged += ctl_TextChanged;
                    }
                    else if ((txt = ctl as TextBoxBase) != null)
                    {
                        Fields.Add(ctl);
                        txt.TextChanged += ctl_TextChanged;
                    }
                    else if ((trb = ctl as TrackBar) != null)
                    {
                        Fields.Add(ctl);
                        trb.ValueChanged += ctl_TextChanged;
                    }
                    if (GetFieldAttributes(ctl).Contains("Disabled"))
                        DisabledFields.Add(ctl);
                    if (GetFieldAttributes(ctl).Contains("Id"))
                        IdFields.Add(ctl);
                    if (GetFieldAttributes(ctl).Contains("NoUpdate"))
                        NoUpdateFields.Add(ctl);
                }
            }
        }

        #endregion
        #region Methods - Get/set fields

        public static string GetFieldName(Control ctl)
        {
            return ctl.Tag.ToString().Split(',')[0];
        }

        public static string[] GetFieldAttributes(Control ctl)
        {
            string[] states = ctl.Tag.ToString().Split(',');
            return states.Skip(1).ToArray();
        }

        public static void SetFieldReadOnly(Control ctl, bool value)
        {
            TextBoxBase txt;
            if ((txt = ctl as TextBoxBase) != null)
                txt.ReadOnly = value;
            else
                ctl.Enabled = !value;
            // NumericUpDown có thuộc tính ReadOnly nhưng vì nó có thuộc tính Increment có thể tăng giá trị khi nhấn nút nên bỏ
        }

        public static bool GetFieldReadOnly(Control ctl)
        {
            TextBoxBase txt;
            if ((txt = ctl as TextBoxBase) != null)
                return txt.ReadOnly;
            else
                return !ctl.Enabled;
            // NumericUpDown có thuộc tính ReadOnly nhưng vì nó có thuộc tính Increment có thể tăng giá trị khi nhấn nút nên bỏ
        }

        public static void SetFieldReadOnly(List<Control> ctls, bool value)
        {
            foreach (Control ctl in ctls)
                SetFieldReadOnly(ctl, value);
        }

        public static object GetFieldValue(Control ctl)
        {
            TextBoxBase txt;
            CheckBox chk;
            DateTimePicker dtp;
            RadioButton rad;
            NumericUpDown nud;
            TrackBar trb;
            ComboBox cbo;
            if ((chk = ctl as CheckBox) != null)
                return chk.Checked;
            else if ((cbo = ctl as ComboBox) != null)
                return cbo.DataSource != null ? cbo.SelectedValue : cbo.SelectedItem;
            else if ((dtp = ctl as DateTimePicker) != null)
            {
                if (dtp.Format == DateTimePickerFormat.Time)
                {
                    TimeSpan timeSpan = dtp.Value.TimeOfDay;
                    return new TimeSpan(timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                }
                else
                    return dtp.Value.Date;
            }
            else if ((nud = ctl as NumericUpDown) != null)
            {
                if (nud.DecimalPlaces == 0)
                    return (int)nud.Value;
                else
                    return Math.Round((float)nud.Value, nud.DecimalPlaces); // Tránh lỗi floating point
            }
            else if ((rad = ctl as RadioButton) != null)
                return rad.Checked;
            else if ((txt = ctl as TextBoxBase) != null)
                return txt.Text.Trim();
            else if ((trb = ctl as TrackBar) != null)
                return trb.Value;
            return null;
        }

        public static void SetFieldValue(Control ctl, object value)
        {
            TextBoxBase txt;
            CheckBox chk;
            DateTimePicker dtp;
            RadioButton rad;
            NumericUpDown nud;
            TrackBar trb;
            ComboBox cbo;
            if ((chk = ctl as CheckBox) != null)
                chk.Checked = (bool)value;
            else if ((cbo = ctl as ComboBox) != null)
                if (cbo.DataSource != null)
                    cbo.SelectedValue = value ?? DBNull.Value;
                else
                    cbo.SelectedItem = value ?? DBNull.Value;
            else if ((dtp = ctl as DateTimePicker) != null)
                if (value is DateTime)
                    dtp.Value = ((DateTime)value).Date;
                else
                    dtp.Value = DateTime.Now.Date + (TimeSpan)value;
            else if ((nud = ctl as NumericUpDown) != null)
                nud.Value = Math.Round(Convert.ToDecimal(value), nud.DecimalPlaces); // Tránh lỗi floating point
            else if ((rad = ctl as RadioButton) != null)
                rad.Checked = (bool)value;
            else if ((txt = ctl as TextBoxBase) != null)
                txt.Text = (string)value;
            else if ((trb = ctl as TrackBar) != null)
                trb.Value = (int)value;
        }

        public async Task FillFields()
        {
            SetFieldReadOnly(IdFields, true);
            SetFieldReadOnly(NoUpdateFields, true);
            DataRow row = Table.Rows[SelectedIndex];
            foreach (Control field in Fields)
                SetFieldValue(field, row.Field<object>(GetFieldName(field)));
            foreach (KeyValuePair<Control, Func<Task<object>>> field in AutoFields)
                SetFieldValue(field.Key, await field.Value.Invoke());
            if (FieldsFilled != null) FieldsFilled.Invoke(this, new EventArgs());
        }

        #endregion
        #region Methods - Clear fields

        public void Clear(object sender, EventArgs e)
        {
            SetFieldReadOnly(IdFields, false);
            SetFieldReadOnly(NoUpdateFields, false);
            CheckBox chk;
            ComboBox cbo;
            DateTimePicker dtp;
            NumericUpDown nud;
            RadioButton rad;
            TextBoxBase txt;
            TrackBar trb;
            foreach (IEnumerable<Control> list in new IEnumerable<Control>[] { Fields, AutoFields.Keys })
                foreach (Control ctl in list)
                {
                    if ((chk = ctl as CheckBox) != null)
                        chk.Checked = false;
                    else if ((cbo = ctl as ComboBox) != null)
                        cbo.SelectedIndex = 0;
                    else if ((dtp = ctl as DateTimePicker) != null)
                        dtp.Value = DateTime.Now;
                    else if ((nud = ctl as NumericUpDown) != null)
                        nud.Value = Math.Round(Math.Min(Math.Max(0, nud.Minimum), nud.Maximum), nud.DecimalPlaces); // Tránh lỗi floating point
                    else if ((rad = ctl as RadioButton) != null)
                        rad.Checked = false;
                    else if ((txt = ctl as TextBoxBase) != null)
                        txt.Text = string.Empty;
                    else if ((trb = ctl as TrackBar) != null)
                        trb.Value = 0;
                }
            Cleared?.Invoke(this, new EventArgs());
        }

        #endregion
        #region Methods - Update row

        public async void Update(object sender, EventArgs e)
        {
            CancelEventArgs ce = new CancelEventArgs();
            Updating?.Invoke(this, ce);
            if (ce.Cancel) return;

            this.Enabled = false;
            if (ListBox != null)
                ListBox.Enabled = false;
            if (StatusLabel != null)
                StatusLabel.Text = $"Đang {(SelectedIndex == -1 ? "thêm" : "sửa đổi")} dữ liệu... Vui lòng đợi.";
            _rowsAffected = 0;
            _exc = null;
            DataRow row;
            try
            {
                // Tạo dòng hoặc sửa đổi dòng dữ liệu
                if (SelectedIndex == -1)
                    row = Table.NewRow();
                else row = Table.Rows[SelectedIndex];
                foreach (Control ctl in Fields)
                    row.SetField(GetFieldName(ctl), GetFieldValue(ctl));
                if (SelectedIndex == -1)
                    Table.Rows.Add(row);
                _rowsAffected = await Task.Run(() => {
                    try
                    {
                        return DataAdapter.Update(Table);
                    }
                    catch (Exception exc)
                    {
                        _exc = exc;
                        return 0;
                    }
                });
                if (Exception != null) // Quăng lỗi trên luồng chính để VS ko báo lỗi
                    throw Exception;
                if (_rowsAffected == 0)
                {
                    if (StatusLabel != null)
                        StatusLabel.Text = "Dữ liệu không đổi.";
                    return;
                }
                SetFieldReadOnly(IdFields, true);
                SetFieldReadOnly(NoUpdateFields, true);
                if (StatusLabel != null)
                    StatusLabel.Text = $"{(SelectedIndex == -1 ? "Thêm" : "Sửa đổi")} thành công.";
                _unsavedChanges = false;
            }
            catch (Exception exc)
            {
                _exc = exc;
                CancelEventArgs ce2 = new CancelEventArgs();
                Error?.Invoke(sender, ce2);
                if (StatusLabel != null)
                    StatusLabel.Text = ce2.Cancel ? string.Empty : "Có lỗi xảy ra: " + exc.Message;
                Table.RejectChanges();
            }
            finally
            {
                this.Enabled = true;
                if (ListBox != null)
                    ListBox.Enabled = true;
                if (RowsAffected != 0)
                {
                    // Mở lại listbox DataSource có thay đổi dữ liệu
                    if (ListBox != null)
                    {
                        //ListBox.DataSource = Table;
                        //ListBox.SelectedIndex = SelectedIndex;
                        //ListBox.TopIndex = scrollY;
                    }
                    // Trỏ tới dòng dữ liệu đã thêm vào
                    if (SelectedIndex == -1)
                        SelectedIndex = Table.Rows.Count - 1;
                    // Tính giá trị các thông tin tự động
                    foreach (KeyValuePair<Control, Func<Task<object>>> kv in AutoFields)
                        SetFieldValue(kv.Key, await kv.Value.Invoke());
                }
                OnUpdated(this, e);
                if (RowsAffected != 0)
                    _unsavedChanges = false;
            }
        }

        #endregion
        #region Methods - Update table

        public async Task UpdateTable()
        {
            this.Enabled = false;
            if (ListBox != null)
                ListBox.Enabled = false;
            Table.Clear();
            Table.Columns.Clear();
            while (true)
                try
                {
                    SqlUtils.Open();
                    await Task.Run(() => DataAdapter.Fill(Table));
                    //SqlUtils.Conn.Close();
                    if (ListBox != null)
                    {
                        // Tải lại DataSource cho ListBox để kích hoạt hàm Format
                        ListBox.DataSource = null;
                        ListBox.DataSource = Table;
                    }
                    break;
                }
                catch (Exception exc)
                {
                    switch (MessageBox.Show(
                        "Không thể tải dữ liệu",
                        "Lỗi tải dữ liệu",
                        MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error))
                    {
                        case DialogResult.Abort:
                            throw exc;
                        case DialogResult.Ignore:
                            return;
                    }
                }
                finally
                {
                    this.Enabled = true;
                    if (ListBox != null)
                        ListBox.Enabled = true;
                }
        }

        #endregion
        #region Methods - Delete row

        public async Task Delete(object sender, EventArgs e)
        {
            CancelEventArgs ce = new CancelEventArgs();
            Deleting?.Invoke(this, ce);
            if (ce.Cancel) return;

            this.Enabled = false;
            if (ListBox != null)
                ListBox.Enabled = false;
            if (StatusLabel != null)
                StatusLabel.Text = "Đang xoá dữ liệu... Vui lòng đợi.";
            _rowsAffected = 0;
            _exc = null;
            try
            {
                // Xoá dòng dữ liệu
                SelectedRow.Delete();
                _rowsAffected = await Task.Run(() => {
                    try
                    {
                        return DataAdapter.Update(Table);
                    }
                    catch (Exception exc)
                    {
                        _exc = exc;
                        return 0;
                    }
                });
                if (Exception != null) // Quăng lỗi trên luồng chính để VS ko báo lỗi
                    throw Exception;
                if (_rowsAffected == 0)
                {
                    if (StatusLabel != null)
                        StatusLabel.Text = "Dữ liệu không đổi.";
                    return;
                }
                if (StatusLabel != null)
                    StatusLabel.Text = "Xoá thành công.";
            }
            catch (Exception exc)
            {
                _exc = exc;
                if (StatusLabel != null)
                    StatusLabel.Text = "Có lỗi xảy ra: " + exc.Message;
                Table.RejectChanges();
            }
            finally
            {
                this.Enabled = true;
                if (ListBox != null)
                    ListBox.Enabled = true;
                // Trỏ tới cùng dòng khi xoá thành công
                // Hoặc vào chế độ chèn dữ liệu nếu bảng trống
                if (RowsAffected != 0)
                    SelectedIndex = Math.Min(SelectedIndex, Table.Rows.Count - 1);
                Deleted?.Invoke(this, new EventArgs());
            }
        }

        #endregion
        #region Methods - Event methods

        private void ListBox_Click(object sender, EventArgs e)
        {
            if (!ConfirmUnsavedChanges())
            {
                ListBox.SelectedIndex = SelectedIndex;
                return;
            }
            SelectedIndex = ListBox.SelectedIndex;
        }

        private void ctl_TextChanged(object sender, EventArgs e)
        {
            _unsavedChanges = true;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (ConfirmUnsavedChanges())
                SelectedIndex = -1;
        }

        public async void deleteButton_Click(object sender, EventArgs e)
        {
            if (ConfirmDelete())
                await Delete(null, null);
        }

        public void OnUpdated(object sender, EventArgs e)
        {
            Updated?.Invoke(sender, e);
        }

        #endregion
        #region Methods - Other

        public bool ConfirmUnsavedChanges()
        {
            return !UnsavedChanges
                || MessageBox.Show(
                    "Dữ liệu chưa được lưu.\nBạn có muốn huỷ bỏ các thay đổi hiện tại không?",
                    "Dữ liệu chưa được lưu",
                    MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
        
        public bool ConfirmDelete()
        {
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Chọn dữ liệu cần xoá.", "Xoá dữ liệu");
                return false;
            }
            return MessageBox.Show(
                    "Bạn có muốn xoá dữ liệu này không?",
                    "Xoá dữ liệu",
                    MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        #endregion
        #region Events

        [Category("Behavior")]
        [Description("Happens when input fields have been cleared.")]
        public event EventHandler Cleared;

        [Category("Behavior")]
        [Description("Happens when a row deletion operation has been executed.")]
        public event EventHandler Deleted;

        [Category("Behavior")]
        [Description("Happens when a row update or insertion operation has been executed. Use the property SelectedIndex == -1 to determine whether it's an insertion or not.")]
        public event EventHandler Updated;

        [Category("Behavior")]
        [Description("Happens when input fields are filled with selected row data.")]
        public event EventHandler FieldsFilled;

        [Category("Property Changed")]
        [Description("Happens when selected row index is changed.")]
        public event EventHandler SelectedIndexChanged;

        [Category("Behavior")]
        [Description("Happens when a row is about to be updated.")]
        public event CancelEventHandler Updating;

        [Category("Behavior")]
        [Description("Happens when a row is about to be deleted.")]
        public event CancelEventHandler Deleting;

        [Category("Behavior")]
        [Description("Happens when a insert, update or delete operation gets an error. Set e.Cancel = true to disable writing to status label (typically when the error is handled and the status label doesn't need to be written)")]
        public event CancelEventHandler Error;

        #endregion
    }
}
