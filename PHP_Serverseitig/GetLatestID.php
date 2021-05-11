<?php
	error_reporting(E_ERROR | E_PARSE);
	//DB Connect:		
	$link = mysqli_connect("localhost","tmode00_bousers","********") or die ('ERROR: Could not connect to database!');
	mysqli_select_db($link, "tmode00_bousers");
		
	//GameID in der Datenbank suchen
	$e=mysqli_query($link,"SELECT id FROM romegame ORDER BY id DESC LIMIT 1");
	$arr = mysqli_fetch_array($e);
	
	echo "LatestID" . "\n";
	
	echo $arr["id"] + 1;			
?>