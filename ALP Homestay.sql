/*==============================================================*/
/* DBMS name:      indramar_20232_dbd_3                                    */
/* Created on:     30/04/2024 11:48:06 AM                         */
/*==============================================================*/
drop database if exists indramar_20232_dbd_3;
create database if not exists indramar_20232_dbd_3;
use indramar_20232_dbd_3;

drop table if exists STAFF;

drop table if exists GUEST_INFORMATION;

drop table if exists RUMAH;

drop table if exists BOOKING_INFORMATION;

drop table if exists FINANCIAL_TRANSACTION;

/*========================================================*/
/* Table: STAFF                                           */
/*========================================================*/
CREATE TABLE STAFF(
	staff_id varchar(3) PRIMARY KEY,
    staff_nik varchar(16) NOT NULL,
    staff_nama varchar(50) NOT NULL,
    staff_gender char(1) NOT NULL,
    staff_tgl_lahir date NOT NULL,
    staff_alamat varchar(100) NOT NULL,
    staff_no_telp varchar(12) NOT NULL,
    staff_email varchar(50) NOT NULL,
    status_del char(1) NOT NULL
);

INSERT INTO STAFF(staff_id, staff_nik, staff_nama, staff_gender, staff_tgl_lahir, staff_alamat, staff_no_telp, staff_email, status_del) VALUES 
('S01','3306170103950004','Alex Davin','L','19950301','Jl. Peneleh No.3','082176655211','alex01@gmail.com','0'),
    ('S02','3117211612990001','Audy Jesslyn','P','19991216','Jl. Melati No. 10','082312845331','audy01@gmail.com','0'),
    ('S03','3112200508930005','Angel Aura','P','19930805','Jl. Raya Bogor No. 168','082552824561','angel01@gmail.com','0'),
    ('S04','3234012809940002','Axel Liam','L','19940928','Jl. Diponegoro No. 32A','081337614289','axel01@gmail.com','0'),
    ('S05','3123040402020004','Claudine Kirana','P','20020204','Jl. Kaliurang No. 78','082366211985','claudine01@gmail.com','0'),
    ('S06','3403011803990009','Vano Dave','L','19990318','Jl. Raya Gubeng No. 54','082836859758','vano01@gmail.com','0'),
    ('S07','3210042407940001','Vania Zara','P','19940724','Jl. Hasanuddin No. 12','081211676439','vania01@gmail.com','0'),
    ('S08','3210210107020012','Etharia Aisyah','P','20020701','Jl. Gatot Subroto No. 88','085184936812','etharia01@gmail.com','0'),
    ('S09','3103212104940001','Arlyn Putri','P','19940421','Jl. Sudirman No. 33B','082329317937','arlyn01@gmail.com','0'),
    ('S10','3423011606920007','Nathan Avren','L','19920616','Jl. DI Panjaitan No. 5','085438342957','nathan01@gmail.com','0'),
    ('S11','3301022406930002','Yeni Nayla','P','19930624','Jl. Sultan Agung No. 101','085793856458','yeni01@gmail.com','0'),
    ('S12','3102010802010008','Aron Nic','L','20010208','Jl. Gubeng No. 76','082355233963','aron01@gmail.com','0'),
    ('S13','3123020501900003','Shanon Rein','L','19900105','Jl. Nias No. 10','085148764864','shanon01@gmail.com','0'),
    ('S14','3212092705010001','Sheila Aisha','P','20010527','Jl. Kamalaputi No. 13','085799796964','sheila01@gmail.com','0'),
    ('S15','3620091711020009','Trevis Reynard','L','20021117','Jl. Hambala No. 18','081519569488','trevis01@gmail.com','0'),
    ('S16','3123101202900006','Steven Arya','L','19900212','Jl. Wanggameti No. 21','081575729194','steven01@gmail.com','0'),
    ('S17','3313021206930004','Xavier Devan','L','19930612','Jl. Dermaga Baru No. 16','081573667927','xavier01@gmail.com','0'),
    ('S18','3213081810020002','Lia Nadine','P','20021018','Jl. Prunas No. 14','082574882741','lia01@gmail.com','0'),
    ('S19','3512011305010011','Trevis Gavrel','L','20010513','Jl. Matawai No. 7','082152795299','trevis02@gmail.com','0'),
    ('S20','3421101201920001','Lea Kiara','P','19920112','Jl. Payeti No. 37','085693116187','lea01@gmail.com','0');

