using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DeadlyHeal           = 17;
            int MeleeDefense         = 5;
            int MeleeDefense1        = 8;
            int MeleeDefense2        = 7;
            int MeleeDefense3        = 19;
            int MeleeDefense6        = 14;
            int RangedDefense1       = 8;
            int RangeDefense2        = 8;

            Console.WriteLine("  ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ");   
            Console.WriteLine("  ┃                                                        ┃                                      ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("  ┃ SKILLS -Plug-in Chips: Set Type A: Defense             ┃                                      ┃┃ Storage Used: 113/128    ┃");
            Console.WriteLine("  ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛                                      ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine("  ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓                 ┏━━━━━━━━━━━━━━━━━━━┓                                ");
            Console.WriteLine("  ┃↑↓Sort: Equipped                    ┃┃                 ┃///////////////////┃                 ┏━━━━━━━━━━━━━━━━━━━━━━━━━━┓                             ");
            Console.WriteLine($"  ┃ ●Dealdy Heal +                      ┃┃                 ┃///////////////////┃                 ┃||Status||||||||||||||||||┃      ");
            Console.WriteLine($"  ┃                                      ┃┃                 ┃///////////////////┃                 ┣━━━━━━━━━━━━━━━━━━━━━━━━━━┃                 ");
            Console.WriteLine($"  ┃ ○ int DeadlyHeal             [{DeadlyHeal     }]   ┃┃                 ┃///////////////////┃                 ┃ 2B                  Lv.52┃                  ");
            Console.WriteLine($"  ┃                                      ┃┃                 ┣━━━━━━━━━━━━━━━━━━━┃                 ┣━━━━━━━━━━━━━━━━━━━━━━━━━━┃  ");    
            Console.WriteLine($"  ┃ ○ int MeleeDefense           [ {MeleeDefense   }]   ┃┃                 ┃|||||||||||||||||||┃                 ┃Fungs (G):         682,847┃                  ");
            Console.WriteLine($"  ┃                                      ┃┃                 ┃━━━━━━━━━━━━━━━━━━━┃                 ┃ EXP:              235,554┃                 ");
            Console.WriteLine($"  ┃ ○ int MeleeDefense  +1       [ {MeleeDefense1  }]   ┃┃              ▶ ┃                   ┃                 ┃ HP: ━━━━━━━   3,950/3,950┃                 ");
            Console.WriteLine($"  ┃                                       ┃                 ┃                   ┃                 ┣━━━━━━━━━━━━━━━━━━━━━━━━━━┃                  ");
            Console.WriteLine($"  ┃ ○ int MeleeDefense  +2       [ {MeleeDefense2  }]    ┃                 ┃                   ┃                 ┃ Atk(Light):    3,607+ 285┃                                ");
            Console.WriteLine($"  ┃                                       ┃                 ┃                   ┃                 ┃ Atk(Heavy):    3,712+ 297┃               ");
            Console.WriteLine($"  ┃ ○ int MeleeDefense  +3       [{MeleeDefense3  }]    ┃                 ┃━━━━━━━━━━━━━━━━━━━┃                 ┃ Range Attack:    150+  12┃                               ");
            Console.WriteLine($"  ┃   ┌─────────────────────────────────┐ ┃                 ┃                   ┃                 ┃ DeFense:            1,497┃                 ");
            Console.WriteLine($"  ┃ ○│ int MeleeDefense +6 ◆    [{MeleeDefense6  }]  │ ┃                 ┃━━━━━━━━━━━━━━━━━━━┃                 ┃□ □ □ □ □ □ □ □ □┃                 ");
            Console.WriteLine($"  ┃   └─────────────────────────────────┘ ┃                 ┃                   ┃                 ┃━━━━━━━━━━━━━━━━━━━━━━━━━━┃                 ");
            Console.WriteLine($"  ┃ ○ int RangedDefense1         [ {RangedDefense1 }]    ┃                 ┃━━━━━━━━━━━━━━━━━━━┃                 ┃━━━━━━━━━━━━━━━━━━━━━━━━━━┃                  ");
            Console.WriteLine($"  ┃                                       ┃                 ┃                   ┃                 ┃          No Error        ┃                 ");
            Console.WriteLine($"  ┃ ○ int RangeDefense2          [ {RangeDefense2  }]    ┃                 ┃━━━━━━━━━━━━━━━━━━━┃                 ┃━━━━━━━━━━━━━━━━━━━━━━━━━━┃                 ");
            Console.WriteLine("  ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛                 ┗━━━━━━━━━━━━━━━━━━━┛                 ┗━━━━━━━━━━━━━━━━━━━━━━━━━━┛                  ");
            Console.WriteLine("                                       ");
            Console.WriteLine("                                       ");
            Console.WriteLine("  ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("  ┃┃ Reduce melee damage taken by 30 %.                                     [W] [S] Select [Enter] Confirm [ESC] Back ┃");
            Console.WriteLine("  ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine("━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─ ━ ─  ━ ─  ━ ─  ━ ─  ━ ─  ━ ─  ━ ─  ━ ─  ━ ─  ━ ─ ");
            Console.WriteLine("∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ∵  ");






        }
    }
}
