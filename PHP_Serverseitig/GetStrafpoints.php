<?php      		
		require_once('inc_StackUpdater.php');

		//Spiel gefunden?
		if ($id)
		{
			if ($StrafpunkteP1 > 0)
			{
				echo "StrafpunkteP1" . "\n";
				echo $StrafpunkteP1;
			}
			
			if ($StrafpunkteP2 > 0)
			{
				echo "StrafpunkteP2" . "\n";
				echo $StrafpunkteP2;
			}
			
			

			
		} else {
			die("NOGAME");			
		}
		
		//SpielStatus auf "SpielBeigetreten" updaten => nicht mehr tun, zerstört Kartegezogen logik
		//mysqli_query($link,"UPDATE romegame SET Spielphase='SpielBeigetreten' WHERE GameID='".$GameID."'");
?>