<?php      		
		require_once('inc_StackUpdater.php');

		//Spiel gefunden?
		echo "JoinGame" . "\n"; //Reslines 0
		if ($id)
		{
			//Infos zum Spiel zurückgeben:
			echo $GameID . "\n"; //Reslines 1	
			echo $id . "\n"; //Reslines 2	 
			echo $GameCreationTime . "\n"; //Reslines 3		 
			
			if ($Player1KartenInHand == 13)
			{
				echo "Player1hat13"; //Reslines 4
			}
			else
			{
				echo "Player2hat13"; //Reslines 4
			}		

			
		} else {
			die("NOGAME"); //Reslines 1			
		}
		
		//SpielStatus auf "SpielBeigetreten" updaten => nicht mehr tun, zerstört Kartegezogen logik
		//mysqli_query($link,"UPDATE romegame SET Spielphase='SpielBeigetreten' WHERE GameID='".$GameID."'");
?>