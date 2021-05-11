<?php
require_once('inc_StackUpdater.php');

$NewSiblingIndex = $_GET["NewSiblingIndex"]; 
$StapelID = $_GET["StapelID"];


//Wer sendet?

//Wenn Player1 sendet dessen Kartzten neu sortieren
if ($wersendet == "Player1")
{		
	//übergeben wird das PlayerArray, die KArte welche sortiert werden soll und die neue Position auf der Hand
	moveElement($Player1CardsArray, get_card_position($Player1CardsArray, $StapelID), $NewSiblingIndex);
	
	//Write Array back to ~~~
	$Player1Cards = WriteArrayBackToTilde($Player1CardsArray);
		
	//DB Update:
  	mysqli_query($link,"UPDATE romegame SET Player1Cards='".$Player1Cards."' WHERE GameID='".$GameID."'");
	
	echo "OrderOK";
}
if ($wersendet == "Player2")
{
	//übergeben wird das PlayerArray, die KArte welche sortiert werden soll und die neue Position auf der Hand
	moveElement($Player2CardsArray, get_card_position($Player2CardsArray, $StapelID), $NewSiblingIndex);
	
	//Write Array back to ~~~
	$Player2Cards = WriteArrayBackToTilde($Player2CardsArray);
		
	//DB Update:
  	mysqli_query($link,"UPDATE romegame SET Player2Cards='".$Player2Cards."' WHERE GameID='".$GameID."'");
	
	echo "OrderOK";
	
}

function moveElement(&$array, $a, $b) 
{	
    $out = array_splice($array, $a, 1);
    array_splice($array, $b, 0, $out);
}


?>