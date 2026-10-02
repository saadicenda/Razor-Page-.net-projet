# TP Introduction à Razor Pages

## 📌 Description

Ce projet a été réalisé dans le cadre d'un travail pratique d'introduction à **ASP.NET Core Razor Pages**.

L'objectif est de découvrir le fonctionnement de Razor Pages, la séparation entre l'interface utilisateur et la logique métier avec le **Code-Behind**, ainsi que la gestion des requêtes **HTTP GET et POST**.

L'application contient une page d'accueil dynamique et un calculateur d'âge utilisant un formulaire.

---

## 🎯 Objectifs

* Découvrir **ASP.NET Core** et **Razor Pages**
* Comprendre la structure d'un projet .NET
* Utiliser les fichiers `.cshtml` et `.cshtml.cs`
* Manipuler les données côté serveur
* Utiliser les requêtes HTTP **GET** et **POST**
* Créer et traiter un formulaire
* Utiliser le **Model Binding**
* Utiliser **Bootstrap** pour améliorer l'interface
* Organiser une application web avec Razor Pages

---

## 🛠️ Technologies utilisées

* **C#**
* **ASP.NET Core 10**
* **Razor Pages**
* **.NET 10 SDK**
* **HTML5**
* **CSS3**
* **Bootstrap**
* **Visual Studio Code**

---

## 📂 Structure du projet

```text
TPIntroRazor/
│
├── Pages/
│   ├── Index.cshtml
│   ├── Index.cshtml.cs
│   ├── Calcul.cshtml
│   ├── Calcul.cshtml.cs
│   ├── Privacy.cshtml
│   ├── Privacy.cshtml.cs
│   │
│   └── Shared/
│       └── _Layout.cshtml
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
│
├── Program.cs
├── TPIntroRazor.csproj
└── README.md
```

---

## ⚙️ Fonctionnalités

### 🏠 Page d'accueil

La page d'accueil affiche dynamiquement :

* Un message de bienvenue
* La date et l'heure du serveur
* Une liste de modules d'apprentissage

Les données sont définies dans :

```text
Pages/Index.cshtml.cs
```

et affichées dans :

```text
Pages/Index.cshtml
```

---

### 🧮 Calculateur d'âge

Une page `/Calcul` permet à l'utilisateur de saisir :

* Son nom
* Son année de naissance

Après soumission du formulaire, l'application calcule approximativement l'âge de l'utilisateur.

Le traitement est effectué avec une requête **HTTP POST** dans :

```text
Pages/Calcul.cshtml.cs
```

Le formulaire est défini dans :

```text
Pages/Calcul.cshtml
```

---

## 🔄 Fonctionnement GET / POST

### HTTP GET

Lorsqu'une page est consultée, la méthode `OnGet()` est exécutée.

Exemple :

```csharp
public void OnGet()
{
    MessageAccueil = "Bienvenue dans mon application Razor Pages !";
}
```

### HTTP POST

Lorsqu'un formulaire est envoyé, la méthode `OnPost()` est exécutée.

Exemple :

```csharp
public void OnPost()
{
    int age = DateTime.Now.Year - AnneeNaissance;

    Message = $"Bonjour {Nom}, vous avez environ {age} ans cette année !";
}
```

---

## 🚀 Installation et exécution

### 1. Cloner le projet

```bash
git clone https://github.com/saadicenda/TP-Intro-Razor-Pages.git
```

### 2. Accéder au projet

```bash
cd TP-Intro-Razor-Pages
```

### 3. Vérifier la version de .NET

```bash
dotnet --version
```

Le projet utilise **.NET 10**.

### 4. Lancer l'application

```bash
dotnet watch
```

L'application sera accessible à une adresse similaire à :

```text
http://localhost:5109
```

### 5. Accéder au calculateur

```text
http://localhost:5109/Calcul
```

---

## 📚 Concepts étudiés

Ce TP permet de mettre en pratique plusieurs concepts :

* Razor Pages
* PageModel
* Code-Behind
* Razor Syntax
* Data Binding
* Model Binding
* HTTP GET
* HTTP POST
* Formulaires HTML
* `@foreach`
* `@if`
* Bootstrap
* Routage avec Razor Pages
* Structure d'une application ASP.NET Core

---

## 👩‍💻 Auteur

**Sinda Saadi**

Ingénieure — Data Science & IA

Tunisie 🇹🇳

---

## 📄 Licence

Projet réalisé dans un cadre académique.
<img width="1911" height="885" alt="Capture d&#39;écran 2026-10-02 111258" src="https://github.com/user-attachments/assets/fd42a101-10f9-460b-b1d8-2c0689ed1f2c" />

<img width="1919" height="947" alt="Capture d&#39;écran 2026-10-02 111504" src="https://github.com/user-attachments/assets/ac724132-bb36-40da-bd68-f462bcd33799" />
