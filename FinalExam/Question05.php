

<?php
/**
 * Created by PhpStorm.
 * User: yuzhou
 * Date: 2015/5/7
 * Time: 7:11
 */
        $data = array();
        if ($_GET["city"]) {
            $city = $_GET["city"];
            if (strcmp(strtolower($city), 'boston') == 0) {
                $data['weather'] = 'Sunny';
                $data['temp'] = '74';
            } else

                if (strcmp(strtolower($city), 'chicago') == 0) {
                    $data['weather'] = 'Cloudy';
                    $data['temp'] = '80';
                } else {
                    $data['weather'] = 'I don\'t know the weather for that city.';
                    $data['temp'] = '';
                }
        }

        header('Content-Type: application/json');
        echo json_encode($data);
?>