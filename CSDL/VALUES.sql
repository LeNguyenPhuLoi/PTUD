---------------THEM DU LIEU---------------
use master
GO
USE QLNH
SET DATEFORMAT DMY
---THEM THONG TIN PHONG BAN---
GO
INSERT INTO PHONGBAN(MAPB, TENPB, TrangThai)
VALUES (1, N'CSKH', 1),
       (2, N'HÀNH CHÍNH', 1),
       (3, N'KẾ TOÁN', 1);
---THEM THONG TIN CHI NHANH---
GO
INSERT INTO CHINHANH(MACN, TENCN, DIACHICN, SDTCN, TrangThai)
VALUES ('CN01', N'MindLess-HCM', N'Hồ Chí Minh', '0911234567', 1),
       ('CN02', N'MindLess-HN', N'Hà Nội', '0988765432', 1),
       ('CN03', N'MindLess-QN', N'Quảng Ninh', '0902345678', 1);
---THEM THONG TIN NHAN VIEN---
GO
INSERT INTO NHANVIEN(MANV, TENNV, GIOITINH, NGAYSINH,CCCD, CHUC, LUONG, DIACHI, SDT, MAPB, MACN,TRANGTHAI)
VALUES ('NV0001',N'Nguyễn Văn An', N'NAM', '12/01/1990','012345678912', N'Lễ Tân', 15000000, N'25 Lý Thường Kiệt', '0987654321', 1,'CN01',N'Hoạt Động'),
		('NV0002',N'Trần Thị Mai', N'NỮ', '25/06/1985','021346587091', N'Thông Dịch Viên', 18000000, N'72 Phan Đình Phùng', '0912345678', 2,'CN02',N'Hoạt Động'),
		('NV0003',N'Lê Minh Tuấn', N'NAM', '08/03/2000','011223456789', N'IT', 25000000, N'10 Trần Hưng Đạo', '0968112233', 3,'CN03',N'Hoạt Động'),
		('NV0004',N'Phạm Hồng Nhung', N'NỮ', '19/07/1995','012345678321', N'Lễ Tân', 15000000, N'5 Nguyễn Du', '0909876543', 2,'CN03',N'Hoạt Động'),
		('NV0005',N'Đặng Quang Huy', N'NAM', '30/10/1978','0123456567', N'Nhà Đầu Tư', 20000000, N'45 Hoàng Hoa Thám', '0977223344', 1,'CN02',N'Hoạt Động')
		---THEM THONG TIN KHACH HANG
GO
INSERT INTO KHACHHANG(MAKH, TENKH, GIOITINH, CCCD, SDT, EMAIL, DIACHI, QUOCTICH, DOITUONG, NGAYTAO, TinhTrangXoa)
VALUES('KH001', N'Nguyễn Hữu Lợi', N'Nam', '097825240004', '0973468462', N'huuloi9782@gmail.com', N'Số 36, Đ.Hoàng Hoa Thám TP.Hà Nội', N'Việt Nam', N'Cá Nhân', '17/02/2023 8:30:57', 0),
		('KH002', N'Hằng Tuyết Nga', N'Nữ', '873602738494', '0374946719', N'hangnga36@gmail.com', N'723, Đ.Lõa Xuân Mai TP.Thủ Dầu 1', N'Việt Nam', N'Doanh Nghiệp', '24/09/2022 15:24:07', 0),
		('KH003', N'John Wick', N'Nam', '359276401736', '0972382648', N'doglover36@gmail.com', N'247, Đ.Mỹ Việt TP.HCM', N'Mỹ', N'Cá Nhân', '30/11/2021 21:09:36', 0)

---THEM THONG TIN LOAI TAI KHOAN
GO
INSERT INTO LOAITK(MALOAITK, CHITIET, NGAYTAO, NGAYCAPNHAT, TRANGTHAI)
VALUES('LTK001', N'Tài Khoản Vip Cấp 1', '17/06/2018 08:30:57','17/06/2018 08:30:57', N'Còn Hoạt Động'),
		('LTK002', N'Tài Khoản Vip Cấp 2', '17/06/2018 08:31:23','17/06/2018 08:31:23', N'Ngưng Hoạt Động'),
		('LTK003', N'Tài Khoản Tiết Kiệm', '17/06/2018 08:32:02','17/06/2018 08:32:02', N'Còn Hoạt Động')

---THEM THONG TIN LAI SUAT
GO
INSERT INTO LAISUAT(MALAISUAT, TENLOAIVAY, LAISUAT, KIEULAI, SOTHANG, TinhTrangXoa)
VALUES
('LS01', N'Vay tiêu dùng', 3, N'Tháng', 3,N'Hoạt Động'),
('LS02', N'Vay tín dụng', 6, N'Tháng', 6,N'Hoạt Động'),
('LS03', N'Vay mua nhà', 12, N'Năm', 12,N'Hoạt Động');

