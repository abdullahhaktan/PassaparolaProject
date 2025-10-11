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

Bu proje, popüler **Passaparola bilgi yarışması** formatını temel alarak geliştirilmiş bir masaüstü veya web uygulamasıdır. Kullanıcıların belirli bir süre içinde alfabedeki harflere karşılık gelen soruları yanıtlamasını amaçlar. Proje, temel programlama mantığı ve kullanıcı etkileşimi becerilerini sergilemektedir.

---

## ✨ Temel Özellikler

### Teknik Özellikler

* **C# Programlama Dili**: Uygulamanın ana geliştirme dili.
* **Kullanıcı Arayüzü**: Genellikle **Windows Forms** veya benzeri bir arayüz.
* **Veri Yönetimi**: Sorular, bir veritabanı (LocalDB, Access vb.) veya harici bir dosya (XML, JSON) ile yönetilir. **Migrations (Göçler)** kullanılmamaktadır.
* **Zaman Kontrolü**: Soruları yanıtlamak için geri sayım sayacı (Timer) mekanizması.
* **Basit Oyun Mantığı**: Harflere göre soru atama, doğru/yanlış cevaba göre puanlama.

### Kullanıcı / Oyun Özellikleri

* **Harf Sistemi**: Alfabedeki harflere karşılık gelen sorular.
* **Puanlama**: Doğru cevaplar için puan, yanlış cevaplar veya pas geçme için ceza/puansız geçiş.
* **Oyun Döngüsü**: Tüm harfler bitene kadar veya süre dolana kadar devam eden oyun akışı.
* **Sonuç Ekranı**: Oyun sonunda doğru, yanlış ve pas geçilen soruların sayısını gösterme.

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

[EN]

# PassaparolaProject

## 💻 About the Project

This project is a desktop or web application developed based on the popular **Passaparola quiz show** format. It aims to challenge users to answer questions corresponding to letters of the alphabet within a specific time limit. The project demonstrates fundamental skills in programming logic and user interaction.

---

## ✨ Core Features

### Technical Features

* **C# Programming Language**: The main development language.
* **User Interface**: Typically **Windows Forms** or a similar interface.
* **Data Management**: Questions are managed via a database (LocalDB, Access, etc.) or an external file (XML, JSON). **Migrations** are not used.
* **Time Control**: A countdown timer mechanism to answer questions.
* **Basic Game Logic**: Question assignment based on letters, scoring based on correct/incorrect answers.

### User / Game Features

* **Letter System**: Questions corresponding to the letters of the alphabet.
* **Scoring**: Points for correct answers, penalties/passing with no score for incorrect or skipped answers.
* **Game Flow**: The game continues until all letters are covered or the time runs out.
* **Result Screen**: Displays the final count of correct, incorrect, and skipped questions.

---

### 🚀 How to Run

Follow these steps to set up and run the project locally:

1.  **Prerequisites:**
    * **.NET Framework** (If a Windows Forms project) or **.NET SDK** (If an ASP.NET Core project).
    * **[Visual Studio 2019/2022](https://visualstudio.microsoft.com/)** (Recommended).
    * **SQL LocalDB / Access** (If used as a data source).

2.  **Cloning the Project:**
    ```bash
    git clone [https://github.com/abdullahhaktan/PassaparolaProject.git](https://github.com/abdullahhaktan/PassaparolaProject.git)
    cd PassaparolaProject
    ```

3.  **Installing Dependencies:**
    * Open the project in Visual Studio.
    * Ensure all NuGet packages in the solution are restored (**Restore**).

4.  **Creating the Data Source (REQUIRED MANUAL STEP):**
    * Since **Migrations** are not used, if the application uses a database, it must be created manually (by running an SQL script or placing the database file).
    * Check and update the data source connection string in the project's **settings file** (`App.config` or `appsettings.json`).

5.  **Running the Project:**
    * Run the project in Visual Studio (**F5**).
    * The application will start automatically.
