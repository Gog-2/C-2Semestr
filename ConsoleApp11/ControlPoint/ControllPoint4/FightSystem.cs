using ConsoleApp11.ControlPoint.ControllPoint4.Stats;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp11.ControlPoint.ControllPoint4
{
    internal class FightSystem
    {
        public List<Unit> LeftTeam;
        public List<Unit> RightTeam;
        private Unit _leftCurrentUnit;
        private Unit _rightCurrentUnit;

        public FightSystem(List<Unit> leftTeam, List<Unit> rightTeam)
        {
            LeftTeam = leftTeam;
            RightTeam = rightTeam;
            _leftCurrentUnit = LeftTeam.First();
            _rightCurrentUnit = RightTeam.First();
        }

        public void NextUnit(ref Unit currentUnit, List<Unit> team)
        {
            int pos = team.IndexOf(currentUnit);
            for (int i = 1; i <= team.Count; i++)
            {
                int nextPos = (pos + i) % team.Count;
                if (team[nextPos].Hp > 0)
                {
                    currentUnit = team[nextPos];
                    return;
                }
            }
        }

        public int GetTeamHP(in List<Unit> team)
        {
            return team.Sum(u => u.Hp > 0 ? u.Hp : 0);
        }

        private float GetPotentialDamage(Damage damage)
        {
            return damage.PhysicDamage + damage.MagicDamage + (damage.AbsoluteDamage ?? 0f);
        }

        public void ManageFight(out int totalHits, out float totalDamage)
        {
            totalHits = 0;
            totalDamage = 0f;

            while (GetTeamHP(LeftTeam) > 0 && GetTeamHP(RightTeam) > 0)
            {
                if (_leftCurrentUnit.Hp > 0 && _rightCurrentUnit.Hp > 0)
                {
                    totalHits++;
                    totalDamage += GetPotentialDamage(_leftCurrentUnit.Damage);
                    _leftCurrentUnit.Attack(_rightCurrentUnit);
                }

                if (_rightCurrentUnit.Hp > 0 && _leftCurrentUnit.Hp > 0)
                {
                    totalHits++;
                    totalDamage += GetPotentialDamage(_rightCurrentUnit.Damage);
                    _rightCurrentUnit.Attack(_leftCurrentUnit);
                }

                Console.WriteLine("\n=== Team Status ===");
                foreach (var u in LeftTeam) u.GetInfo();
                foreach (var u in RightTeam) u.GetInfo();
                Console.WriteLine("===================\n");

                if (_leftCurrentUnit.Hp <= 0)
                    NextUnit(ref _leftCurrentUnit, LeftTeam);

                if (_rightCurrentUnit.Hp <= 0)
                    NextUnit(ref _rightCurrentUnit, RightTeam);
            }

            if (GetTeamHP(LeftTeam) > 0)
                Console.WriteLine("Left Team wins!");
            else if (GetTeamHP(RightTeam) > 0)
                Console.WriteLine("Right Team wins!");
            else
                Console.WriteLine("Draw!");
        }
    }
}