---THEM THONG TIN KHUYEN MAI
GO
INSERT INTO KHUYENMAI(MAKM, TENKM, MOTA, NGAYBD, NGAYKT, DKAPDUNG, TinhTrangXoa)
VALUES
('KM001', N'Giảm lãi suất mùa hè', N'Giảm 1% cho khách hàng vay mới', '01/06/2023', '30/06/2023', N'Áp dụng cho khoản vay trên 50 triệu', N'Hoạt Động'),
('KM002', N'Tặng quà gửi tiết kiệm', N'Tặng quà khi gửi tiết kiệm từ 100 triệu', '01/07/2023', '31/07/2023', N'Áp dụng cho khách hàng cá nhân', N'Hoạt Động'),
('KM003', N'Ưu đãi phí chuyển khoản', N'Miễn phí 5 lần chuyển khoản đầu tiên', '01/08/2023', '31/08/2023', N'Áp dụng cho tài khoản mới', N'Hoạt Động');

---THEM THONG TIN NGOAI TE
GO
INSERT INTO NGOAITE(MANGOAITE, TENNGOAITE, KYHIEU, QUOCGIA, TRANGTHAI, TinhTrangXoa)
VALUES
('NT01', N'Đô la Mỹ', N'$', N'Mỹ', N'Hoạt động', N'Hoạt Động'),
('NT02', N'Euro', N'€', N'Liên minh Châu Âu', N'Ngừng hoạt động', N'Hoạt Động'),
('NT03', N'Việt Nam Đồng', N'₫', N'Việt Nam', N'Hoạt động', N'Hoạt Động');

---THEM THONG TIN TAI KHOAN
GO
INSERT INTO TAIKHOAN(MATK, MAKH, SOTAIKHOAN, MALOAITK, SODU, MANGOAITE, NGAYMOTK, TRANGTHAI)
VALUES('TK001', 'KH001', '8473833720', 'LTK001', 32078000, 'NT03', '17/02/2023 8:50:22', N'Hoạt Động'),
		('TK002', 'KH002', '7363264324', 'LTK002', 178964032, 'NT02', '24/09/2022 15:44:56', N'Hoạt Động'),
		('TK003', 'KH003', '9023827343', 'LTK003', 300000, 'NT01', '30/11/2021 21:39:12', N'Hoạt Động')

---THEM THONG TIN CHUYEN KHOAN
GO
INSERT INTO CHUYENKHOAN(MACK, MAKH, MATK, NGAYCK, SOTIEN, MATKGUI, MATKNHAN, NOIDUNG, TinhTrangXoa)
VALUES
('CK001', 'KH001', 'TK001', '17/06/2025', 5000000, 'TK001', 'TK002', N'Chuyển khoản thanh toán đơn hàng', N'Hoạt Động'),
('CK002', 'KH002', 'TK002', '18/06/2025', 12000000, 'TK002', 'TK003', N'Chuyển tiền tiết kiệm', N'Hoạt Động'),
('CK003', 'KH003', 'TK003', '19/06/2025', 8000000, 'TK003', 'TK001', N'Chuyển khoản hoàn tiền', N'Hoạt Động');

---THEM THONG TIN KHOAN VAY
GO
INSERT INTO KHOANVAY(MAVAY, MAKH, MATK, SOTIENVAY, TONGTIEN, NGAYVAY, THOIHAN, TRANGTHAI, MALAISUAT,TinhTrangXoa)
VALUES
('VAY001', 'KH001', 'TK001', 100000000, 100000000, '01/01/2023', '01/01/2024', N'Đang hoạt động', 'LS01',N'Hoạt Động'),
('VAY002', 'KH002', 'TK002', 50000000, 50000000, '05/02/2023', '05/02/2024', N'Đã tất toán', 'LS02',N'Hoạt Động'),
('VAY003', 'KH003', 'TK003', 75000000, 75000000, '10/03/2023', '10/03/2024', N'Quá hạn', 'LS03',N'Hoạt Động');

---THEM THONG TIN TRA NO
GO
INSERT INTO TRANO(MATRANO, MAVAY, SOTIENO, SOTIENTRA, NGAYTRA, TinhTrangXoa)
VALUES
('TN01', 'VAY001', 100000000, 20000000, '15/02/2023', N'Hoạt Động'),
('TN02', 'VAY002', 50000000, 25000000, '20/03/2023', N'Hoạt Động'),
('TN03', 'VAY003', 75000000, 30000000, '25/04/2023', N'Hoạt Động');

