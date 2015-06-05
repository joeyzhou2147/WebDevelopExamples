namespace WebDev2015_03_25
{
    public class auth
    {
         <?php
             if(session_status()==PHP_SESSION_NONE)
{
    private session_start();
}

    include "php/database.connect.php";

    $username = $_REUQEST["u"];// name of input password element, only name left and id class are gone
    $password = $_REUQEST["p"];// name of input password element

    $statement = $db->prepare("Select aes_decrypt(email,'key') as user, aes_decrypt(password,'key') as pswd FROM users WHERE "
    +
    "aes_decrypt(email,'key')=? and aes_decrypt(password,'key')")

    $statement->exexute(array($username,$password));
    $row = $statement->fetch();

    $user = $row['user'];

    if(isset($user))// success
{
    unset($_SESSION['error']);
    $_SESSION['user'] = $user;
    require'welcome.php';
}else()// fail
{
    unset($_SESSION['user']);
    $_SESSION['error'] = "Credentials don't match...";
    require'index.php';
}
exit();
?>
    }
}