<?php
if ( $_SERVER["SCRIPT_FILENAME"] == __FILE__ ){
    $racine="..";
}

// creation du menu burger
$menuBurger = array();
$menuBurger[] = Array("url"=>"./?action=liste&page=2","label"=>"Administrateur");






// appel du script de vue qui permet de gerer l'affichage des donnees
$titre = "Liste des objets";
include "$racine/vue/vueEntete.php";
include "$racine/vue/vueListeObjets.php";
include "$racine/vue/vuePied.php";
