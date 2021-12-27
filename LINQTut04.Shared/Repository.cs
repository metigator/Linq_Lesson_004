
using System;
using System.Collections.Generic; 

namespace LINQTut04.Shared
{
    public static class Repository
    {

        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee> 
            {
            new Employee
                {
                        Id = 1001,
                        FirstName = "Cochran",
                        LastName = "Cole",
                        Email = "Cole.Cochran@example.com",
                        Skills = new() {"ASP.NET" , "CSS" , "Oracle"}
                },
                new Employee
                {
                        Id = 1002,
                        FirstName = "Jaclyn",
                        LastName = "Wolfe",
                        Email = "Wolfe.Jaclyn@example.com",
                        Skills = new() {"ASP.NET" , "SQL Server" , "Javascript" , "CSS" , "HTML"}
                },
                new Employee
                {
                        Id = 1003,
                        FirstName = "Warner",
                        LastName = "Jones",
                        Email = "Jones.Warner@example.com",
                        Skills = new() {"HTML" , "Oracle" , "SQL Server"}
                },
                new Employee
                {
                        Id = 1004,
                        FirstName = "Hester",
                        LastName = "Evans",
                        Email = "Evans.Hester@example.com",
                        Skills = new() {"ASP.NET"}
                },
                new Employee
                {
                        Id = 1005,
                        FirstName = "Wallace",
                        LastName = "Buck",
                        Email = "Buck.Wallace@example.com",
                        Skills = new() {"C++" , "ASP.NET" , "C#" , "NodeJS"}
                },
                new Employee
                {
                        Id = 1006,
                        FirstName = "Acevedo",
                        LastName = "Wall",
                        Email = "Wall.Acevedo@example.com",
                        Skills = new() {"C++" , "SQL Server" , "CSS" , "HTML"}
                },
                new Employee
                {
                        Id = 1007,
                        FirstName = "Jacqueline",
                        LastName = "Pickett",
                        Email = "Pickett.Jacqueline@example.com",
                        Skills = new() {"SQL Server" , "CSS" , "C++" , "Javascript" , "C#"}
                },
                new Employee
                {
                        Id = 1008,
                        FirstName = "Oconnor",
                        LastName = "Espinoza",
                        Email = "Espinoza.Oconnor@example.com",
                        Skills = new() {"NodeJS" , "Oracle"}
                },
                new Employee
                {
                        Id = 1009,
                        FirstName = "Allie",
                        LastName = "Elliott",
                        Email = "Elliott.Allie@example.com",
                        Skills = new() {"ASP.NET" , "C#"}
                },
                new Employee
                {
                        Id = 1010,
                        FirstName = "Elva",
                        LastName = "Decker",
                        Email = "Decker.Elva@example.com",
                        Skills = new() {"HTML" , "C#" , "SQL Server" , "Javascript"}
                },
                new Employee
                {
                        Id = 1011,
                        FirstName = "Hayes",
                        LastName = "Beasley",
                        Email = "Beasley.Hayes@example.com",
                        Skills = new() {"ASP.NET"}
                },
                new Employee
                {
                        Id = 1012,
                        FirstName = "Florine",
                        LastName = "Cervantes",
                        Email = "Cervantes.Florine@example.com",
                        Skills = new() {"C#" , "Oracle" , "Javascript"}
                },
                new Employee
                {
                        Id = 1013,
                        FirstName = "Bullock",
                        LastName = "Carney",
                        Email = "Carney.Bullock@example.com",
                        Skills = new() {"CSS" , "NodeJS" , "Javascript"}
                },
                new Employee
                {
                        Id = 1014,
                        FirstName = "Carroll",
                        LastName = "Cantu",
                        Email = "Cantu.Carroll@example.com",
                        Skills = new() {"C#" , "C++" , "PHP"}
                },
                new Employee
                {
                        Id = 1015,
                        FirstName = "Debra",
                        LastName = "Hogan",
                        Email = "Hogan.Debra@example.com",
                        Skills = new() {"C++" , "ASP.NET" , "NodeJS" , "Oracle"}
                },
                new Employee
                {
                        Id = 1016,
                        FirstName = "Winnie",
                        LastName = "Mccall",
                        Email = "Mccall.Winnie@example.com",
                        Skills = new() {"SQL Server" , "C++" , "NodeJS"}
                },
                new Employee
                {
                        Id = 1017,
                        FirstName = "Manuela",
                        LastName = "Berger",
                        Email = "Berger.Manuela@example.com",
                        Skills = new() {"HTML" , "C#"}
                },
                new Employee
                {
                        Id = 1018,
                        FirstName = "Lakeisha",
                        LastName = "Lowe",
                        Email = "Lowe.Lakeisha@example.com",
                        Skills = new() {"C++" , "CSS" , "ASP.NET" , "SQL Server"}
                },
                new Employee
                {
                        Id = 1019,
                        FirstName = "Stewart",
                        LastName = "Lott",
                        Email = "Lott.Stewart@example.com",
                        Skills = new() {"CSS", "HTML", "Javascript", "PHP"}
                },
                new Employee
                {
                        Id = 1020,
                        FirstName = "Stafford",
                        LastName = "Peck",
                        Email = "Peck.Stafford@example.com",
                        Skills = new() {"C++" , "CSS" , "ASP.NET"}
                },
                new Employee
                {
                        Id = 1021,
                        FirstName = "Barron",
                        LastName = "Bird",
                        Email = "Bird.Barron@example.com",
                        Skills = new() {"C++" , "HTML" , "ASP.NET" , "Javascript"}
                },
                new Employee
                {
                        Id = 1022,
                        FirstName = "Nona",
                        LastName = "Brooks",
                        Email = "Brooks.Nona@example.com",
                        Skills = new() {"CSS"}
                },
                new Employee
                {
                        Id = 1023,
                        FirstName = "Clara",
                        LastName = "Reeves",
                        Email = "Reeves.Clara@example.com",
                        Skills = new() {"Javascript" , "Oracle" , "ASP.NET" , "CSS"}
                },
                new Employee
                {
                        Id = 1024,
                        FirstName = "Karin",
                        LastName = "Blanchard",
                        Email = "Blanchard.Karin@example.com",
                        Skills = new() {"HTML"}
                },
                new Employee
                {
                        Id = 1025,
                        FirstName = "Burris",
                        LastName = "Morgan",
                        Email = "Morgan.Burris@example.com",
                        Skills = new() {"ASP.NET"}
                },
                new Employee
                {
                        Id = 1026,
                        FirstName = "Owen",
                        LastName = "Cortez",
                        Email = "Cortez.Owen@example.com",
                        Skills = new() {"HTML"}
                },
                new Employee
                {
                        Id = 1027,
                        FirstName = "Letha",
                        LastName = "Finch",
                        Email = "Finch.Letha@example.com",
                        Skills = new() {"SQL Server"}
                },
                new Employee
                {
                        Id = 1028,
                        FirstName = "Sondra",
                        LastName = "Rojas",
                        Email = "Rojas.Sondra@example.com",
                        Skills = new() {"HTML"}
                },
                new Employee
                {
                        Id = 1029,
                        FirstName = "Hoover",
                        LastName = "Cook",
                        Email = "Cook.Hoover@example.com",
                        Skills = new() {"NodeJS" , "CSS" , "C++" , "ASP.NET" , "SQL Server"}
                },
                new Employee
                {
                        Id = 1030,
                        FirstName = "Wanda",
                        LastName = "Bender",
                        Email = "Bender.Wanda@example.com",
                        Skills = new() {"HTML" , "CSS" , "ASP.NET"}
                },
                new Employee
                {
                        Id = 1031,
                        FirstName = "Sanford",
                        LastName = "Craig",
                        Email = "Craig.Sanford@example.com",
                        Skills = new() {"SQL Server" , "NodeJS" , "Javascript" , "ASP.NET" , "HTML"}
                },
                new Employee
                {
                        Id = 1032,
                        FirstName = "Christy",
                        LastName = "Middleton",
                        Email = "Middleton.Christy@example.com",
                        Skills = new() {"C++" , "SQL Server" , "HTML"}
                },
                new Employee
                {
                        Id = 1033,
                        FirstName = "Day",
                        LastName = "Brady",
                        Email = "Brady.Day@example.com",
                        Skills = new() {"ASP.NET"}
                },
                new Employee
                {
                        Id = 1034,
                        FirstName = "Powers",
                        LastName = "Beard",
                        Email = "Beard.Powers@example.com",
                        Skills = new() {"NodeJS" , "SQL Server" , "CSS"}
                },
                new Employee
                {
                        Id = 1035,
                        FirstName = "Arline",
                        LastName = "Pratt",
                        Email = "Pratt.Arline@example.com",
                        Skills = new() {"C++" , "NodeJS" , "Oracle" , "CSS"}
                },
                new Employee
                {
                        Id = 1036,
                        FirstName = "Sharpe",
                        LastName = "Cardenas",
                        Email = "Cardenas.Sharpe@example.com",
                        Skills = new() {"ASP.NET" , "Javascript" , "C#" , "HTML" , "Oracle"}
                },
                new Employee
                {
                        Id = 1037,
                        FirstName = "Madeleine",
                        LastName = "Stanton",
                        Email = "Stanton.Madeleine@example.com",
                        Skills = new() {"SQL Server" , "C#" , "ASP.NET"}
                },
                new Employee
                {
                        Id = 1038,
                        FirstName = "Spears",
                        LastName = "Noble",
                        Email = "Noble.Spears@example.com",
                        Skills = new() {"Javascript" , "C++" , "CSS" , "NodeJS"}
                },
                new Employee
                {
                        Id = 1039,
                        FirstName = "Gonzalez",
                        LastName = "Gilliam",
                        Email = "Gilliam.Gonzalez@example.com",
                        Skills = new() {"CSS"}
                },
                new Employee
                {
                        Id = 1040,
                        FirstName = "Abigail",
                        LastName = "Bradford",
                        Email = "Bradford.Abigail@example.com",
                        Skills = new() {"Oracle" , "C#" , "Javascript" , "C++" , "HTML"}
                },
                new Employee
                {
                        Id = 1041,
                        FirstName = "Ashlee",
                        LastName = "Farmer",
                        Email = "Farmer.Ashlee@example.com",
                        Skills = new() {"SQL Server" , "Oracle"}
                },
                new Employee
                {
                        Id = 1042,
                        FirstName = "Glover",
                        LastName = "Lloyd",
                        Email = "Lloyd.Glover@example.com",
                        Skills = new() {"Javascript"}
                },
                new Employee
                {
                        Id = 1043,
                        FirstName = "Cleo",
                        LastName = "Mays",
                        Email = "Mays.Cleo@example.com",
                        Skills = new() {"C++" , "HTML" , "C#" , "CSS"}
                },
                new Employee
                {
                        Id = 1044,
                        FirstName = "Patrice",
                        LastName = "House",
                        Email = "House.Patrice@example.com",
                        Skills = new() {"C#" , "CSS" , "NodeJS"}
                },
                new Employee
                {
                        Id = 1045,
                        FirstName = "Atkins",
                        LastName = "Shannon",
                        Email = "Shannon.Atkins@example.com",
                        Skills = new() {"C#" , "CSS"}
                },
                new Employee
                {
                        Id = 1046,
                        FirstName = "Luisa",
                        LastName = "Hopkins",
                        Email = "Hopkins.Luisa@example.com",
                        Skills = new() {"Javascript" , "SQL Server" , "CSS" , "NodeJS" , "C++"}
                },
                new Employee
                {
                        Id = 1047,
                        FirstName = "Kaufman",
                        LastName = "Gross",
                        Email = "Gross.Kaufman@example.com",
                        Skills = new() {"Oracle" , "ASP.NET" , "CSS" , "C#"}
                },
                new Employee
                {
                        Id = 1048,
                        FirstName = "William",
                        LastName = "Clay",
                        Email = "Clay.William@example.com",
                        Skills = new() {"CSS"}
                },
                new Employee
                {
                        Id = 1049,
                        FirstName = "Alison",
                        LastName = "Kirby",
                        Email = "Kirby.Alison@example.com",
                        Skills = new() {"CSS" , "C++" , "HTML" , "SQL Server" , "Javascript"}
                },
                new Employee
                {
                        Id = 1050,
                        FirstName = "Morrow",
                        LastName = "Lynch",
                        Email = "Lynch.Morrow@example.com",
                        Skills = new() {"HTML" , "ASP.NET" , "C#"}
                },
                new Employee
                {
                        Id = 1051,
                        FirstName = "Roach",
                        LastName = "Bright",
                        Email = "Bright.Roach@example.com",
                        Skills = new() {"NodeJS"}
                },
                new Employee
                {
                        Id = 1052,
                        FirstName = "Carolyn",
                        LastName = "Justice",
                        Email = "Justice.Carolyn@example.com",
                        Skills = new() {"CSS" , "HTML" , "NodeJS" , "C++"}
                },
                new Employee
                {
                        Id = 1053,
                        FirstName = "Cathryn",
                        LastName = "Mathews",
                        Email = "Mathews.Cathryn@example.com",
                        Skills = new() {"Javascript" , "Oracle" , "ASP.NET" , "C#"}
                },
                new Employee
                {
                        Id = 1054,
                        FirstName = "Lindsay",
                        LastName = "Pruitt",
                        Email = "Pruitt.Lindsay@example.com",
                        Skills = new() {"Javascript" , "Oracle" , "C++" , "CSS" , "C#"}
                },
                new Employee
                {
                        Id = 1055,
                        FirstName = "Cummings",
                        LastName = "Webster",
                        Email = "Webster.Cummings@example.com",
                        Skills = new() {"C++" , "C#"}
                },
                new Employee
                {
                        Id = 1056,
                        FirstName = "Cannon",
                        LastName = "Pace",
                        Email = "Pace.Cannon@example.com",
                        Skills = new() {"HTML" , "NodeJS" , "Oracle" , "C++" , "C#"}
                },
                new Employee
                {
                        Id = 1057,
                        FirstName = "Barber",
                        LastName = "Singleton",
                        Email = "Singleton.Barber@example.com",
                        Skills = new() {"HTML" , "C++" , "CSS" , "C#" , "SQL Server"}
                },
                new Employee
                {
                        Id = 1058,
                        FirstName = "Aileen",
                        LastName = "Sweet",
                        Email = "Sweet.Aileen@example.com",
                        Skills = new() {"CSS"}
                },
                new Employee
                {
                        Id = 1059,
                        FirstName = "Lindsey",
                        LastName = "Hughes",
                        Email = "Hughes.Lindsey@example.com",
                        Skills = new() {"CSS" , "ASP.NET"}
                },
                new Employee
                {
                        Id = 1060,
                        FirstName = "Stout",
                        LastName = "Phillips",
                        Email = "Phillips.Stout@example.com",
                        Skills = new() {"ASP.NET"}
                },
                new Employee
                {
                        Id = 1061,
                        FirstName = "Benjamin",
                        LastName = "Stephens",
                        Email = "Stephens.Benjamin@example.com",
                        Skills = new() {"C++" , "CSS"}
                },
                new Employee
                {
                        Id = 1062,
                        FirstName = "Mandy",
                        LastName = "Odom",
                        Email = "Odom.Mandy@example.com",
                        Skills = new() {"NodeJS" , "SQL Server"}
                },
                new Employee
                {
                        Id = 1063,
                        FirstName = "Hays",
                        LastName = "Austin",
                        Email = "Austin.Hays@example.com",
                        Skills = new() {"SQL Server" , "Oracle" , "CSS"}
                },
                new Employee
                {
                        Id = 1064,
                        FirstName = "Jean",
                        LastName = "Salas",
                        Email = "Salas.Jean@example.com",
                        Skills = new() {"Javascript" , "C#" , "NodeJS"}
                },
                new Employee
                {
                        Id = 1065,
                        FirstName = "Luann",
                        LastName = "Hubbard",
                        Email = "Hubbard.Luann@example.com",
                        Skills = new() {"Javascript"}
                },
                new Employee
                {
                        Id = 1066,
                        FirstName = "Eaton",
                        LastName = "Lyons",
                        Email = "Lyons.Eaton@example.com",
                        Skills = new() {"NodeJS" , "Oracle" , "CSS" , "Javascript" , "C++"}
                },
                new Employee
                {
                        Id = 1067,
                        FirstName = "Beck",
                        LastName = "Ortiz",
                        Email = "Ortiz.Beck@example.com",
                        Skills = new() {"NodeJS" , "ASP.NET"}
                },
                new Employee
                {
                        Id = 1068,
                        FirstName = "Patty",
                        LastName = "Knight",
                        Email = "Knight.Patty@example.com",
                        Skills = new() {"NodeJS"}
                },
                new Employee
                {
                        Id = 1069,
                        FirstName = "Bowman",
                        LastName = "Hampton",
                        Email = "Hampton.Bowman@example.com",
                        Skills = new() {"CSS" , "HTML" , "Javascript" , "SQL Server"}
                },
                new Employee
                {
                        Id = 1070,
                        FirstName = "Pace",
                        LastName = "Bryant",
                        Email = "Bryant.Pace@example.com",
                        Skills = new() {"ASP.NET"}
                },
                new Employee
                {
                        Id = 1071,
                        FirstName = "Watts",
                        LastName = "Green",
                        Email = "Green.Watts@example.com",
                        Skills = new() {"C#" , "ASP.NET" , "NodeJS"}
                },
                new Employee
                {
                        Id = 1072,
                        FirstName = "Sonia",
                        LastName = "Clarke",
                        Email = "Clarke.Sonia@example.com",
                        Skills = new() {"ASP.NET" , "NodeJS" , "HTML" , "C#" , "Oracle"}
                },
                new Employee
                {
                        Id = 1073,
                        FirstName = "Donovan",
                        LastName = "Brennan",
                        Email = "Brennan.Donovan@example.com",
                        Skills = new() {"Javascript" , "C++"}
                },
                new Employee
                {
                        Id = 1074,
                        FirstName = "Rutledge",
                        LastName = "Harris",
                        Email = "Harris.Rutledge@example.com",
                        Skills = new() {"ASP.NET" , "NodeJS" , "HTML"}
                },
                new Employee
                {
                        Id = 1075,
                        FirstName = "Buckley",
                        LastName = "Meyers",
                        Email = "Meyers.Buckley@example.com",
                        Skills = new() {"NodeJS" , "CSS"}
                },
                new Employee
                {
                        Id = 1076,
                        FirstName = "Reynolds",
                        LastName = "Hammond",
                        Email = "Hammond.Reynolds@example.com",
                        Skills = new() {"HTML" , "SQL Server" , "Javascript" , "C#"}
                },
                new Employee
                {
                        Id = 1077,
                        FirstName = "Butler",
                        LastName = "Bowen",
                        Email = "Bowen.Butler@example.com",
                        Skills = new() {"Javascript" , "Oracle"}
                },
                new Employee
                {
                        Id = 1078,
                        FirstName = "Karina",
                        LastName = "Miles",
                        Email = "Miles.Karina@example.com",
                        Skills = new() {"ASP.NET"}
                },
                new Employee
                {
                        Id = 1079,
                        FirstName = "Fulton",
                        LastName = "Conner",
                        Email = "Conner.Fulton@example.com",
                        Skills = new() {"C++" , "ASP.NET" , "Oracle"}
                },
                new Employee
                {
                        Id = 1080,
                        FirstName = "Jewell",
                        LastName = "Tran",
                        Email = "Tran.Jewell@example.com",
                        Skills = new() {"C++" , "ASP.NET" , "CSS" , "NodeJS"}
                },
                new Employee
                {
                        Id = 1081,
                        FirstName = "Avis",
                        LastName = "Herrera",
                        Email = "Herrera.Avis@example.com",
                        Skills = new() {"Javascript" , "C#" , "Oracle" , "CSS"}
                },
                new Employee
                {
                        Id = 1082,
                        FirstName = "Nora",
                        LastName = "Dale",
                        Email = "Dale.Nora@example.com",
                        Skills = new() {"Oracle"}
                },
                new Employee
                {
                        Id = 1083,
                        FirstName = "Hillary",
                        LastName = "Duran",
                        Email = "Duran.Hillary@example.com",
                        Skills = new() {"Oracle"}
                },
                new Employee
                {
                        Id = 1084,
                        FirstName = "Hamilton",
                        LastName = "Macias",
                        Email = "Macias.Hamilton@example.com",
                        Skills = new() {"Javascript" , "NodeJS" , "C++" , "ASP.NET"}
                },
                new Employee
                {
                        Id = 1085,
                        FirstName = "Kent",
                        LastName = "Parsons",
                        Email = "Parsons.Kent@example.com",
                        Skills = new() {"NodeJS" , "C#" , "HTML"}
                },
                new Employee
                {
                        Id = 1086,
                        FirstName = "Dunn",
                        LastName = "Oliver",
                        Email = "Oliver.Dunn@example.com",
                        Skills = new() {"ASP.NET" , "SQL Server" , "Oracle" , "HTML"}
                },
                new Employee
                {
                        Id = 1087,
                        FirstName = "Betsy",
                        LastName = "Dean",
                        Email = "Dean.Betsy@example.com",
                        Skills = new() {"C++" , "C#"}
                },
                new Employee
                {
                        Id = 1088,
                        FirstName = "Kay",
                        LastName = "May",
                        Email = "May.Kay@example.com",
                        Skills = new() {"C#" , "ASP.NET"}
                },
                new Employee
                {
                        Id = 1089,
                        FirstName = "Farley",
                        LastName = "Bartlett",
                        Email = "Bartlett.Farley@example.com",
                        Skills = new() {"Javascript" , "ASP.NET" , "SQL Server" , "C++" , "CSS"}
                },
                new Employee
                {
                        Id = 1090,
                        FirstName = "Agnes",
                        LastName = "Riggs",
                        Email = "Riggs.Agnes@example.com",
                        Skills = new() {"CSS" , "SQL Server"}
                },
                new Employee
                {
                        Id = 1091,
                        FirstName = "White",
                        LastName = "Figueroa",
                        Email = "Figueroa.White@example.com",
                        Skills = new() {"NodeJS"}
                },
                new Employee
                {
                        Id = 1092,
                        FirstName = "Estes",
                        LastName = "Stone",
                        Email = "Stone.Estes@example.com",
                        Skills = new() {"ASP.NET" , "CSS"}
                },
                new Employee
                {
                        Id = 1093,
                        FirstName = "Julia",
                        LastName = "Contreras",
                        Email = "Contreras.Julia@example.com",
                        Skills = new() {"Oracle"}
                },
                new Employee
                {
                        Id = 1094,
                        FirstName = "Cecilia",
                        LastName = "Cooper",
                        Email = "Cooper.Cecilia@example.com",
                        Skills = new() {"CSS", "SQL Server" , "Oracle" , "NodeJS" , "Javascript"}
                },
                new Employee
                {
                        Id = 1095,
                        FirstName = "Zelma",
                        LastName = "Frank",
                        Email = "Frank.Zelma@example.com",
                        Skills = new() {"NodeJS" , "HTML" , "Oracle"}
                },
                new Employee
                {
                        Id = 1096,
                        FirstName = "Peters",
                        LastName = "Morales",
                        Email = "Morales.Peters@example.com",
                        Skills = new() {"SQL Server" , "Oracle" , "C++" , "NodeJS" , "HTML"}
                },
                new Employee
                {
                        Id = 1097,
                        FirstName = "Leigh",
                        LastName = "Moss",
                        Email = "Moss.Leigh@example.com",
                        Skills = new() {"C#" , "Oracle" , "NodeJS" , "ASP.NET"}
                },
                new Employee
                {
                        Id = 1098,
                        FirstName = "Megan",
                        LastName = "Bailey",
                        Email = "Bailey.Megan@example.com",
                        Skills = new() {"C#" , "CSS" , "NodeJS"}
                },
                new Employee
                {
                        Id = 1099,
                        FirstName = "Juliana",
                        LastName = "Pope",
                        Email = "Pope.Juliana@example.com",
                        Skills = new() {"NodeJS" , "Javascript" , "HTML" , "C++" , "CSS"}
                },
                new Employee
                {
                        Id = 1100,
                        FirstName = "Cervantes",
                        LastName = "Wong",
                        Email = "Wong.Cervantes@example.com",
                        Skills = new() {"NodeJS" , "CSS"}
                }
            };
        } 
    }
}