/*==============================================================*/
/* Table: GUEST_INFORMATION                                     */
/*==============================================================*/
CREATE TABLE GUEST_INFORMATION(
	guest_id varchar(6) PRIMARY KEY,
    guest_nik varchar(16) NOT NULL,
    guest_nama varchar(50) NOT NULL,
    guest_tgl_lhr date NOT NULL,
    guest_gender char(1) NOT NULL,
    guest_notelp varchar(12) NOT NULL,
    guest_email varchar(50) NOT NULL,
    guest_alamat varchar(100) NOT NULL,
    guest_kewarganegaraan varchar(10) NOT NULL,
    status_del char(1) NOT NULL
    );
    
INSERT INTO GUEST_INFORMATION (guest_id, guest_nik, guest_nama, guest_tgl_lhr, guest_gender, guest_notelp, guest_email, guest_alamat, guest_kewarganegaraan, status_del) VALUES
('GM0001' , '3578070602342001' , 'Michael' , '1998-02-11' , 'L' , '082123535432' , 'michael@gmail.com' , 'Jl Bali No 33, Surabaya' , 'Indonesia' , '0'),
    ('GR0001' , '3578030421345563' , 'Rio' , '1987-04-22' , 'L' , '082431425545' , 'rio@gmail.com' , 'Jl Jeruk No 65, Surabaya' , 'Indonesia' , '0'),
    ('GT0001' , '3578093234231432' , 'Thalia' , '1997-12-08' , 'P' , '081231243255' , 'thalia@gmail.com' , 'Jl Tugu No 12, Kediri' , 'Indonesia' , '0'),
    ('GH0001' , '3578032423465749' , 'Heru' , '1978-09-27' , 'L' , '081233456575' , 'heru@gmail.com' , 'Jl Tempe No 17, Lampung' , 'Indonesia' , '0'),
    ('GY0001' , '3578923423494757' , 'Yuli' , '1988-01-13' , 'P' , '082134246568' , 'yuli@gmail.com' , 'Jl Gandum no 34, Jepara' , 'Indonesia' , '0'),
    ('GI0001' , '3578342432439576' , 'Ivan' , '2000-01-30' , 'L' , '081233240353' , 'ivan@gmail.com' , 'Jl Paru No 77, Surakarta' , 'Indonesia' , '0'),
    ('GP0001' , '3578234234353411' , 'Patricia' , '2001-06-22' , 'P' , '081233558765' , 'patricia@gmail.com' , 'Jl Hemat No 83, Madura' , 'Indonesia' ,'0'),
    ('GN0001' , '3578984657832415' , 'Nurul' , '2000-05-24' , 'P' , '081235575677' , 'nurul@gmail.com' , 'Jl Kudanil No 1, Klaten' , 'Indonesia' , '0'),
    ('GM0002' , '3578234982341436' , 'Mira' , '1999-12-11' , 'P' , '082253534632' , 'mira@gmail.com' , 'Jl Kucing No 22, Nganjuk' , 'Indonesia' , '0'),
    ('GV0001' , '3578945756704324' , 'Virly' , '1998-01-22' , 'P' , '081235235785' , 'virly@gmail.com' , 'Jl. Kepiting No 2, Surabaya' , 'Indonesia' , '0'),
    ('GU0001' , '3578923504784243' , 'Umi' , '2002-04-02' , 'P' , '082232546346' , 'umi@gmail.com' , 'Jl Gang Buntu No 99, Blitar' , 'Indonesia' , '0'),
    ('GL0001' , '3578329432059231' , 'Listy' , '1999-09-09' , 'P' , '081233536467' , 'listy@gmail.com' , 'Jl Merak No 31, Surabaya' , 'Indonesia' , '0'),
    ('GA0001' , '3578932560238425' , 'Amanda' , '1973-08-17' , 'P' , '082243645789' , 'amanda@gmail.com' , 'Jl. Manukan No 11, Surabaya' , 'Indonesia' , '0'),
    ('GK0001' , '3578934460346346' , 'Kevin' , '2005-05-25' , 'L' , '082133575758' , 'kevin@gmail.com' , 'Jl Kenjeran No 69, Surabaya' , 'Indonesia' , '0'),
    ('GS0001' , '3578234465946745' , 'Stanley' , '2001-03-19' , 'L' , '081245457474' , 'stanley@gmail.com' , 'Jl Lidah Semanggi No 63, Palangkaraya', 'Indonesia' , '0'),
    ('GO0001' , '3578645463759349' , 'Owen' , '2000-03-28' , 'L' , '082210583759' , 'owen@gmail.com' , 'Jl Buntung No 15, Cirebon' , 'Indonesia' , '0'),
    ('GS0002' , '3578293457342825' , 'Sesil' , '1986-10-12' , 'P' , '081234767787' , 'sesil@gmail.com' , 'Jl Nisar No 44, Malang' , 'Indonesia' , '0'),
    ('GB0001' , '3578329523168236' , 'Budi' , '1982-08-15' , 'L' , '082246349765' , 'budi@gmail.com' , 'Jl Ambengan No 13, Batu' , 'Indonesia' , '0'),
    ('GK0002' , '3578232039304283' , 'Karin' , '1979-09-17', 'P' , '082213563466' , 'karin@gmail.com' , 'Jl Kidul No 55, Semarang' , 'Indonesia' , '0'),
    ('GA0002' , '3578394757485394' , 'Aurelius' , '1979-04-11' , 'L' , '082238349535' , 'aurel@gmail.com' , 'Jl Besi No 10, Salatiga' , 'Indonesia' , '0');

