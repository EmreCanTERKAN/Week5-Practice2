List<string> davetliler = new();
davetliler.Add("Polat Alemdar");
davetliler.Add("Süleyman Çakır");
davetliler.Add("Laz Ziya");
davetliler.Add("Testere Necmi");
davetliler.Add("Karahanlı");
davetliler.Add("İplikçi nedim");
davetliler.Add("Memati Baş");



Console.WriteLine("**Davetliler**");
for (int i = 0; i < davetliler.Count; i++)
{
    Console.WriteLine($"{i+1} - {davetliler[i]}");
}