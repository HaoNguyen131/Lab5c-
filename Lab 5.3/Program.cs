using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UserAccountLab
{
    public string name;
    public int rank;
    public float winRate;
    public string type;
    public int skin;

    public UserAccountLab(string name, int rank, float winRate, string type, int skin)
    {
        this.name = name;
        this.rank = rank;
        this.winRate = winRate;
        this.type = type;
        this.skin = skin;
    }
}

public class Program
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo list UserAccount
        List<UserAccountLab> userAccounts = new List<UserAccountLab>()
        {
            new UserAccountLab("Sơn Tùng", 10, 55.5f, "Ca Nhạc", 50),
            new UserAccountLab("Den Vâu", 5, 70, "Ca Nhạc", 10),
            new UserAccountLab("Thùy Linh", 15, 45.5f, "Ca Nhạc", 25),
            new UserAccountLab("Độ Mixi", 1, 98, "ALL", 2),
            new UserAccountLab("bà Tuyết Diamond", 3, 60.5f, "Ẩm thực", 10),
            new UserAccountLab("PewPew", 4, 55.5f, "live", 50),
            new UserAccountLab("Liên Minh", 2, 85.5f, "Game", 255),
            new UserAccountLab("Liên Quân", 11, 55.5f, "Game", 200),
            new UserAccountLab("Fifa 4", 7, 55.5f, "Game", 150),
            new UserAccountLab("C50", 8, 55.4f, "Game", 1000),
            new UserAccountLab("CSGO", 6, 85.5f, "Game", 500)
        };

        // Sử dụng ToLookup() để nhóm các UserAccount theo type
        var groupedUserAccounts = userAccounts.ToLookup(x => x.type);

        // Xuất thông tin ra màn hình console
        foreach (var group in groupedUserAccounts)
        {
            Console.WriteLine($"Type: {group.Key}");
            foreach (var userAccount in group)
            {
                Console.WriteLine($"\tTên: {userAccount.name}, Rank: {userAccount.rank}, WinRate: {userAccount.winRate}, Skin: {userAccount.skin}");
            }
            Console.WriteLine($"Số lượng UserAccount: {group.Count()}");
            Console.WriteLine();
        }
    }
}