---THEM THONG TIN AP DUNG KHUYEN MAI
GO
INSERT INTO APDUNGKHUYENMAI(MAKM, MAKH, MATK, NGAYAPDUNG, TinhTrangXoa)
VALUES
('KM001', 'KH001', 'TK001', '02/06/2023', N'Hoạt Động'),
('KM002', 'KH002', 'TK002', '05/07/2023', N'Hoạt Động'),
('KM003', 'KH003', 'TK003', '03/08/2023',  N'Hoạt Động');

---THEM THONG TIN LOAI GIAO DICH
GO
INSERT INTO LOAIGD(MALOAIGD, TENLOAIGD, NGAYLAP, NGAYCAPNHAT, TRANGTHAI, TinhTrangXoa)
VALUES('LGD001', N'Rút Tiền', '17/06/2018 08:30:57', '17/06/2018 08:31:46', N'Hoạt Động', 0),
		('LGD002', N'Chi Tiêu', '17/06/2018 08:33:53', '17/06/2018 08:34:17', N'Hoạt Động', 0),
		('LGD003', N'Chuyển Khoản', '17/06/2018 08:35:37', '17/06/2018 08:36:02', N'Hoạt Động', 0)

---THEM THONG TIN LOAI HOP DONG
GO
INSERT INTO LOAIHD(MALOAIHD, TENLOAIHD, NGAYLAP, NGAYCAPNHAT, TRANGTHAI, TinhTrangXoa)
VALUES('LHD001', N'Hợp đồng tín dụng tiêu dùng', '17/06/2018 08:30:57', '17/06/2018 08:31:46', N'Hoạt Động', 0),
		('LHD002', N'Hợp đồng tín dụng ngắn hạn', '17/06/2018 08:33:53', '17/06/2018 08:34:17', N'Hoạt Động', 0),
		('LHD003', N'Hợp đồng tiền gửi', '17/06/2018 08:35:37', '17/06/2018 08:36:02', N'Hoạt Động', 0)

---THEM THONG TIN LOAI HO TRO
GO
INSERT INTO LOAIHT(MALOAIHT, TENLOAIHT, NGAYLAP, NGAYCAPNHAT, TRANGTHAI, TinhTrangXoa)
VALUES('LHT001', N'Tư vấn sản phẩm và dịch vụ', '17/06/2018 08:30:57', '17/06/2018 08:31:46', N'Hoạt Động', 0),
		('LHT002', N'Hỗ trợ giao dịch', '17/06/2018 08:33:53', '17/06/2018 08:34:17', N'Hoạt Động', 0),
		('LHT003', N'Tiếp nhận và xử lý phản hồi', '17/06/2018 08:35:37', '17/06/2018 08:36:02', N'Hoạt Động', 0)

---THEM THONG TIN GIAO DICH
GO
INSERT INTO GIAODICH(MAGD, MAKH, MATK, MALOAIGD, SOTIEN, THOIGIANGD, MOTA, TRANGTHAI, TinhTrangXoa)
VALUES('GD001', 'KH001', 'TK001', 'LGD003', 350000, '20/02/2023 12:45:33', N'Chuyển tiền sang tài khoản 7363264324', N'Đang Chờ Xử Lý',0),
		('GD002', 'KH002', 'TK002', 'LGD002', 120000, '21/11/2024 07:35:21', N'Nộp tiền vào tài khoản 7363264324', N'Thành Công',0),
		('GD003', 'KH003', 'TK003', 'LGD001', 70, '14/02/2024 15:31:12', N'Rút tiền', N'Thành Công',0)

---THEM THONG TIN HO TRO
GO
INSERT INTO HOTRO(MAHTRO, MAKH, MANV, MALOAIHT, NOIDUNG, NGAYHTRO, TinhTrangXoa)
VALUES('HT001', 'KH001', 'NV0001', 'LHT003', N'Yêu cầu chuyển tiền đang trong trạng thái xử lý', '20/02/2023 12:50:27', 0),
		('HT002', 'KH002', 'NV0004', 'LHT001', N'Hỗ trợ mở tài khoản ngân hàng', '24/09/2022 15:34:51', 0),
		('HT003', 'KH003', 'NV0004', 'LHT002', N'Rút tiền', '14/02/2024 15:31:12', 0)

---THEM THONG TIN HOP DONG
GO
INSERT INTO HOPDONG(SOHOPDONG, MALOAIHD, NGAYKY, NGAYHETHAN, GIATRI, GHICHU, TRANGTHAI, MANV, MAKH, TinhTrangXoa)
VALUES(N'HD-KH001-20102024-153112','LHD001', '20/10/2024 15:31:12', '20/11/2024 00:00:00', 50000000, N'Chi tiêu sinh hoạt gia đình', N'Đã Ký Kết', 'NV0001', 'KH001', 0),
		(N'HD-KH002-19122024-073541','LHD002', '19/12/2024 07:35:41', '19/12/2025 00:00:00', 240000000, N'Vay tiền khởi nghiệp', N'Đã Ký Kết', 'NV0004', 'KH002', 0)

