Slushatel slushatel1 = new();
slushatel1.IdSlush = 1;
slushatel1.Name = "Влад";
slushatel1.email = "Vladik@gmail.com";

Slushatel slushatel2 = new();
slushatel2.IdSlush = 2;
slushatel2.Name = "Анна";
slushatel2.email = "anna@gmail.com";



Group Group1 = new();
Group1.IdGroup = 102;
Group1.DataBegin = "01.03.2026";
Group1.DataEnd = "30.11.2026";
Group1.Kolichestvo = 28;

Group Group2 = new();
Group2.IdGroup = 101;
Group2.DataBegin = "01.09.2025";
Group2.DataEnd = "20.12.2025";
Group2.Kolichestvo = 21;

Console.WriteLine($" Код Слушателя: {slushatel1.IdSlush}; Имя: {slushatel1.Name}; Код Слушателя: {slushatel1.email} Номер группы: {Group1.IdGroup}");

Console.WriteLine($" Код Слушателя: {slushatel2.IdSlush}; Имя: {slushatel2.Name}; Код Слушателя: {slushatel2.email} Номер группы: {Group2.IdGroup}");


class Slushatel
{
    public string Name;
    public string email;
    public int IdSlush;
}

class Group
{
    public int IdGroup;
    public string DataBegin;
    public string DataEnd;
    public int Kolichestvo;
}