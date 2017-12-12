namespace BecomingDev.Models
{
    public class Patterns
    {
        //KISS - keep it simple stupid

        //DRY -  don't repeat yourself (antyspaghetii)

        //YAGNI - you aren't gonna need it

        //SOLID
        //S -> Single Responsibility Principle      (zasada pojedyńczej odpowiedzialnośc)
        //O -> Open / Close Principle                (
        //L -> Liskovs Subtitution Principle        (klasa i klasa dziedzicząca powinny móc być wykorzystane dalej bez obaw, że np jakieś metody nie zadziałają np. kwadrat i prostokąt i ustawienie boków, przy kwadracie ustawia od razu A i B na to samo a w prosto. tego nie chcemy. 2 przykład kaczka i kaczka na baterie które kwaczą)
        //I -> Interface Segragation Principle      (lekkie interface, skupiajace sie na pojedynczych funkcjonalnoscach) 
        //D -> Dependency Inversion Principle       (posiadajac moduły czy klasy niskiego rzędu - ważne by wszystko opierało się na abstrakcjach, by opierało się na interfacach, a nie na silnie typowanych klasach -> rozszerzeniem literki D jest Dependancy Injection)

        //Patterns

        //Inversion of Control -> Ico, Hollywood Principle
        //Strategy Pattern -> pisząc na intercach sami decydujemy co chcemy przekazać, nie jesteśmy uwiązani
        //Repository 
        //Proxy, Wrapper, Facade
        //Asapter
        //Comand handler / event handler

        //CQS -> Command & Query Separation (rozszerzone później do CQRS) "Asking questions should not changing answers" oddzielenie logiki biznesowej od zapytań do bazy (tylko do odczytu). Query powinno być idenpotetne (nie powodwać skutków ubocznych, tzn. wywołanie zapytania 100 razy zawsze ma dać ten sam wynik, nie wypłynąć na aplikację) w praktyce np oddzielić rejestracje od pobrania z DB

    }
}