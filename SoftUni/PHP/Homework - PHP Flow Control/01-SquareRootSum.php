<!DOCTYPE html>
<?php
$result = "<table border='1'><thead><tr><th>Number</th><th>Square</th></tr></thead>" .
    "<tbody>";
$sum = 0;
for($i = 0; $i <= 100 ;$i+=2) {
    $square = round(sqrt($i), 2);
    $sum += $square;
    $result .= "<tr><td>{$i}</td><td>{$square}</td></tr>";
}
$result .= "</tbody><tfoot><tr><td>Sum:</td><td>{$sum}</td></tr></tfoot></table>";
?>
<html>
<head>
    <title>Square Root Sum</title>
    <style>
        th, td {
            padding: 5px;
        }
    </style>
</head>
<body>
<?php
if(isset($result)) {
    echo $result;
}
?>
</body>
</html>