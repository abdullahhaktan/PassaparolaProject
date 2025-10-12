# PassaparolaProject

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Design Pattern](https://img.shields.io/badge/Architecture-N--Tier%2FLayered-orange.svg)]()
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/PassaparolaProject)](https://github.com/abdullahhaktan/PassaparolaProject)
[![GitHub Yıldızları](https://img.shields.io/github/stars/abdullahhaktan/PassaparolaProject.svg?style=social)](https://github.com/abdullahhaktan/PassaparolaProject/stargazers)
[![Lisans](https://img.shields.io/badge/Lisans-MIT-blue.svg)](LICENSE)

[TR]

**Passaparola Bilgi Yarışması (C# / Windows Forms veya Benzeri)**

---

## 💻 Proje Hakkında

Bu proje, popüler **Passaparola bilgi yarışması** formatını temel alarak geliştirilmiş bir masaüstü uygulamasıdır. Kullanıcıların girdiği cevapların doğru olup olmadığına göre kontrol yapılır.

---

## ✨ Temel Özellikler

### Teknik Özellikler

* **Platform:** Windows Forms (Masaüstü Uygulaması)
* **Dil:** C#
* **Mantık:** Cevap kontrolü ve skor takibi, bir `switch-case` yapısı kullanılarak uygulanmıştır.
* **Girdi Kontrolü:** Cevaplar, **Enter tuşu** basıldığında kontrol edilir.
* **Durum Görselleştirme:** Cevap doğruysa ilgili harf düğmesi **Yeşil**, yanlışsa **Kırmızı** renge döner. Mevcut soruya ait harf düğmesi ise **Sarı** renkle vurgulanır.

### Kullanıcı / Oyun Özellikleri

* **Soru Döngüsü:** Kullanıcı "Sonraki" düğmesine tıkladıkça sorular sırayla yüklenir.
* **Anlık Skor:** Doğru ve Yanlış cevap sayıları anlık olarak görüntülenir.
* **Cevap Kontrolü:** Cevaplar büyük/küçük harf duyarlılığı olmadan (`.ToLower()`) kontrol edilir ve bazı sorular için alternatif cevaplar kabul edilir (Örn: "akdeniz" veya "akdeniz bölgesi").


---

### 🚀 Nasıl Çalıştırılır?

Bu projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  **Gereksinimler:**
    * **.NET Framework** (Eğer Windows Forms projesiyse) veya **.NET SDK** (Eğer ASP.NET Core projesiyse).
    * **[Visual Studio 2019/2022](https://visualstudio.microsoft.com/)** (Önerilen)
    * **SQL LocalDB / Access** (Eğer veri kaynağı olarak kullanılıyorsa).

2.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/abdullahhaktan/PassaparolaProject.git](https://github.com/abdullahhaktan/PassaparolaProject.git)
    cd PassaparolaProject
    ```

3.  **Bağımlılıkları Yükleme:**
    * Visual Studio'da projeyi açın.
    * Çözümdeki tüm NuGet paketlerinin geri yüklendiğinden emin olun (**Restore**).

4.  **Veri Kaynağı Oluşturma (ZORUNLU MANUEL ADIM):**
    * **Migrations** kullanılmadığı için, uygulama bir veritabanı kullanıyorsa, bu veritabanının manuel olarak oluşturulması (SQL scripti çalıştırma veya veritabanı dosyasını yerleştirme) gereklidir.
    * Projenin **ayarlar dosyasını** (`App.config` veya `appsettings.json`) açarak veri kaynağı bağlantı dizesini kontrol edin ve güncelleyin.

5.  **Projeyi Çalıştırma:**
    * Projeyi Visual Studio'da çalıştırın (**F5**).
    * Uygulama otomatik olarak başlayacaktır.

---
---

# 🎲 Passaparola Quiz Game (C# / Windows Forms or Similar)

---

## 💻 About the Project

This project is a desktop application developed based on the popular **Passaparola quiz show** format. It checks the correctness of the answers entered by the users.

---

## ✨ Key Features

### Technical Specifications

* **Platform:** Windows Forms (Desktop Application)
* **Language:** C#
* **Logic:** Answer checking and score tracking are implemented using a `switch-case` structure.
* **Input Control:** Answers are checked when the **Enter key** is pressed.
* **Status Visualization:** If the answer is correct, the corresponding letter button turns **Green**; if incorrect, it turns **Red**. The button for the current question is highlighted in **Yellow**.

### User / Game Features

* **Question Cycle:** Questions are loaded sequentially as the user clicks the "Next" button.
* **Instant Score:** The number of correct and incorrect answers is displayed instantly.
* **Answer Validation:** Answers are checked without case sensitivity (`.ToLower()`), and alternative answers are accepted for some questions (e.g., "akdeniz" or "akdeniz bölgesi").

---

### 🚀 How to Run?

Follow the steps below to run this project in your local environment:

1.  **Requirements:**
    * **.NET Framework** (If it's a Windows Forms project) or **.NET SDK** (If it's an ASP.NET Core project).
    * **[Visual Studio 2019/2022](https://visualstudio.microsoft.com/)** (Recommended)
    * **SQL LocalDB / Access** (If used as a data source).

2.  **Clone the Project:**
    ```bash
    git clone [https://github.com/abdullahhaktan/PassaparolaProject.git](https://github.com/abdullahhaktan/PassaparolaProject.git)
    cd PassaparolaProject
    ```

3.  **Install Dependencies:**
    * Open the project in Visual Studio.
    * Ensure all NuGet packages in the solution are restored (**Restore**).

4.  **Create Data Source (MANDATORY MANUAL STEP):**
    * Since **Migrations** are not used, if the application uses a database, it is necessary to create this database manually (by running an SQL script or placing the database file).
    * Open the project's **configuration file** (`App.config` or `appsettings.json`), check the data source connection string, and update it.

5.  **Run the Project:**
    * Run the project in Visual Studio (**F5**).
    * The application will start automatically.

---


<img width="956" height="395" alt="Ekran görüntüsü 2025-10-11 170130" src="https://github.com/user-attachments/assets/ed6a30da-e847-4c3a-9025-4707b75d4d5a" />
