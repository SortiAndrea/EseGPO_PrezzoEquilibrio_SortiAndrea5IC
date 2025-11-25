📊 Prezzo di Equilibrio – Simulatore Domanda/Offerta (C# WinForms)
In questo progetto ho sviluppato una Windows Form in C# che simula le curve di domanda e offerta e calcola il prezzo di equilibrio al variare dei parametri.
L’app permette di visualizzare graficamente le due curve e di osservare come cambiano modificando le impostazioni.

1. Funzioni economiche utilizzate
Domanda:
d=90−4q
Offerta:
o=10+100q3

I parametri (ordinata, coefficienti ed esponenti) possono essere modificati tramite controlli nella form.

------------------------------------------------------------------------------------------------------------------------------------------------------------

2. Calcolo dei valori
Per ogni quantità la form calcola automaticamente:
- il prezzo della curva di domanda
- il prezzo della curva di offerta

I dati vengono generati in tempo reale e usati per tracciare le curve.

------------------------------------------------------------------------------------------------------------------------------------------------------------

3. Grafico dinamico
Un grafico WinForms visualizza domanda e offerta.

L’intersezione delle curve rappresenta il punto di equilibrio, aggiornato ogni volta che cambiano i parametri.

------------------------------------------------------------------------------------------------------------------------------------------------------------

4. Obiettivo del progetto
Simulare il comportamento di domanda e offerta.
Mostrare come varia il prezzo di equilibrio.
Offrire uno strumento semplice e interattivo per comprendere le dinamiche di mercato.
