using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HattrickMVC.Models;

namespace HattrickMVC.Data
{
    public static class AppDbContextExtension
    {
        public static void EnsureDatabaseSeeded(this ApplicationDbContext context) {
            if (!context.Nogomet.Any())
            {
                context.AddRange(new Nogomet[]{
                    new Nogomet() {
                        SportName = "Nogomet",
                        EkipaDomacin = "Ekipa 1",
                        EkipaGost = "Ekipa 2",
                        GameId = 100
                    },
                    new Nogomet()
                    {
                        SportName = "Nogomet",
                        EkipaDomacin = "Ekipa 3",
                        EkipaGost = "Ekipa 4",
                        GameId = 101
                    }
                });
                context.AddRange(new AvailableBetTypes[] {
                    new AvailableBetTypes(){
                        GameId = 100,
                        AvialableBet = "Osnovno"
                    },
                    new AvailableBetTypes(){
                        GameId = 100,
                        AvialableBet = "Zbroj golova"
                    },
                    new AvailableBetTypes(){
                        GameId = 101,
                        AvialableBet = "Osnovno"
                    },
                }); 
                context.AddRange(new PossibleTips[]{
                    new PossibleTips(){
                        GameId = 100,
                        BetType = "Osnovno",
                        PossibleBet = "1",
                        Multiplier = 1.87
                    },
                    new PossibleTips(){
                        GameId = 100,
                        BetType = "Osnovno",
                        PossibleBet = "X",
                        Multiplier = 1.80
                    },
                    new PossibleTips(){
                        GameId = 100,
                        BetType = "Osnovno",
                        PossibleBet = "2",
                        Multiplier = 2.35
                    },
                    new PossibleTips(){
                        GameId = 100,
                        BetType = "Zbroj golova",
                        PossibleBet = "1",
                        Multiplier = 1.85
                    },
                    new PossibleTips(){
                        GameId = 100,
                        BetType = "Zbroj golova",
                        PossibleBet = "2",
                        Multiplier = 1.85
                    },
                    new PossibleTips(){
                        GameId = 101,
                        BetType = "Osnovno",
                        PossibleBet = "1",
                        Multiplier = 1.85
                    },
                    new PossibleTips(){
                        GameId = 101,
                        BetType = "Osnovno",
                        PossibleBet = "X",
                        Multiplier = 3.85
                    },
                    new PossibleTips(){
                        GameId = 101,
                        BetType = "Osnovno",
                        PossibleBet = "2",
                        Multiplier = 2.85
                    }
                    

            });
                context.Add(new User()
                {
                    novcanik = 50,
                    listici = ""
                });
                context.SaveChanges();
            }
        }
    }
}
