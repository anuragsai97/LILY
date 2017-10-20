<?php

@mysql_connect("localhost", "root", "") or
    die("Could not connect: " . mysql_error());
mysql_select_db("lily");
$name=$_GET['name'];
$result = mysql_query("SELECT Hostel, Room FROM hostel_details WHERE Name='$name'");

while ($row = mysql_fetch_array($result, MYSQL_ASSOC)) {
    printf("Hostel: %s  Room: %s", $row["Hostel"], $row["Room"]);
}

mysql_free_result($result);

?>