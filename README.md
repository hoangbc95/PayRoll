<h1>Project PayRoll</h1>

<h3>Tổng quan về project: Nhập thông tin nhân viên từ file csv và hiển thị thông tin nhân viên lên màn hình console</h3>

1. Nghiệp vụ

* Các thông tin của nhân viên
    | Thuộc tính|Cột trong file csv|Kiểu dữ liệu|
    |:-------|:-------|:-------|
    |Tên nhân viên|name|string|
    |Ngày sinh|dob|string|
    |Chức vụ|role|string|
    |Ngày bắt đầu làm việc|startdate|string|
    |Lương khởi điểm|salary|long|

* Cách tính lương hiện tại:
    * Với mọi nhân viên không phân biệt chức vụ, tăng 6% lương mỗi năm

* Các thông tin hiển thị lên màn hình:
    * Tên nhân viên
    * Ngày sinh
    * Tuổi
    * Thời gian làm việc: năm, tháng
    * Mức lương khởi điểm
    * Mức lương hiện tại

2. Logic đọc file CSV

* Project đang sử dụng thư viện CsvHelper để đọc file Csv
* Tham khảo link: [https://joshclose.github.io/CsvHelper/]


