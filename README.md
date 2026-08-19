# Linha de Frente: Instructional Digital Game for COVID-19 Prevention

[![Engine](https://img.shields.io/badge/Engine-Unity-black.svg?logo=unity)](https://unity.com/)
[![Platform](https://img.shields.io/badge/Platform-Android-green.svg?logo=android)](https://play.google.com/)
[![INPI Registration](https://img.shields.io/badge/INPI_Registration-BR512023001415--0-orange.svg)](https://www.gov.br/inpi/)
[![](https://img.shields.io/badge/Available%20on-Play%20Store-green)](https://play.google.com/store/apps/details?id=com.josericardo_jr.LinhaDeFrente)
[![Institution](https://img.shields.io/badge/Institution-IFRJ-red.svg)](https://portal.ifrj.edu.br/)

> **Linha de Frente** is a serious puzzle mobile game developed by researchers and students at the **Instituto Federal do Rio de Janeiro (IFRJ)**. Designed to bridge the gap between abstract health guidelines and procedural habits, the game models viral propagation dynamics and reinforces critical biosafety protocols through active problem-solving.

---

## Authors
This research is conducted by a student and a professor from the Instituto Federal do Rio de Janeiro, Brazil.
- **Stéphanie Gomes (student)**
- **Izack Costa (student)**
- **Juliana Silva (research professor and supervisor)**
- **Ana Carvalho (research professor and supervisor)**
- **Jose Ricardo da Silva Junior (research professor and supervisor)**

---

## 📌 Table of Contents
- [Project Overview & Research Motivation](#-project-overview--research-motivation)
- [Theoretical Foundation](#-theoretical-foundation)
- [Game Narrative & Core Concept](#-game-narrative--core-concept)
- [Gameplay & Scenario Breakdown](#-gameplay--scenario-breakdown)
- [Key Research Findings & Empirical Results](#-key-research-findings--empirical-results)
- [Technical Architecture](#-technical-architecture)
- [Getting Started & Installation](#-getting-started--installation)
- [Intellectual Property & Registration](#-intellectual-property--registration)
- [Citation](#-citation)
- [Acknowledgements](#-acknowledgements)

---

## 🔬 Project Overview & Research Motivation

During public health crises such as the COVID-19 pandemic, traditional mass media campaigns (TV, print, static posters) rely heavily on a **passive communication model**. Research in cognitive science demonstrates that passive correction often suffers from the *"continued influence effect"* and fails to overwrite ingrained heuristics or counter rapid misinformation.

**Linha de Frente** addresses this challenge by shifting the learner from a passive content consumer to an **active agent** within a simulated clinical and domestic ecosystem. Through dynamic feedback systems, players directly experience the cumulative consequences of their choices on viral contamination risk.

---

## 🧠 Theoretical Foundation

The game design leverages key pedagogical and psychological frameworks:
1. **Inoculation Theory & Prebunking:** Exposing learners to simulated micro-risks and behavioral trade-offs to build cognitive resistance against hazardous shortcuts and misinformation.
2. **Experiential Learning & Cycle of Expertise:** Replacing static memorization with interactive feedback loops (action → outcome → reflection → adaptation).
3. **Flow & Serious Gaming Mechanics:** Balancing cognitive challenge through third-person puzzle mini-games to maintain optimal engagement across diverse demographic groups.

---

## 🎮 Game Narrative & Core Concept

Players follow **João**, an 18-year-old nursing intern working in a hospital during the height of the COVID-19 pandemic. João lives with his vulnerable grandparents (**José, 75** and **Ana, 72**). 

* **The Core Objective:** Safely navigate the day's clinical duties and daily commute without contracting or spreading the virus.
* **The Contamination Meter (Contagious Gauge):** A dynamic feedback mechanic representing the player's cumulative risk. Non-compliant actions or procedural errors increase the contamination meter. Winning requires completing the shifts with minimal contamination points.

---

## 🧩 Gameplay & Scenario Breakdown

*Linha de Frente* is structured into **seven distinct problem-solving scenarios**, each targeting critical biosafety guidelines:

| Scenario | Setting | Biosafety Domain | Pedagogical Objective |
| :--- | :--- | :--- | :--- |
| **Scenario 1** | Clinical Diagnostic | SARS-CoV-2 Pathophysiology | Diagnostic quiz establishing biological rationale (pulmonary impact, droplet vectors). |
| **Scenario 2** | Pre-Shift Setup | PPE Facial Seal & Orientation | Active selection of proper mask placement to establish effective barrier defenses. |
| **Scenario 3** | Sanitization Station | Hand Hygiene Sequencing | Reconstructing the 4-phase ANVISA handwashing sequence to build procedural memory. |
| **Scenario 4** | Hospital Antechamber | PPE Donning Protocol | Arranging equipment donning order (*Gown &rarr; Mask &rarr; Eye Protection &rarr; Gloves*). |
| **Scenario 5** | Public Transport / Commute | Social Distancing & Visual Scanning | Active crowd scanning to identify non-compliant individuals and maintain safe zones. |
| **Scenario 6** | Doffing Station | Clean-to-Dirty Protocol | Safe PPE removal sequencing to prevent self-contamination during high-risk strip-down. |
| **Scenario 7** | Environmental Surface Care | Chemical Decontamination | Selecting effective sanitizers (e.g., 70% alcohol vs. detergents) and avoiding hazardous mixtures. |

---

## 📊 Key Research Findings & Empirical Results

The educational impact and usability of *Linha de Frente* were evaluated with **$N = 244$ participants** across healthcare and technical disciplines (Physiotherapy, Occupational Therapy, Pharmacy, and technicians):

* 📈 **Knowledge Acquisition:** **96.0% (215/224)** of participants reported acquiring new biosafety knowledge after gameplay.
* 💬 **User Recommendation:** **96.4% (216/224)** stated they would recommend the game as an instructional tool.
* 👥 **Broad Accessibility:** **58.9%** of evaluators reported not being regular digital gamers, confirming intuitive touch mechanics and accessibility.
* 🏥 **Misconception Demystification:** The evaluation exposed critical real-world gaps—such as **15.16%** initially misjudging supermarkets as higher-risk environments compared to hospitals—which were clarified through in-game spatial dynamics.

---

## 🛠 Technical Architecture

* **Engine:** Unity Engine (C#)
* **Target Platforms:** Android (Architecture extensible to iOS & WebGL)
* **Art & Audio:** 2D Vector & Isometric Assets with clear UI color-coding for high visual literacy
* **Telemetry & Tracking:** In-engine performance logging and score aggregation

---

## 🚀 Getting Started & Installation

### Prerequisites
* **Unity Hub** & **Unity 2021.3 LTS** (or newer LTS version)
* **Android Build Support** (with Android SDK & NDK tools installed)

### Building the Project
1. Clone this repository:
   ```bash
   git clone https://github.com/GSimCog/GameCovid.git
   ```
2. Open **Unity Hub**, click **Add**, and select the cloned directory.
3. Open the project and navigate to `File > Build Settings...`.
4. Switch the target platform to **Android**.
5. Ensure all scenes under `Assets/Scenes/` are included in the build list in indexed order.
6. Click **Build** to produce the `.apk` package or connect an Android device and select **Build and Run**.

---

## 📄 Intellectual Property & Registration

This software is officially registered with the **National Institute of Industrial Property (INPI)** in Brazil:
* **Registration Number:** `BR512023001415-0`

---

## 📖 Citation

If you use this game, codebase, or research methodology in academic publications, please cite the following paper:

```bibtex
@inproceedings{linha_de_frente_sbgames2026,
  author    = {St{'e}phanie Gomes and Izack Costa and Juliana Silva and Ana Carvalho and Jose Ricardo da Silva Junior},
  title     = {Instructional Digital Game for Prevention of COVID-19 Contagion},
  booktitle = {Anais do XXV Simp{'o}sio Brasileiro de Jogos e Entretenimento Digital (SBGames 2026)},
  year      = {2026},
  location  = {Goi{\^a}nia, GO, Brazil},
  track     = {Sa{'u}de},
  publisher = {SBC},
  note      = {Software Registration INPI: BR512023001415-0}
}
```

---

## 🤝 Acknowledgements

This research and development was conducted at the **Instituto Federal do Rio de Janeiro (IFRJ)**. We gratefully acknowledge financial and institutional support from:
* **CAPES** (Coordenação de Aperfeiçoamento de Pessoal de Nível Superior)
* **CNPq** (Conselho Nacional de Desenvolvimento Científico e Tecnológico)
* **FAPERJ** (Fundação Carlos Chagas Filho de Amparo à Pesquisa do Estado do Rio de Janeiro)
