<!DOCTYPE html>
<?php
if(isset($_POST['start']) && isset($_POST['end'])) {
    function isPrime($num) {
        if(is_nan($num) || $num % 1 || $num < 2) return false;
        if($num % 2 == 0) return ($num == 2);
        if($num % 3 == 0) return ($num == 3);

        $m = sqrt($num);

        for($i = 5; $i <= $m ;$i+=6) {
            if($num % $i == 0) return false;
            if($num % ($i+2) == 0) return false;
        }
        return true;
    }
    $start = $_POST['start'];
    $end = $_POST['end'];
    $numbers = array();

    for($i = $start; $i <= $end ;$i++) {
        if(isPrime($i)) {
            $numbers[] = "<span class='prime'>{$i}</span>";
        }
        else {
            $numbers[] = "<span>{$i}</span>";
        }
    }

    $result = implode(', ', $numbers);
}
?>
<html>
<head>
    <title>Find Primes In Range</title>
    <style>
        span.prime {
            font-weight: bold;
        }
    </style>
</head>
<body>
<form action="" method="post">
    <label for="">Starting Index:</label>
    <input type="text" name="start" id="start"/>

    <label for="end">End</label>
    <input type="text" name="end" id="end"/>

    <input type="submit" value="Submit"/>
</form>
<div id="result">
    <?php
    if(isset($result)) {
        echo $result;
    }
    ?>
</div>
</body>
</html>