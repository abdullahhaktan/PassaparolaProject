# PassaparolaProject

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Design Pattern](https://img.shields.io/badge/Architecture-N--Tier%2FLayered-orange.svg)]()
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/PassaparolaProject)](https://github.com/abdullahhaktan/PassaparolaProject)
[![GitHub Yıldızları](https://img.shields.io/github/stars/abdullahhaktan/PassaparolaProject.svg?style=social)](https://github.com/abdullahhaktan/PassaparolaProject/stargazers)
[![Lisans](https://img.shields.io/badge/Lisans-MIT-blue.svg)](LICENSE)

[TR]

**Passaparola Bilgi Yarışması (C# / Windows Forms veya Web)**

---

## 💻 Proje Hakkında

Bu proje, popüler **Passaparola bilgi yarışması** formatını temel alarak geliştirilmiş bir uygulamadır. Kullanıcıların belirli bir süre içinde alfabedeki harflere karşılık gelen soruları yanıtlamasını amaçlar. Proje, temel **programlama mantığı**, **kullanıcı etkileşimi** ve **veri yönetimi** becerilerini sergilemektedir.

---

## ✨ Temel Özellikler

### Teknik Özellikler

* **C# Programlama Dili**: Uygulamanın ana geliştirme dili.
* **Kullanıcı Arayüzü**: Projenin türüne göre **Windows Forms** veya **ASP.NET Core/MVC** arayüzü.
* **Veri Yönetimi**: Soruların ve cevapların bir veritabanı (SQL Server, Access vb.) veya harici bir dosya (XML, JSON) ile yönetilmesi.
* **Zaman Kontrolü**: Soruları yanıtlamak için geri sayım sayacı (Timer) mekanizması.
* **Basit Oyun Mantığı**: Harflere göre soru atama, doğru/yanlış cevaba göre puanlama.

### Kullanıcı / Oyun Özellikleri

* **Harf Sistemi**: Alfabedeki 29 harfe karşılık gelen sorular.
* **Puanlama**: Doğru cevaplar için puan, yanlış cevaplar veya pas geçme için ceza/puansız geçiş.
* **Oyun Döngüsü**: Tüm harfler bitene kadar veya süre dolana kadar devam eden oyun akışı.
* **Sonuç Ekranı**: Oyun sonunda doğru, yanlış ve pas geçilen soruların sayısını gösterme.
* **Kullanıcı Etkileşimi**: Kullanıcıdan metin girişi ile cevap alma.

---

### 🚀 Nasıl Çalıştırılır?

Bu projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  **Gereksinimler:**
    * **.NET Framework** (Eğer Windows Forms projesiyse) veya **.NET SDK** (Eğer ASP.NET Core projesiyse).
    * **Visual Studio 2019/2022** (Önerilen)
    * Veritabanı (Eğer harici bir veritabanı kullanılıyorsa, örn: SQL Server LocalDB).

2.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/abdullahhaktan/PassaparolaProject.git](https://github.com/abdullahhaktan/PassaparolaProject.git)
    cd PassaparolaProject
    ```

3.  **Bağımlılıkları Yükleme:**
    * Visual Studio'da projeyi açın.
    * Çözümdeki tüm NuGet paketlerinin geri yüklendiğinden emin olun (**Restore**).

4.  **Veri Kaynağı Ayarları:**
    * Proje, harici bir veritabanı kullanıyorsa, bağlantı dizesini projenin ayarlar dosyasında (`App.config` veya `appsettings.json`) güncelleyin.

5.  **Projeyi Çalıştırma:**
    * Projeyi Visual Studio'da çalıştırın (F5).
    * Uygulama otomatik olarak başlayacaktır.

---
---

[EN]

# PassaparolaProject

## 💻 About the Project

This project is an application developed based on the popular **Passaparola quiz show** format. It aims to challenge users to answer questions corresponding to letters of the alphabet within a specific time limit. The project demonstrates fundamental skills in **programming logic**, **user interaction**, and **data management**.

---

## ✨ Core Features

### Technical Features

* **C# Programming Language**: The main development language for the application.
* **User Interface**: Either a **Windows Forms** or **ASP.NET Core/MVC** interface, depending on the project type.
* **Data Management**: Questions and answers are managed via a database (SQL Server, Access, etc.) or an external file (XML, JSON).
* **Time Control**: A countdown timer mechanism to answer questions.
* **Basic Game Logic**: Question assignment based on letters, scoring based on correct/incorrect answers.

### User / Game Features

* **Letter System**: Questions corresponding to the 29 letters of the alphabet.
* **Scoring**: Points for correct answers, penalties/passing with no score for incorrect or skipped answers.
* **Game Flow**: The game continues until all letters are covered or the time runs out.
* **Result Screen**: Displays the final count of correct, incorrect, and skipped questions.
* **User Interaction**: Accepts answers from the user via text input.

---

### 🚀 How to Run

Follow these steps to set up and run the project locally:

1.  **Prerequisites:**
    * **.NET Framework** (If a Windows Forms project) or **.NET SDK** (If an ASP.NET Core project).
    * **Visual Studio 2019/2022** (Recommended).
    * Database (If an external database is used, e.g., SQL Server LocalDB).

2.  **Cloning the Project:**
    ```bash
    git clone [https://github.com/abdullahhaktan/PassaparolaProject.git](https://github.com/abdullahhaktan/PassaparolaProject.git)
    cd PassaparolaProject
    ```

3.  **Installing Dependencies:**
    * Open the project in Visual Studio.
    * Ensure all NuGet packages in the solution are restored (**Restore**).

4.  **Data Source Configuration:**
    * If the project uses an external database, update the connection string in the project's settings file (`App.config` or `appsettings.json`).

5.  **Running the Project:**
    * Run the project in Visual Studio (F5).
    * The application will start automatically.
---
---

<img width="944" height="406" alt="Ekran görüntüsü 2025-10-04 115028" src="https://github.com/user-attachments/assets/8bc2a459-4982-4667-b2e1-3f2d514c0543" />
