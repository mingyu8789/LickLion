﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 모험가_키우기
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //멋사
            int gold = 5000000;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;

            Console.WriteLine(" ⚔️ 모험가 키우기 ⚔️ ");
            Thread.Sleep(1000);

            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine($" 현재 상태 : 체력 {health} | 골드 {gold} | 공격력 {power}");
                Console.WriteLine("\n1. 탐험하기 🏕️");
                Console.WriteLine("2. 장비 뽑기 🎲 (1000골드");
                Console.WriteLine("3. 휴식하기 💤 (체력 +20");
                Console.WriteLine("4. 게임 종료 ");
                Console.Write("입력: ");

                input = int.Parse(Console.ReadLine());

                if (input == 1)  //탐험하기
                {
                    Console.Clear();
                    Console.WriteLine(" 탐험을 떠납니다.");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine(" 탐험을 떠납니다..");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine(" 탐험을 떠납니다...");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine(" 탐험을 떠납니다....");
                    Thread.Sleep(500);

                    int eventChance = rand.Next(1, 101);    //1~100 랜덤 이벤트 발생

                    if (eventChance <= 30)   //30% 확률로 전투 발생
                    {
                        int damage = rand.Next(5, 21);
                        Console.WriteLine($"⚔️ 몬스터를 만났습니다! (체력 -{damage}");
                        health -= damage;
                    }
                    else if (eventChance <= 70)  //40% 확률로 보상
                    {
                        int reward = rand.Next(100, 301);   //100~300골드
                        Console.WriteLine($"💰 보물을 발견했습니다! (+{reward} 골드");
                        gold += reward;
                    }
                    else //30% 확률로 회복
                    {
                        int heal = rand.Next(10, 31);
                        Console.WriteLine($"🌿 신비한 약초를 발견했습니다! (+{heal} 체력");
                        health += heal;
                    }

                    if (health <= 0)
                    {
                        Console.WriteLine("\n 💀 체력이 0이 되어 사망했습니다... 게임 오버!");
                        isAlive = false;
                    }
                    Thread.Sleep(1000);
                }
                else if (input == 2)    //장비뽑기
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();
                        Console.WriteLine("🎲 장비를 뽑습니다...");
                        Thread.Sleep(1000);

                        int rnd = rand.Next(1, 101);    //1~100랜덤

                        if (rnd == 1)
                        {
                            Console.WriteLine("SSS급 전설의 검 (공격력 +50 획득!");
                            power += 50;
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine("SS급 회귀한 검 (공격력 + 30) 획득!");
                            power += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("S급 강철 검 (공격력 + 20) 획득!");
                            power += 20;
                        }
                        else
                        {
                            Console.WriteLine("녹슨칼 (공격력 + 5) 획득!");
                            power += 5;
                        }
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)  //휴식하기
                {
                    Console.WriteLine("휴식을 취합니다...(+20 체력");
                    health += 20;
                    Thread.Sleep(1000);
                }
                else if (input == 4)  //종료하기
                {
                    Console.WriteLine("게임을 종료합니다. 감사합니다!");
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                    Thread.Sleep(1000);
                }
                }
            }
        }
    }
