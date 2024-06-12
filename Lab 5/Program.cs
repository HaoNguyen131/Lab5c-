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
            new UserAccountLab("C50", 8, 55.5f, "Game", 1000),
            new UserAccountLab("CSGO", 6, 85.5f, "Game", 500)
        };

        // Xuất dữ liệu ra màn hình
        Console.WriteLine("Danh sách UserAccount:");
        foreach (var userAccount in userAccounts)
        {
            Console.WriteLine($"Tên: {userAccount.name}, Rank: {userAccount.rank}, WinRate: {userAccount.winRate}, Type: {userAccount.type}, Skin: {userAccount.skin}");
        }

        // Sắp xếp danh sách theo Rank giảm dần
        var sortedByUserRank = userAccounts.OrderByDescending(x => x.rank).ToList();
        Console.WriteLine("\nDanh sách UserAccount sau khi sắp xếp theo Rank giảm dần:");
        foreach (var userAccount in sortedByUserRank)
        {
            Console.WriteLine($"Tên: {userAccount.name}, Rank: {userAccount.rank}, WinRate: {userAccount.winRate}, Type: {userAccount.type}, Skin: {userAccount.skin}");
        }

        // Sắp xếp danh sách theo Name giảm dần, sau đó theo Skin giảm dần
        var sortedByNameAndSkin = userAccounts.OrderByDescending(x => x.name).ThenByDescending(x => x.skin).ToList();
        Console.WriteLine("\nDanh sách UserAccount sau khi sắp xếp theo Name giảm dần, sau đó theo Skin giảm dần:");
        foreach (var userAccount in sortedByNameAndSkin)
        {
            Console.WriteLine($"Tên: {userAccount.name}, Rank: {userAccount.rank}, WinRate: {userAccount.winRate}, Type: {userAccount.type}, Skin: {userAccount.skin}");
        }

        // Liệt kê danh sách các người có Name bắt đầu bằng ký tự "B"
        var usersWithBName = userAccounts.Where(x => x.name.StartsWith("B")).ToList();
        Console.WriteLine("\nDanh sách các người có Name bắt đầu bằng ký tự \"B\":");
        foreach (var userAccount in usersWithBName)
        {
            Console.WriteLine($"Tên: {userAccount.name}, Rank: {userAccount.rank}, WinRate: {userAccount.winRate}, Type: {userAccount.type}, Skin: {userAccount.skin}");
        }
    }
}