const SPREADSHEET_ID = "1V63SZiQ2HarzKGTndiaZuFMad3O5fb6F2DiIa953jq0";
const LOGO_ID = "1MTg8BCHiUJym0Zz9xJIidBn3D4QX22XJ";

function doGet(e) {
  var spreadsheet = SpreadsheetApp.openById(SPREADSHEET_ID);
  var columnNames = spreadsheet.getRangeByName("HEADER_HOADON").getValues()[0];
  if (e.parameter.type == "forgetPassword") {
    var data = {
      id: e.parameter.id,
    };
    var output = HtmlLib.toHtmlOutput(HtmlService, {file: "forget_password.html", language: "html", params: {data, LOGO_ID}});
    GmailApp.sendEmail(e.parameter.to, "Quên mật khẩu", `
Pizza HIT
Chúng tôi đã tiếp nhận yêu cầu khôi phục tài khoản bằng email.
Đây là mã để khôi phục tài khoản: ${e.parameter.id}
ĐỂ TRÁNH BỊ KẺ GIAN LỢI DỤNG, VUI LÒNG KHÔNG CHIA SẺ MÃ NÀY CHO BẤT KỲ AI.
Nhập đoạn mã đó vào trong form Quên mật khẩu để tiếp tục.
Nếu quý khách không yêu cầu khôi phục tài khoản thì có thể bỏ qua tin nhắn này.
_______________________________________________________________________________
Cảm ơn quý khách đã hợp tác với chúng tôi!`, {htmlBody: output.getContent(), noReply: true});
  }
  else if (e.parameter.type == "accountCreation") {
    var data = {
      id: e.parameter.id,
    };
    var output = HtmlLib.toHtmlOutput(HtmlService, {file: "account_creation.html", language: "html", params: {data, LOGO_ID}});
    GmailApp.sendEmail(e.parameter.to, "Tạo tài khoản", `
Pizza HIT
Chúng tôi đã tiếp nhận yêu cầu xác thực tài khoản bằng email.
Đây là mã để xác thực tài khoản: ${e.parameter.id}
ĐỂ TRÁNH BỊ KẺ GIAN LỢI DỤNG, VUI LÒNG KHÔNG CHIA SẺ MÃ NÀY CHO BẤT KỲ AI.
Nhập đoạn mã đó vào trong form Đăng ký để tiếp tục.
Nếu quý khách không yêu cầu tạo tài khoản thì có thể bỏ qua tin nhắn này.
Cảm ơn quý khách đã hợp tác với chúng tôi!`, {htmlBody: output.getContent(), noReply: true});
  }
  else if (e.parameter.type == "insert") {
    for (var i = 0; i < columnNames.reduce((t, columnName) => Math.max(t, e.parameters[columnName].length), 0); i++) {
      var values = [];
      for (var columnName of columnNames)
        values[columnNames.indexOf(columnName)] = (e.parameters[columnName].length == 1) ?
          e.parameter[columnName] :
          e.parameters[columnName][i];
      spreadsheet.getActiveSheet().appendRow(values);
    }
  }
  else {
    var dataRows = spreadsheet.getActiveSheet().getRange(2, 1, spreadsheet.getLastRow() - 1, spreadsheet.getLastColumn()).getValues()
      .map(row => new DataRow(columnNames, row))
      .filter(dataRow => dataRow.maHoaDon == e.parameter.id);
    try {
      console.log(e);
      var data = {maHoaDon: e.parameter.id};
      console.log(dataRows);
      if (dataRows.length == 0)
        return HtmlLib.toHtmlOutput(HtmlService, {file: "notfound.html", language: "html", params: {data, LOGO_ID}});
      else {
        var firstRow = dataRows[0];
        for (var columnName of ["maHoaDon", "maBan", "tenBan", "maKH", "hoTen", "ngayDat", "thoiGianDat", "phuongThucThanhToan", "ghiChu", "khachTra"])
          data[columnName] = firstRow[columnName];
        data.chiTiet = dataRows.map(dataRow => ({
          maPizza: dataRow.maPizza,
          tenPizza: dataRow.tenPizza,
          soLuong: dataRow.soLuong,
          donGia: dataRow.donGia,
        }));
        return HtmlLib.toHtmlOutput(HtmlService, {file: "index.html", language: "html", params: {data, LOGO_ID}});
      }
    }
    catch (e) {
      return HtmlLib.toHtmlOutput(HtmlService, {file: "notfound.html", language: "html", params: {data, LOGO_ID}});
    }
  }
}
class DataRow {
  constructor(columnNames, columnRow) {
    for (var i = 0; i < columnNames.length; i++) {
      var columnName = columnNames[i];
      var columnValue = columnRow[i];
      this[columnName] = columnValue;
    }
  }
}