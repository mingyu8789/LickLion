using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 텍스트알피지시험
{

    public class MainGame
    {
        public Stage stage;
        public Player player;

        public void FirstRoom()  //처음 스테이지
        {
            stage = new Stage();
            stage.PlayerChoseJobStage();    //직업고르기
        }

        public void VillageRoom()    //마을 스테이지
        {
            player = new Player();
            Console.Clear();

            player.PlayerInfo();    //플레이어 상태창


        }


    }
}
