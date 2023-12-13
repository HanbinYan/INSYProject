namespace INSYProject
{
    public class Program
{
    private static Child child;
    private static List<EducationProgram> educationprogram;
    private static List<RecreationalMaterials> recreationalMaterials;

    private static child authenticatedChild;

    static void Main(string[] args)
    {
        Console.WriteLine("Initializing...");
        Initialize();
        Menu();
    }

    static void Initialize()
    {
        child = new child();
        educationprogram = new List<educationprogram>();
        recreationalMaterials = new List<RecreationalMaterials>();

        static void Initialize()
        {
            var c1 = new child
            {
                FirstName = "Hanbin",
                LastName = "Yan",
                Username = "Hanbin",
            };

            var c2 = new child
            {
                FirstName = "Yanjun",
                LastName = "He",
                Username = "Yanjun",
            };

            var c3 = new child
            {
                FirstName = "Jamie",
                LastName = "Goliday",
                Username = "Jamie",
            };

        var a1 = new RecreationalMaterials 
        { 
            ItemId = 1, 
            Name = "Item1",
            Availability = true, 
            OnSiteUseOnly = false
        };
        var a2 = new RecreationalMaterials 
        {
            ItemId = 2, 
            Name = "Item2", 
            Availability = true, 
            OnSiteUseOnly = true 
        };
        var a3 = new RecreationalMaterials 
        { 
            ItemId = 3, 
            Name = "Item3", 
            Availability = false,
            OnSiteUseOnly = false 
        };

        child.AddChild(c1);
        child.AddChild(c2);
        child.AddChild(c3);

        recreationalMaterials.Add(new RecreationalMaterials(c1, a1));
        recreationalMaterials.Add(new RecreationalMaterials(c1, a2));
        recreationalMaterials.Add(new RecreationalMaterials(c2, a3));
    }

    static void Menu()
    {
        bool done = false;

        while (!done)
        {
            Console.WriteLine("Options: Login: 1 --- Logout: 2 --- Sign Up: 3 --- Recreational Materials: 4 --- Clear Screen: c --- Quit: q ---");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    LoginMenu();
                    break;
                case "2":
                    LogoutMenu();
                    break;
                case "3":
                    SignUpMenu();
                    break;
                case "4":
                    GetRecreationalMaterialsMenu();
                    break;
                case "c":
                    Console.Clear();
                    break;
                case "q":
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }

    static void LoginMenu()
    {
        if (authenticatedChild == null)
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            authenticatedChild = child.Authenticate(username, password);
            if (authenticatedChild != null)
            {
                Console.WriteLine($"Welcome {authenticatedChild.FirstName}");
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }
        }
        else
        {
            Console.WriteLine($"You are already logged in as {authenticatedChild.Username}");
        }
    }

    static void LogoutMenu()
    {
        authenticatedChild = null;
        Console.WriteLine("Logged out!");
    }

    static void SignUpMenu()
    {
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        var newCustomer = new Child(firstName, lastName, username, password);
        child.AddChild(newChild);

        Console.WriteLine("Profile created!");
    }

    static void GetRecreationalMaterialsMenu()
    {
        if (authenticatedChild == null)
        {
            Console.WriteLine("You are not logged in.");
            return;
        }

        var itemsList = recreationalMaterials.Where(ci => ci.Child.Username == authenticatedChild.Username);

        if (itemsList.Count() == 0)
        {
            Console.WriteLine("No items found for the child.");
        }
        else
        {
            Console.WriteLine("Recreational Materials for the child:");
            foreach (var item in itemsList)
            {
                Console.WriteLine($"Item ID: {item.RecreationalMaterials.ItemId}, Name: {item.RecreationalMaterials.Name}");
            }
        }
    }
}

public class Customers
{
    public List<Child> customerList;

    public Child()
    {
        childList = new List<Child>();
    }

    public void AddChild(Child child)
    {
        childList.Add(child);
    }

    public Child Authenticate(string username, string password)
    {
        return childList.FirstOrDefault(c => c.Username == username && c.Password == password);
    }
}

public class Child
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public Child(string firstName, string lastName, string username, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Username = username;
        Password = password;
    }
}

public class RecreationalMaterials
{
    public int ItemId { get; set; }
    public string Name { get; set; }
    public bool Availability { get; set; }
    public bool OnSiteUseOnly { get; set; }
}

public class EducationProgram
{
    public Child child { get; set; }
    public RecreationalMaterials RecreationalMaterials { get; set; }

    public ChildItemId(Child customer, RecreationalMaterials recreationalMaterials)
    {
        Child = child;
        RecreationalMaterials = recreationalMaterials;
    }
}
}
