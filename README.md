Phần mềm quản lý quán Pizza HIT
=====

## Giới thiệu

Pizza là một món ăn không thể nào quen thuộc hơn đối với giới trẻ trong thời buổi hiện nay.
Chính vì vậy, quán Pizza HIT được lập nên để bắt kịp xu hướng đó.

Tuy nhiên, để đối phó với nhu cầu ăn pizza ngày một tăng cao, cách quản lý món Pizza thủ công mà cửa hàng đang sở hữu gặp khá nhiều vấn đề. Nên cách đó khó tiếp cận với nhiều khách hàng do nhiều vấn đề mà phương pháp cũ mang lại.

Hiểu rõ được vấn đề đó, chúng tôi ở đây sẽ đề xuất một giải pháp chính là áp dụng công nghệ thông tin vào việc quản lý đơn vị kinh doanh Pizza.

Hãy thử **Phần mềm quản lý quán Pizza HIT** của chúng tôi ngày hôm nay. Đây là phần mềm được làm bằng C#. Phần mềm này giúp giải quyết được những vấn đề phát sinh từ cách thức quản lý cũ và cải thiện hiệu suất quản lý cho đơn vị kinh doanh.

## Các tính năng nổi bật

Phần mềm này có những tính năng nổi bật như sau:
* Hệ thống đăng nhập, đăng ký và xác thực email.
* Đặt mua pizza bằng phần mềm.
* Khả năng quản lý nhiều thông tin từ nhiều danh mục khác nhau.
* Xem hoá đơn trên web bằng cách quét mã QR.
* Tra cứu thông tin, thống kê doanh thu.
* Giao diện cân đối, nhất quán.
* Mã hoá một số thông tin trong CSDL để tăng độ bảo mật.

## Cấu trúc của dự án

Dự án này gồm có cấu trúc thư mục như sau:

- [`README.md`](README.md): Các thông tin hữu ích về phần mềm này
- [`Pizza.sql`](Pizza.sql): Mã nguồn CSDL lưu trữ các thông tin về quán
- [`PIZZA.bak`](PIZZA.bak): Bản sao lưu CSDL lưu trữ các thông tin về quán
- [`pizza_tieuluan.docx`](pizza_tieuluan.docx): Tiểu luận môn học
- [`pizza_thuyettrinh.pptx`](pizza_thuyettrinh.pptx): Bài thuyết trình về phần mềm
- [`TaiKhoan.txt`](TaiKhoan.txt): Chứa một số tài khoản mẫu để đăng nhập
- [`LICENSE`](LICENSE): Giấy phép phát hành phần mềm
- [`screenshots`](screenshots): Các ảnh chụp màn hình từ phần mềm
- [`QLpizza`](QLpizza): Chứa giải pháp phần mềm
- [`QLpizza_Drive`](QLpizza_Drive): Chứa mã để chạy webapp trên Google. Người dùng có thể tự setup webapp của riêng

## Cài đặt

Để cài đặt và chạy phần mềm quản lý quán Pizza HIT, người dùng cần cài sẵn những phần mềm sau:
* Trình duyệt (Chrome, Firefox hoặc bất kỳ trình duyệt nào khác).
* Visual Studio (tối thiểu phiên bản 2015).
* SQL Server Management Studio (tối thiểu phiên bản 2008).

Người dùng cài đặt phần mềm này theo các bước sau:
1. Tải dự án phần mềm này về máy.
2. Cài đặt CSDL. Chi tiết gồm các bước sau:
    1. Chạy SQL Server Management Studio.
    2. Kéo thả tập tin `Pizza.sql` vào SQL Server Management Studio.
    3. Nhấn F5 để chạy lệnh tạo CSDL.
3. (Không bắt buộc): Cài đặt web app. Bước này khá dài dòng và phức tạp, người dùng có thể bỏ qua bước này. Chi tiết gồm các bước sau:
    1. Đăng nhập vào tài khoản Google và truy cập Google Drive.
    2. Chọn phần My Drive.
    3. Kéo thả thư mục `QLpizza_Drive` vào bất kỳ đâu trong thư mục My Drive để tải lên.
    4. Truy cập vào [Google Apps Script](https://script.google.com/) và tạo file script bằng cách nhấn vào New Project.
    5. Thêm thư viện HtmlLib.
        1. Di chuột vào phần Library và nhấn dấu + kế bên.
        2. Nó sẽ bật hộp thoại thêm thư viện. Sao chép và dán mã như sau vào vùng nhập Script ID: `1SZjxy0SuovIANOvF88mmYnCCX_NmFGjlo-8hQCsan28V5t1HL8NK9O-R`
        3. Nhấn vào nút Look up.
        4. Khi này, thư viện HtmlLib sẽ được trả về. Để nguyên các vùng nhập xuất hiện ở dưới (Version = HEAD, Identifier = HtmlLib) và nhấn nút Add.
    6. Tại thư mục `QLpizza_Drive` đã tải lên Drive, vào thư mục `Scripts` và ứng với mỗi tập tin bên trong thì:
        1. Tạo tập tin mới tương ứng trong Google Apps Script (bằng cách nhấn vào nút + ở phần Files).
        2. Chọn Script (đối với tập tin có đuôi `.gs`) hoặc HTML (đối với tập tin có đuôi `.html`).
        3. Sao chép nội dung từ tập tin đó qua.
    7. Thay đổi các hằng số ID (SPREADSHEET_ID, LOGO_ID) dựa vào địa chỉ đường dẫn chia sẻ.
        1. Đường dẫn chia sẻ có dạng như sau: https://drive.google.com/file/d/xxxxxxxxxxxxxxx/view?usp=drive_link
        2. Sao chép cái mã (phần xxxxxxxxxxxxxxx) và dán vào các hằng số ID
        3. Hằng số SPREADSHEET_ID lấy từ file excel
        4. Hằng số LOGO_ID lấy từ logo
    8. Lưu dự án.
    9. Triển khai web app.
        1. Nhấn nút Deploy > New Deployment.
        2. Nhấn vào biểu tượng bánh răng, chọn Web app.
        3. Chọn Execute as = Me và Who has access = Anyone.
        4. Nhấn nút Deploy và sao chép địa chỉ của web app.
    10. Thay đổi tuỳ chỉnh WebApp trong Visual Studio. Chi tiết gồm các bước sau:
        1. Vào Visual Studio mở giải pháp QLpizza và vào menu Project > QLpizza Properties.
        2. Vào phần Settings và dán địa chỉ của web app đã sao chép vào WebApp.
        3. Tắt và lưu lại.

## Thông tin kỹ thuật

Dưới đây là thông tin kỹ thuật về phần mềm quản lý quán Pizza HIT:

|           Key            |    Value     |
|--------------------------|--------------|
|Tên phần mềm              |Pizza HIT     |
|Ngôn ngữ giao diện        |Tiếng Việt    |
|Ngôn ngữ lập trình        |C#            |
|Phiên bản .NET Framework  |4.5.2         |
|Các gói sử dụng           |QRCoder 1.5.1 |

## Yêu cầu hệ thống tối thiểu

Để sử dụng phần mềm này, máy tính của người dùng cần phải có yêu cầu tối thiểu như sau:

|       Key        |  Value  |
|------------------|---------|
|RAM               |256MB|
|CPU               |500Mhz|
|Dung lượng ổ cứng |15MB|
|Kết nối           |Internet (cho việc xác thực email và xem hoá đơn trên web)|
|Hệ điều hành      |Windows 7 trở lên|
|Độ phân giải      |1200x900|
