# Cloud Task Manager (2026) by Yevhenii Duman 95069
 
Projekt natywnej aplikacji chmurowej realizowany w architekturze 3-warstwowej.
 
## Deklaracja Architektury (Mapowanie Azure)
Ten projekt został zaplanowany z myślą o usługach PaaS (Platform as a Service) w chmurze Azure.
 
| Warstwa | Komponent Lokalny | Usługa Azure |
| :--- | :--- | :--- |
| **Presentation** | React 19 (Vite) | Azure Static Web Apps |
| **Application** | API (.NET 9 / Node 24) | Azure App Service |
| **Data** | SQL Server (Dev) | Azure SQL Database (Serverless) |
 
## 🏗 Status Projektu i Dokumentacja
* [x] **Artefakt 1:** Zaplanowano strukturę folderów i diagram C4 (dostępny w `/docs`).
* [x] **Artefakt 2:** Konfiguracja środowiska Docker.
* [x] **Artefakt 3:** Programowanie front-endu (React, Vite i komunikacja z API)
* [x] **Artefakt 4:** Programowanie back-endu – REST API, baza danych i Docker
* [x] **Artefakt 5:** Trwałość danych i profesjonalny kontrakt API (EF Migrations + DTO + UI Form)
* [x] **Artefakt 6:** Aplikacja wdrożona w Azure
* [x] **Artefakt 7:** Zabezpieczona aplikacja
* [x] **Artefakt 8:** Dokumentacja techniczna API (Swager UI) dostępna publicznie.

## Adres aplikacji: cloud-task-manager-frontend-95069-edacceaffjdta5hb.polandcentral-01.azurewebsites.net
 
> **Informacja:** Ten plik będzie ewoluował. W kolejnych etapach dodamy tutaj sekcje 'Quick Start', opis zmiennych środowiskowych oraz instrukcję wdrożenia (CI/CD).