-- 1. PERSONELLER TABLOSU
CREATE TABLE Personeller (
    TC CHAR(11) PRIMARY KEY,
    AD NVARCHAR(50),
    SOYAD NVARCHAR(50),
    GorevUnvani NVARCHAR(100),
    DEPARTMAN NVARCHAR(100),
    TabanMAAS DECIMAL(18,2),
    MAAS DECIMAL(18,2), -- Net Maaş (Çocuk yardımı dahil)
    CocukSayisi INT,
    Telefon NVARCHAR(20),
    Eposta NVARCHAR(100),
    Adres NVARCHAR(250),
    MedeniDurum NVARCHAR(20),
    DogumTarihi DATETIME,
    DogumYeri NVARCHAR(50) DEFAULT 'Belirtilmedi'
);

-- 2. ARACLAR TABLOSU
CREATE TABLE Araclar (
    AracNO NVARCHAR(50) PRIMARY KEY,
    Marka NVARCHAR(50),
    Model NVARCHAR(50),
    KapasiteKG INT,
    Plaka NVARCHAR(20),
    AracTipi NVARCHAR(100),
    RotaBilgisi NVARCHAR(100),
    Durum NVARCHAR(50),
    SorumluPersonelTC CHAR(11),
    FOREIGN KEY (SorumluPersonelTC) REFERENCES Personeller(TC)
);

-- 3. ATIK HAREKETLERI TABLOSU
CREATE TABLE AtikHareketleri (
    IslemID INT PRIMARY KEY IDENTITY(1,1),
    AracNO NVARCHAR(50),
    AtikTuru NVARCHAR(50),
    GelenMiktarKG DECIMAL(18,2),
    DonusturulenMiktarKG DECIMAL(18,2),
    VerimYuzdesi DECIMAL(5,2),
    EldeEdilenGelir DECIMAL(18,2),
    IslemTarihi DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (AracNO) REFERENCES Araclar(AracNO)
);

-- 4. BAKIM KAYITLARI TABLOSU
CREATE TABLE BakimKayitlari (
    BakimID INT PRIMARY KEY IDENTITY(1,1),
    AracNO NVARCHAR(50),
    BakimTuru NVARCHAR(50),
    Maliyet DECIMAL(18,2),
    Tarih DATETIME DEFAULT GETDATE(),
    TeknisyenTC CHAR(11),
    FOREIGN KEY (AracNO) REFERENCES Araclar(AracNO)
);

-- 5. MAAS ODEMELERI TABLOSU
CREATE TABLE MaasOdemeleri (
    OdemeID INT PRIMARY KEY IDENTITY(1,1),
    PersonelTC CHAR(11),
    AdSoyad NVARCHAR(100),
    OdenenAy NVARCHAR(2),
    OdenenYil NVARCHAR(4),
    OdenenTutar DECIMAL(18,2),
    OdemeTarihi DATETIME DEFAULT GETDATE(),
    Durum NVARCHAR(100), -- "Ödendi" bilgisi burada tutulur
    FOREIGN KEY (PersonelTC) REFERENCES Personeller(TC)
);