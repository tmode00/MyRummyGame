<?php
		//Stellt die Verbindung zur Datenbank her
		//Erhält die $GameID vi GET
		//Speichert 110 (0-109) Karten in $Karte (frischer neuer Kartenstapel, sortiert)
		
		//erhält folgende nutzbare Felder:		
		//$Player1CardsArray => Karten auf der Hand Spieler1 
		//$Player2CardsArray => Karten auf der Hand Spieler2 
		//$UsedCardsArray => alle benutzen Karten
		//$DroppedCardsArray => alle weggeworfenen Karten
		require_once('inc_StackUpdater.php');
        
		echo "<p>Spieler 1, ausgelesene 13 Karten:<br>";
				
		//Spieler1Array durchlaufen
		if ($Player1Cards != "")
		{
			for ($c=0;$c<=count($Player1CardsArray)-1;$c++)
			{							
				echo "<img src='". "./cardgfx/" . $Karte[$Player1CardsArray[$c]]->StapelID .".png' width=60 height=90 alt='fsfsaf' title=LfdNr:". $Karte[$Player1CardsArray[$c]]->LfdNr . "StapelID:" .  $Karte[$Player1CardsArray[$c]]->StapelID . "Zaehlwert:" . $Karte[$Player1CardsArray[$c]]->Zaehlwert . "Name:" . $Karte[$Player1CardsArray[$c]]->Name . "Farbe:" . $Karte[$Player1CardsArray[$c]]->Farbe . "Status:" . $Karte[$Player1CardsArray[$c]]->Status . "Eigentümer:" . $Karte[$Player1CardsArray[$c]]->Eigentuemer . "AnlageID:" . $Karte[$Player1CardsArray[$c]]->AnlageID ."></img>"; 	
			}
		}
			
		echo "<p>Spieler 2, ausgelesene 13 Karten:<br>";
		//Spieler2Array durchlaufen
		if ($Player2Cards != "")
		{
			for ($c=0;$c<=count($Player2CardsArray)-1;$c++)
			{	
				echo "<img src='". "./cardgfx/" . $Karte[$Player2CardsArray[$c]]->StapelID .".png' width=60 height=90 alt='fsfsaf' title=LfdNr:". $Karte[$Player2CardsArray[$c]]->LfdNr . "StapelID:" .  $Karte[$Player2CardsArray[$c]]->StapelID . "Zaehlwert:" . $Karte[$Player2CardsArray[$c]]->Zaehlwert . "Name:" . $Karte[$Player2CardsArray[$c]]->Name . "Farbe:" . $Karte[$Player2CardsArray[$c]]->Farbe . "Status:" . $Karte[$Player2CardsArray[$c]]->Status . "Eigentümer:" . $Karte[$Player2CardsArray[$c]]->Eigentuemer . "AnlageID:" . $Karte[$Player2CardsArray[$c]]->AnlageID ."></img>"; 	
			}
		}
		echo "<p>Benutze Karten:<br>";
		//UsedCards durchlaufen
		if ($UsedCards != "")
		{
			for ($c=0;$c<=count($UsedCardsArray)-1;$c++)
			{	
				echo "<img src='". "./cardgfx/" . $Karte[$UsedCardsArray[$c]]->StapelID .".png' width=60 height=90 alt='fsfsaf' title=LfdNr:". $Karte[$UsedCardsArray[$c]]->LfdNr . "StapelID:" .  $Karte[$UsedCardsArray[$c]]->StapelID . "Zaehlwert:" . $Karte[$UsedCardsArray[$c]]->Zaehlwert . "Name:" . $Karte[$UsedCardsArray[$c]]->Name . "Farbe:" . $Karte[$UsedCardsArray[$c]]->Farbe . "Status:" . $Karte[$UsedCardsArray[$c]]->Status . "Eigentümer:" . $Karte[$UsedCardsArray[$c]]->Eigentuemer . "AnlageID:" . $Karte[$UsedCardsArray[$c]]->AnlageID ."></img>"; 	
			}		
		}
		
		//Weggeworfene Karten durchlaufen:
		echo "<p>Weggeworfene Karten:<br>";
		if ($dropzone10 != "")
		{
			for ($c=0;$c<=count($DroppedCardsArray)-1;$c++)
			{	
				echo "<img src='". "./cardgfx/" . $Karte[$DroppedCardsArray[$c]]->StapelID .".png' width=60 height=90 alt='fsfsaf' title=LfdNr:". $Karte[$DroppedCardsArray[$c]]->LfdNr . "StapelID:" .  $Karte[$DroppedCardsArray[$c]]->StapelID . "Zaehlwert:" . $Karte[$DroppedCardsArray[$c]]->Zaehlwert . "Name:" . $Karte[$DroppedCardsArray[$c]]->Name . "Farbe:" . $Karte[$DroppedCardsArray[$c]]->Farbe . "Status:" . $Karte[$DroppedCardsArray[$c]]->Status . "Eigentümer:" . $Karte[$DroppedCardsArray[$c]]->Eigentuemer . "AnlageID:" . $Karte[$DroppedCardsArray[$c]]->AnlageID ."></img>"; 	
			}	
		}

echo "<p>";
echo "id: " . $id ."<br>";
echo "GameCreationTime: " . $GameCreationTime ."<br>";
echo "Player1Cards: " . $Player1Cards ."<br>";
echo "Player2Cards: " . $Player2Cards ."<br>";
echo "UsedCards: " . $UsedCards ."<br>";
echo "Spielphase: " . $Spielphase . "<br>";
echo "weristdran: " . $weristdran . "<br>";
echo "zugid: " . $zugid . "<br>";
echo "Player1KartenInHand" . "<br>";
echo "Player2KartenInHand" . "<br>";
echo "dropzone1: " . $dropzone1 . "<br>";
echo "dropzone2: " . $dropzone2 ."<br>";
echo "dropzone3: " . $dropzone3 ."<br>";
echo "dropzone4: " . $dropzone4 ."<br>";
echo "dropzone5: " . $dropzone5 ."<br>";
echo "dropzone6: " . $dropzone6 ."<br>";
echo "dropzone7: " . $dropzone7 ."<br>";
echo "dropzone8: " . $dropzone8 ."<br>";
echo "dropzone9: " . $dropzone9 ."<br>";
echo "dropzone10: " . $dropzone10 ."<br>";
echo "Player1hat30: " . $Player1hat30 . "<br>";
echo "Player2hat30: " . $Player2hat30 . "<br>";		
?>