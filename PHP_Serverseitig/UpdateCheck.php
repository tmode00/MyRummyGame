<?php
require_once('inc_StackUpdater.php');

echo "UpdateCheck" . "\n"; // Element 0

echo $id . "\n"; // Element 1
echo $GameID . "\n"; // Element 2
echo $GameCreationTime. "\n"; // Element 3
echo $Player1Cards. "\n"; // Element 4
echo $Player2Cards. "\n"; // Element 5
echo $UsedCards. "\n"; // Element 6
echo $Player1KartenInHand. "\n"; // Element 7
echo $Player2KartenInHand. "\n"; // Element 8
echo $zugid. "\n"; // Element 9
echo $Spielphase. "\n"; // Element 10
echo $weristdran. "\n"; // Element 11
echo $dropzone1. "\n"; // Element 12
echo $dropzone2. "\n"; // Element 13
echo $dropzone3. "\n"; // Element 14
echo $dropzone4. "\n"; // Element 15
echo $dropzone5. "\n"; // Element 16
echo $dropzone6. "\n"; // Element 17
echo $dropzone7. "\n"; // Element 18
echo $dropzone8. "\n"; // Element 19
echo $dropzone9. "\n"; // Element 20 
echo $dropzone10. "\n";// Element 21
echo $StrafpunkteP1. "\n";// Element 22
echo $StrafpunkteP2;// Element 23

//Alle Karten aus dem Stapel zurückgeben:
for ($c=0;$c<=109;$c++)
{
	echo "\n" .
	GetCardByStapelID($Karte, $c)->LfdNr	. "~" .
	GetCardByStapelID($Karte, $c)->StapelID	. "~" .
	GetCardByStapelID($Karte, $c)->Zaehlwert . "~" .
	GetCardByStapelID($Karte, $c)->Name . "~" .
	GetCardByStapelID($Karte, $c)->Farbe . "~" .
	GetCardByStapelID($Karte, $c)->Status . "~" .
	GetCardByStapelID($Karte, $c)->Eigentuemer . "~" .
	GetCardByStapelID($Karte, $c)->AnlageID;			
	
}

?>
	