---THEM THONG TIN BIEN LAI
GO
INSERT INTO BIENLAI(MABL, MAGD, MAKH, MATK, MANV, SOTIEN, MANGOAITE, MOTA, TRANGTHAI, TinhTrangXoa)
VALUES
('BL001', 'GD001', 'KH001', 'TK001', 'NV0001', 5000000, 'NT01', N'Khách hàng nộp tiền mặt', N'Đã in', N'Hoạt Động'),
('BL002', 'GD002', 'KH002', 'TK002', 'NV0002', 12000000, 'NT02', N'Thanh toán hóa đơn', N'Đã in', N'Hoạt Động'),
('BL003', 'GD003', 'KH003', 'TK003', 'NV0003', 8000000, 'NT03', N'Thanh toán dịch vụ', N'Chưa in', N'Hoạt Động');

--LOGIN
GO
INSERT INTO DANGNHAP(MADN,PASS,QUYEN,MANV,TRANGTHAI)
VALUES
('admin01', 'admin@123', 'ADMIN', 'NV0003',1),
('anlt', 'an@123', 'NHANVIEN', 'NV0001',1);

---NOI QUY
GO
INSERT INTO NOIQUY (MANQ, TIEUDE, MOTA, NGAYBH, LOAIAPDUNG, TrangThai)
VALUES
('NQ001', N'Đi làm trễ', N'Nhân viên đi trễ quá 15 phút mà không báo trước.', '05/01/2023', N'Phạt 50.000đ/lần', 1),
('NQ002', N'Không mang đồng phục', N'Nhân viên không mặc đồng phục theo quy định của công ty.', '12/02/2023', N'Phạt 30.000đ/lần', 1),
('NQ003', N'Vắng mặt không phép', N'Nghỉ làm mà không có đơn xin phép hợp lệ.', '20/03/2023', N'Phạt 100.000đ/lần', 1),
('NQ004', N'Sử dụng điện thoại trong giờ làm', N'Dùng điện thoại cá nhân để lướt mạng, chơi game trong giờ làm.', '18/04/2023', N'Phạt 20.000đ/lần', 1),
('NQ005', N'Không tuân thủ an toàn lao động', N'Không mang đồ bảo hộ khi làm việc tại khu vực quy định.', '25/05/2023', N'Phạt 150.000đ/lần', 1),
('NQ006', N'Xô xát hoặc gây mâu thuẫn', N'Cãi nhau hoặc đánh nhau trong công ty.', '30/06/2023', N'Phạt 300.000đ + cảnh cáo', 1),
('NQ007', N'Sử dụng tài sản công ty cho việc cá nhân', N'Dùng máy in, thiết bị công ty cho việc riêng.', '05/08/2023', N'Phạt 80.000đ/lần', 1),
('NQ008', N'Không giữ gìn vệ sinh nơi làm việc', N'Bỏ rác bừa bãi hoặc làm bẩn khu vực chung.', '12/09/2023', N'Phạt 10.000đ/lần', 1),
('NQ009', N'Tiết lộ thông tin công ty', N'Chia sẻ thông tin nội bộ ra ngoài.', '22/10/2023', N'Phạt 500.000đ và kỷ luật', 1),
('NQ010', N'Tái phạm nội quy nhiều lần', N'Vi phạm 3 lần trở lên trong tháng.', '01/11/2023', N'Phạt 1 ngày lương', 1);

GO
INSERT INTO VIPHAM (MAVP, MANQ, MANV, NGAYVP, MOTAVP, HINHTHUCXL, TRANGTHAIXL, TrangThai)
VALUES
('VP001', 'NQ001', 'NV0001', '05/10/2024', N'Đi làm trễ 30 phút', N'Cảnh cáo miệng', N'ĐÃ XỬ LÝ', 1),
('VP002', 'NQ002', 'NV0002', '12/09/2024', N'Không mặc đồng phục khi đi làm', N'Phạt 30.000đ', N'CHƯA XỬ LÝ', 1),
('VP003', 'NQ003', 'NV0003', '18/08/2024', N'Nghỉ làm không phép 1 ngày', N'Phạt 100.000đ', N'ĐÃ XỬ LÝ', 1),
('VP004', 'NQ004', 'NV0004', '22/07/2024', N'Dùng điện thoại chơi game trong giờ làm', N'Phạt 20.000đ', N'ĐÃ XỬ LÝ', 1),
('VP005', 'NQ005', 'NV0005', '10/06/2024', N'Không mang đồ bảo hộ khi vào khu vực máy móc', N'Phạt 150.000đ', N'CHƯA XỬ LÝ', 1);