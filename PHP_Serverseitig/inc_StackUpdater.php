<?php		
		error_reporting(E_ERROR | E_PARSE);
		require_once('class.Karte.php');
		        
		//GETS erhalten ===>
		$GameID = $_GET["GameID"];
		$wersendet =  $_GET["wersendet"];	
		
		//DB Connect:		
		$link = mysqli_connect("localhost","tmode00_bousers","********") or die ('ERROR: Could not connect to database!');
		mysqli_select_db($link, "tmode00_bousers");
		
		//GameID in der Datenbank suchen
		$e=mysqli_query($link, "select * from romegame where GameID = '" . $GameID . "' limit 1");
        $arr = mysqli_fetch_array($e);
		
		if ($arr["GameID"])
		{
			//Felder merken ====> Für alle =>
			$id = $arr["id"];
			$GameCreationTime = $arr["GameCreationTime"];
			$Player1Cards = $arr["Player1Cards"];
			$Player2Cards = $arr["Player2Cards"];
			$UsedCards = $arr["UsedCards"];			
			$Spielphase = $arr["Spielphase"];			
			$weristdran = $arr["Weristdran"];
			$zugid = $arr["ZugID"];			
			$Player1KartenInHand = $arr["Player1KartenInHand"];
			$Player2KartenInHand = $arr["Player2KartenInHand"];
			$dropzone1 = $arr["DropZone1"];
			$dropzone2 = $arr["DropZone2"];
			$dropzone3 = $arr["DropZone3"];
			$dropzone4 = $arr["DropZone4"];
			$dropzone5 = $arr["DropZone5"];
			$dropzone6 = $arr["DropZone6"];
			$dropzone7 = $arr["DropZone7"];
			$dropzone8 = $arr["DropZone8"];
			$dropzone9= $arr["DropZone9"];
			$dropzone10 = $arr["DropZone10"];
			$Player1hat30 = $arr["Player1hat30"];
			$Player2hat30 = $arr["Player2hat30"];
			$StrafpunkteP1 = $arr["StrafpunkteP1"];
			$StrafpunkteP2 = $arr["StrafpunkteP2"];
			
			//Spieler 1 Karten Spliten:
			if ($Player1Cards != "") { $Player1CardsArray=explode("~",$Player1Cards); }               
			if ($Player2Cards != "") { $Player2CardsArray=explode("~",$Player2Cards); }               
			if ($UsedCards != "") { $UsedCardsArray=explode("~",$UsedCards); } 
			if ($dropzone10 != "") { $DroppedCardsArray=explode("~",$dropzone10); }
									
			
			//Spieler1Array durchlaufen
			if ($Player1Cards != "")
			{
				for ($c=0;$c<=count($Player1CardsArray)-1;$c++)
				{	
					//Karte aus dem Stapel holen, damit Änderungen im Stapel vorgenommen werden können
					$Karte[$Player1CardsArray[$c]] = GetCardByStapelID($Karte, $Player1CardsArray[$c]);
					$Karte[$Player1CardsArray[$c]]->Status = "gezogen";//Karte als nicht mehr ziehbar eintragen			             
					$Karte[$Player1CardsArray[$c]]->Eigentuemer = "Spieler1";
						
					$LfdNr += 1;
					$Karte[$Player1CardsArray[$c]]->LfdNr = $LfdNr;
				}				
			}

						
			//Spieler2Array durchlaufen
			if ($Player2Cards != "")
			{
				for ($c=0;$c<=count($Player2CardsArray)-1;$c++)
				{	
					//Karte aus dem Stapel holen, damit Änderungen im Stapel vorgenommen werden können
					$Karte[$Player2CardsArray[$c]] = GetCardByStapelID($Karte, $Player2CardsArray[$c]);
					$Karte[$Player2CardsArray[$c]]->Status = "gezogen";//Karte als nicht mehr ziehbar eintragen			             
					$Karte[$Player2CardsArray[$c]]->Eigentuemer = "Spieler2";
					
					$LfdNr += 1;
					$Karte[$Player2CardsArray[$c]]->LfdNr = $LfdNr;
				}
			}
						
			//UsedCards durchlaufen
			if ($UsedCards != "")
			{
				for ($c=0;$c<=count($UsedCardsArray)-1;$c++)
				{	
					//Karte aus dem Stapel holen, damit Änderungen im Stapel vorgenommen werden können
					$Karte[$UsedCardsArray[$c]] = GetCardByStapelID($Karte, $UsedCardsArray[$c]);
					$Karte[$UsedCardsArray[$c]]->Status = "gezogen";//eine benutze Karte ist immer eine gezogene Karte (wichtig damit die benutze Karte nicht erneut gezogen wird)
				}		
			}
			
			
			//DroppedCards durchlaufen
			if ($dropzone10 != "")
			{
				for ($c=0;$c<=count($DroppedCardsArray)-1;$c++)
				{	
					//Karte aus dem Stapel holen, damit Änderungen im Stapel vorgenommen werden können
					$Karte[$DroppedCardsArray[$c]] = GetCardByStapelID($Karte, $DroppedCardsArray[$c]);	
					$Karte[$DroppedCardsArray[$c]]->Eigentuemer = "Muellhaufen";
				}	
			}			
		} 
		else
		{
			die("NOGAME");
		}		  

		
		
?>