/*========================================================*/
/* Table: RUMAH                                           */
/*========================================================*/
CREATE TABLE RUMAH(
	rumah_id varchar(3) PRIMARY KEY,
    staff_id varchar(3) NOT NULL,
    rumah_nama varchar(50) NOT NULL,
    rumah_alamat varchar(100) NOT NULL,
    rumah_jml_kamar varchar(1) NOT NULL,
    rumah_deskripsi varchar(1000) NOT NULL,
    rumah_harga_sewa int NOT NULL,
    status_del char(1) NOT NULL
);

INSERT INTO RUMAH(rumah_id, staff_id, rumah_nama, rumah_alamat, rumah_jml_kamar, rumah_deskripsi, rumah_harga_sewa, status_del) VALUES
	('R01','S01','Mawar','Greenlake, JL. Palma, RT 01 RW 03 No.1','2','Terletak di depan kolam renang, rumah ini memiliki dua kamar tidur yang luas dan 
    nyaman, dilengkapi dengan satu kamar mandi pribadi dengan pemandangan yang menakjubkan. 
    Ruang tamu dengan tv yang lapang dan terbuka menghadap langsung ke taman belakang dan 
    dilengkapi dengan full ac.','500000','0'),
    ('R02','S02','Tulip','Lakewood, JL. Raffles, RT 01 RW 03 No. 3','4','Terletak dekat dengan mall, rumah ini memiliki empat kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan pemandangan yang menakjubkan. 
    Ruang tamu dengan tv yang lapang dan terbuka menghadap langsung ke kolam renang pribadi 
    dan dilengkapi dengan full ac.','1000000','0'),
    ('R03','S03','Lili','Aether, JL. Lagoon, RT 02 RW 05 No. 1','5','Terletak dekat dengan mall, rumah ini memiliki lima kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan satu kamar mandi luar dengan 
    pemandangan yang menakjubkan. Ruang tamu dengan tv yang lapang dan terbuka menghadap 
    langsung ke kolam renang pribadi dan dilengkapi dengan full ac.','1250000','0'),
    ('R04','S04','Daisy','Greenlake, JL. Palma, RT 01 RW 03 No.3','2','Terletak depan kolam renang, rumah ini memiliki dua kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan pemandangan yang menakjubkan. 
    Ruang tamu dengan tv yang lapang dan terbuka menghadap langsung ke taman belakang dan 
    dilengkapi dengan full ac.','500000','0'),
    ('R05','S05','Anggrek','Greenlake, JL. Palma, RT 01 RW 03 No.5','3','Terletak depan kolam renang, rumah ini memiliki tiga kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan satu kamar mandi luar dengan 
    pemandangan yang menakjubkan. Ruang tamu dengan tv yang lapang dan terbuka menghadap 
    langsung ke taman belakang dan dilengkapi dengan full ac.','750000','0'),
    ('R06','S06','Melati','Aether, JL. Lagoon, RT 02 RW 05 No. 5','5','Terletak dekat dengan mall, rumah ini memiliki lima kamar tidur yang luas dan nyaman, 
masing-masing dilengkapi dengan kamar mandi pribadi dan satu kamar mandi luar dengan 
    pemandangan yang menakjubkan. Ruang tamu dengan tv yang lapang dan terbuka menghadap 
    langsung ke kolam renang pribadi dan dilengkapi dengan full ac.','1250000','0'),
    ('R07','S07','Teratai','Marigold, JL. Emerald, RT 01 RW 01 No. 10','3','Terletak di lokasi yang strategis di tengah kota, rumah ini memiliki tiga kamar tidur 
    yang luas dan nyaman, masing-masing dilengkapi dengan kamar mandi pribadi dan satu kamar 
    mandi luar dengan pemandangan yang menakjubkan. Ruang tamu dengan tv yang lapang dan 
    terbuka menghadap langsung ke taman belakang dan dilengkapi dengan full ac.','750000','0'),
    ('R08','S08','Peoni','Greenlake, JL. Palma, RT 01 RW 03 No.10','2','Terletak depan kolam renang, rumah ini memiliki dua kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan pemandangan yang menakjubkan. 
    Ruang tamu dengan tv yang lapang dan terbuka menghadap langsung ke taman belakang dan 
    dilengkapi dengan full ac.','500000','0'),
    ('R09','S09','Dahlia','Lakewood, JL. Raffles, RT 03 RW 03 No. 5','4','Terletak di depan danau, rumah ini memiliki empat kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan pemandangan yang menakjubkan. 
    Ruang tamu dengan tv yang lapang dan terbuka menghadap langsung ke kolam renang pribadi 
    dan dilengkapi dengan full ac.','1000000','0'),
    ('R10','S10','Iris','Jade, JL. Mansion, No. 2','4','Terletak dekat dengan mall, rumah ini memiliki empat kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan pemandangan yang menakjubkan. 
    Ruang tamu dengan tv yang lapang dan terbuka menghadap langsung ke kolam renang pribadi 
    dan dilengkapi dengan full ac.','1000000','0'),
    ('R11','S11','Blossom','Marigold, JL. Emerald, RT 01 RW 01 No. 12','2','Terletak di lokasi yang strategis di tengah kota, rumah ini memiliki dua kamar tidur 
    yang luas dan nyaman, masing-masing dilengkapi dengan kamar mandi pribadi dan pemandangan 
    yang menakjubkan. Ruang tamu dengan tv yang lapang dan terbuka menghadap langsung ke taman 
    belakang dan dilengkapi dengan full ac.','500000','0'),
    ('R12','S12','Acacia','Jade, JL. Mansion, No. 6','5','Terletak dekat dengan mall, rumah ini memiliki lima kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan satu kamar mandi luar dengan 
    pemandangan yang menakjubkan. Ruang tamu dengan tv yang lapang dan terbuka menghadap 
    langsung ke kolam renang pribadi dan dilengkapi dengan full ac.','1250000','0'),
    ('R13','S13','Clover','Marigold, JL. Emerald, RT 01 RW 01 No. 15','2','Terletak di lokasi yang strategis di tengah kota, rumah ini memiliki dua kamar tidur 
    yang luas dan nyaman, masing-masing dilengkapi dengan kamar mandi pribadi dan pemandangan 
    yang menakjubkan. Ruang tamu dengan tv yang lapang dan terbuka menghadap langsung ke taman 
 belakang dan dilengkapi dengan full ac.','500000','0'),
    ('R14','S14','Danica','Aether, JL. Lagoon, RT 02 RW 05 No. 7','5','Terletak dekat dengan mall, rumah ini memiliki lima kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan satu kamar mandi luar dengan 
    pemandangan yang menakjubkan. Ruang tamu dengan tv yang lapang dan terbuka menghadap 
    langsung ke kolam renang pribadi dan dilengkapi dengan full ac.','1250000','0'),
    ('R15','S15','Edelweiss','Marigold, JL. Emerald, RT 01 RW 01 No. 20','3','Terletak di lokasi yang strategis, rumah ini memiliki tiga kamar tidur yang luas dan 
    nyaman, masing-masing dilengkapi dengan kamar mandi pribadi dan satu kamar mandi luar 
    dengan pemandangan yang menakjubkan. Ruang tamu dengan tv yang lapang dan terbuka menghadap 
    langsung ke taman belakang dan dilengkapi dengan full ac.','750000','0'),
    ('R16','S16','Hyacinth','Jade, JL. Mansion, No. 8','5','Terletak dekat dengan mall, rumah ini memiliki lima kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan satu kamar mandi luar dengan 
    pemandangan yang menakjubkan. Ruang tamu dengan tv yang lapang dan terbuka menghadap 
    langsung ke kolam renang pribadi dan dilengkapi dengan full ac.','1250000','0'),
    ('R17','S17','Lavender','Lakewood, JL. Raffles, RT 03 RW 03 No. 9','4','Terletak di depan danau, rumah ini memiliki empat kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan pemandangan yang menakjubkan. 
    Ruang tamu dengan tv yang lapang dan terbuka menghadap langsung ke kolam renang pribadi 
    dan dilengkapi dengan full ac.','1000000','0'),
    ('R18','S18','Liana','Jade, JL. Mansion,  No. 10','4','Terletak dekat dengan mall, rumah ini memiliki empat kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan pemandangan yang menakjubkan. 
    Ruang tamu dengan tv yang lapang dan terbuka menghadap langsung ke kolam renang pribadi 
    dan dilengkapi dengan full ac.','1000000','0'),
    ('R19','S19','Violet','Greenlake, JL. Palma, RT 01 RW 03 No.15','3','Terletak depan kolam renang, rumah ini memiliki tiga kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan satu kamar mandi luar dengan 
    pemandangan yang menakjubkan. Ruang tamu dengan tv yang lapang dan terbuka menghadap 
    langsung ke taman belakang dan dilengkapi dengan full ac.','750000','0'),
    ('R20','S20','Cassia','Lakewood, JL. Raffles, RT 03 RW 03 No. 7','4','Terletak di depan danau, rumah ini memiliki empat kamar tidur yang luas dan nyaman, 
    masing-masing dilengkapi dengan kamar mandi pribadi dan pemandangan yang menakjubkan. 
    Ruang tamu dengan tv yang lapang dan terbuka menghadap langsung ke kolam renang pribadi 
    dan dilengkapi dengan full ac.','1000000','0');

/*==============================================================*/
/* Table: BOOKING_INFORMATION                                   */
/*==============================================================*/
CREATE TABLE BOOKING_INFORMATION(
	booking_id varchar(9) PRIMARY KEY,
    rumah_id varchar (3) NOT NULL,
    staff_id varchar (3) NOT NULL,
    guest_id varchar (6) NOT NULL,
    booking_tgl datetime NOT NULL,
    booking_total_biaya int NOT NULL,
    booking_tgl_cin datetime NOT NULL,
    booking_tgl_cout datetime NOT NULL,
    status_del char(1) NOT NULL
);

INSERT INTO BOOKING_INFORMATION (booking_id, rumah_id, guest_id, staff_id, booking_tgl, booking_total_biaya, booking_tgl_cin, booking_tgl_cout, status_del) VALUES
-- salah
    ('B24050101' , 'R01', 'GM0001', 'S01', '2024-04-20 16:43' , '500000' , '2024-05-01 16:02' , '2024-05-02 11:34' , '0'),
    ('B24050401' , 'R02', 'GR0001', 'S02', '2024-04-25 11:32' , '3000000' , '2024-05-04 14:30' , '2024-05-07 08:32' , '0'),
    ('B24050402' , 'R03', 'GT0001', 'S03',  '2024-04-27 23:59' , '1250000' , '2024-05-04 19:04' , '2024-05-05 11:30' , '0'),
    ('B24050501' , 'R04', 'GH0001', 'S04',  '2024-04-30 10:52' , '500000' , '2024-05-05 15:33' , '2024-05-06 10:36' , '0'),
    ('B24050601' , 'R05', 'GY0001', 'S05', '2024-04-30 13:32' , '1500000' , '2024-05-06 20:31' , '2024-05-08 09:43' , '0'),
    ('B24050602' , 'R06', 'GI0001', 'S06', '2024-05-02 09:32' , '2500000' , '2024-05-06 14:43' , '2024-05-08 10:39' , '0'),
    ('B24050801' , 'R08', 'GP0001', 'S08', '2024-05-03 14:45' , '2000000' , '2024-05-08 17:43' , '2024-05-12 09:29' , '0'),
 -- salah   
	('B24050901' , 'R11', 'GN0001', 'S20', '2024-05-03 22:23' , '1000000' , '2024-05-09 21:30' , '2024-05-11 09:37' , '0'),
    ('B24051001' , 'R07', 'GM0002', 'S07', '2024-05-04 13:23' , '2250000' , '2024-05-10 14:48' , '2024-05-13 07:49' , '0'),
    ('B24051201' , 'R13', 'GV0001', 'S14', '2024-05-06 23:23' , '1000000' , '2024-05-12 15:32' , '2024-05-14 11:59' , '0'),    
    ('B24051501' , 'R09', 'GU0001', 'S20', '2024-05-07 15:34' , '1000000' , '2024-05-15 18:32' , '2024-05-16 10:54' , '0'),
    ('B24051502' , 'R01', 'GL0001', 'S01',  '2024-05-09 07:00' , '1500000' , '2024-05-15 19:45' , '2024-05-18 08:10' , '0'),
    ('B24051801' , 'R04', 'GA0001', 'S04',  '2024-05-10 10:32' , '1000000' , '2024-05-18 20:19' , '2024-05-20 09:20' , '0'),
    ('B24051901' , 'R08', 'GK0001', 'S06', '2024-05-12 15:29' , '1500000' , '2024-05-19 14:23' , '2024-05-22 08:32' , '0'),
    ('B24051902' , 'R14', 'GS0001', 'S14', '2024-05-13 19:30' , '3750000' , '2024-05-19 14:00' , '2024-05-22 09:21' , '0'),
    ('B24052001' , 'R11', 'GO0001', 'S08', '2024-05-19 23:59' , '500000' , '2024-05-20 19:42' , '2024-05-21 09:32' , '0'),
    ('B24052301' , 'R17', 'GS0001', 'S17',  '2024-05-17 21:43' , '1000000' , '2024-05-23 15:32' , '2024-05-24 10:39' , '0'),
    ('B24052501' , 'R19', 'GB0001', 'S20', '2024-05-16 17:32' , '750000' , '2024-05-25 14:38' , '2024-05-26 10:45' , '0'),
    -- salah
    ('B24052601' , 'R05', 'GK0002', 'S05' , '2024-05-21 19:09' , '750000' , '2024-05-26 18:43' , '2024-05-27 11:42' , '0'),
    ('B24052801' , 'R01', 'GA0002', 'S12', '2024-05-26 12:00' , '1500000' , '2024-05-28 15:32' , '2024-05-31 08:32' , '0'),
    
('B24060601', 'R03', 'GB0001', 'S13', '2024-06-05 13:54:00', 2500000, '2024-06-06 13:54:00', '2024-06-08 13:54:00', 0),
('B24060701', 'R03', 'GU0001','S10' , '2024-06-05 19:17:00', 2500000, '2024-06-07 19:17:00', '2024-06-09 19:17:00', 0),
('B24060702', 'R06', 'GS0001' ,'S08' , '2024-06-05 19:22:00', 2500000, '2024-06-07 19:22:00', '2024-06-09 19:22:00', 0),
('B24060801', 'R04', 'GH0001' ,'S04', '2024-06-06 21:23:00', 1000000, '2024-06-08 21:23:00', '2024-06-10 21:23:00', 0);

/*==============================================================*/
/* Table: FINANCIAL_TRANSACTION                                 */
/*==============================================================*/
CREATE TABLE IF NOT EXISTS FINANCIAL_TRANSACTION(
trans_id varchar(11) PRIMARY KEY,
    booking_id varchar(9) NOT NULL,
    trans_tgl datetime NOT NULL,
    trans_jml_bayar int NOT NULL,
    trans_tipe_bayar varchar(6) NOT NULL,
    trans_status_bayar varchar(2) NOT NULL,
    trans_metode_bayar varchar(6) NOT NULL,
    status_del char(1) NOT NULL
);

insert into FINANCIAL_TRANSACTION (trans_id, booking_id, trans_tgl, trans_jml_bayar, trans_tipe_bayar, trans_status_bayar, trans_metode_bayar, status_del) VALUES 
-- salah
('TDP24042001','B24050101','2024-04-20 16:43',250000,'DP','B','Tf',0),
('TLU24050101','B24050101','2024-05-01 16:02',250000,'Lunas','B','Cash',0),
('TDP24042501','B24050401','2024-04-25 11:32',1500000,'DP','B','Tf',0),
('TLU24050401','B24050401','2024-05-04 14:30',1500000,'Lunas','B','Debit',0),
('TDP24042701','B24050402','2024-04-27 23:59',625000,'DP','B','QRIS',0),
('TLU24050402','B24050402','2024-05-04 19:04',625000,'Lunas','B','Kredit',0),
('TDP24043001','B24050501','2024-04-30 10:54',250000,'DP','B','Tf',0),
('TLU24050501','B24050501','2024-05-05 15:33',250000,'Lunas','B','Kredit',0),
('TDP24043002','B24050601','2024-04-30 13:22',750000,'DP','B','QRIS',0),
('TLU24050601','B24050601','2024-05-06 20:31',750000,'Lunas','B','Debit',0),
('TDP24050201','B24050602','2024-05-02 09:32',1250000,'DP','B','Tf',0),
('TLU24050602','B24050602','2024-05-06 20:31',1250000,'Lunas','B','Debit',0),
('TDP24050301','B24050801','2024-05-03 14:45',1000000,'DP','B','QRIS',0),
('TLU24050801','B24050801','2024-05-08 17:43',1000000,'Lunas','B','Kredit',0),
('TDP24050302','B24050901','2024-05-03 22:23',500000,'DP','B','QRIS',0),
('TLU24050901','B24050901','2024-05-09 21:30',500000,'Lunas','B','Debit',0),
('TDP24050401','B24051001','2024-05-04 13:23',1125000,'DP','B','Tf',0),
('TRE24050701','B24051001','2024-05-07 14:50',281250,'Refund','B','Tf',0),
('TDP24050601','B24051201','2024-05-06 23:23',500000,'DP','B','QRIS',0),
('TLU24051201','B24051201','2024-05-12 15:32',500000,'Lunas','B','Kredit',0),  
('TDP24050701','B24051501','2024-05-07 15:34',500000,'DP','B','QRIS',0),
('TLU24051501','B24051501','2024-05-15 18:32',500000,'Lunas','B','Debit',0),
('TDP24090501','B24051502','2024-05-09 07:00',750000,'DP','B','QRIS',0),
('TLU24051502','B24051502','2024-05-15 19:45',750000,'Lunas','B','QRIS',0),    
('TDP24051001','B24051801','2024-05-10 10:32',500000,'DP','B','Tf',0),
('TLU24051801','B24051801','2024-05-18 20:19',500000,'Lunas','B','QRIS',0),    
('TDP24051201','B24051901','2024-05-12 15:29',750000,'DP','B','Tf',0),
('TLU24051901','B24051901','2024-05-19 14:23',750000,'Lunas','B','QRIS',0), 
('TDP24051301','B24051902','2024-05-13 19:30',1875000,'DP','B','QRIS',0),
('TLU24051902','B24051902','2024-05-19 14:00',1875000,'Lunas','B','Tf',0),
('TDP24051901','B24052001','2024-05-19 23:59',250000,'DP','B','QRIS',0),
('TLU24052001','B24052001','2024-05-20 19:42',250000,'Lunas','B','QRIS',0),
('TDP24051701','B24052301','2024-05-17 21:43',500000,'DP','B','Tf',0),
('TRE24052001','B24052301','2024-05-20 15:39',120000,'Refund','B','Tf',0),
('TDP24051601','B24052501','2024-05-16 17:32',375000,'DP','B','Tf',0),
('TLU24052501','B24052501','2024-05-25 14:38',375000,'Lunas','B','QRIS',0),
-- salah
('TDP24052101','B24052601','2024-05-21 19:09',375000,'DP','B','QRIS',0),
('TLU24052601','B24052601','2024-05-26 18:43',375000,'Lunas','B','Debit',0),
('TDP24052601','B24052801','2024-05-26 12:00',750000,'DP','B','QRIS',0),
('TLU24052801','B24052801','2024-05-28 15:32',750000,'Lunas','B','Kredit',0);

insert into FINANCIAL_TRANSACTION (trans_id, booking_id, trans_tgl, trans_jml_bayar, trans_tipe_bayar, trans_status_bayar, trans_metode_bayar, status_del) VALUES 
-- salah
('TDP24060603','B24060701','2024-06-06 16:43',250000,'DP','B','Tf',0),
('TLU24060602', 'B24060801', '2024-06-06 20:55:00', 500000, 'Lunas', 'B', 'Tf', 0),
('TDP24060601', 'B24060601', '2024-06-06 16:43:00', 2500000, 'DP', 'B', 'Tf', 0),
('TDP24060701', 'B24060701', '2024-06-06 16:43:00', 2500000, 'DP', 'B', 'Tf', 0),
('TDP24060702', 'B24060702', '2024-06-06 16:43:00', 2500000, 'DP', 'B', 'Tf', 0),
('TDP24060801', 'B24060801', '2024-06-06 16:43:00', 1000000, 'DP', 'B', 'Tf', 0);


ALTER TABLE RUMAH ADD CONSTRAINT FOREIGN KEY (staff_id)
	REFERENCES STAFF (staff_id) ON DELETE RESTRICT ON UPDATE RESTRICT;

 ALTER TABLE BOOKING_INFORMATION ADD CONSTRAINT FOREIGN KEY (rumah_id)
	REFERENCES RUMAH(rumah_id) ON DELETE RESTRICT ON UPDATE RESTRICT;

ALTER TABLE BOOKING_INFORMATION ADD CONSTRAINT FOREIGN KEY (guest_id)
	REFERENCES GUEST_INFORMATION(guest_id) ON DELETE RESTRICT ON UPDATE RESTRICT;
    
ALTER TABLE BOOKING_INFORMATION ADD CONSTRAINT FOREIGN KEY (staff_id)
	REFERENCES STAFF(staff_id) ON DELETE RESTRICT ON UPDATE RESTRICT; 
    
ALTER TABLE FINANCIAL_TRANSACTION ADD CONSTRAINT FOREIGN KEY (booking_id)
	REFERENCES BOOKING_INFORMATION(booking_id) ON DELETE RESTRICT ON UPDATE RESTRICT;

