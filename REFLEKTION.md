# Reflektion

**Namn: Oliver
**Kurs: Grundläggande OOP
**Uppgift: Drömmatchen
**Datum: 2026-09-17

---

> Den här reflektionen är obligatorisk och lämnas in individuellt — även om uppgiften gjordes i grupp.  
> Det finns inga rätta eller fel svar. Skriv vad du faktiskt tyckte och upplevde.

---

## Vad var svårast att lösa?
Jag fastande faktiskt mest på properties delen. Mest för att jag försökte klura ut hur auto properties faktiskt fungerade. När det väl satte sig så flöt det på ganska lätt. Hur jag kom vidare var egentligen bara att jag förstod att skriva ut det helt var detsamma som att skriva public string x {get; private set}.

> 

---

## Hur fungerade samarbetet i gruppen?

*Vad fungerade bra? Vad var svårt? Hur delade ni upp arbetet?*  
*(Individuell uppgift? Hoppa över den här.)*

> 

---

## Om du fick göra om det — vad hade du gjort annorlunda?


Ifall jag hade gjort om allt så hade jag istället använt auto-properties till och börja med. För jag börja med att fylla båda klasserna såhär först:
private string bortalag;

public string Bortalag;
{
  get 
  {
    return bortalag;
  }
  private set 
  {
    bortalag = value;
  }
}
Detta är egentligen detsamma som public string Bortalag {get; private set} men bara mycket smidare och snyggare