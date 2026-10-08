<div align="center">
  <h1>Library — Desktop App for Librarians</h1>
  <p><b>Система управления библиотекой на WPF (C#) с архитектурой MVVM</b></p>
  
  [![WPF](https://img.shields.io/badge/UI-WPF-68217A?logo=windows)](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/)
  [![C#](https://img.shields.io/badge/C%23-.NET%206-239120?logo=csharp)](https://learn.microsoft.com/en-us/dotnet/csharp/)
  [![Pattern](https://img.shields.io/badge/Architecture-MVVM-blueviolet)](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm)
</div>

---

## 📚 О проекте
**Library** — это десктопное приложение для автоматизации работы библиотекаря. Программа заменяет бумажные журналы и картотеки, позволяя в пару кликов выдавать книги. Приложение построено на **WPF** с соблюдением паттерна **MVVM**, что обеспечивает чистый код и легкую поддержку.

### ✨ Основной функционал
- 📖 **Каталог книг**: Добавление, редактирование и поиск литературы по автору, названию.
- 👥 **База читателей**: Регистрация посетителей, хранение данных и истории посещений.
- 🔄 **Выдача и возврат**: Быстрая фиксация выдачи книги конкретному читателю.
- 📋 **Журнал операций**: Полный лог всех выдач и возвратов с возможностью фильтрации по датам.

## 🏗️ Архитектура и технологии
Проект строго следует паттерну **Model-View-ViewModel (MVVM)**:

**Используемый стек:**
- **UI:** WPF, XAML, Styles & Templates
- **Backend:** C# (.NET 6/7/8), Entity Framework Core
- **Database:** SQLite / SQL Server (локальное хранилище)
- **Tools:** Visual Studio, NuGet Packages
