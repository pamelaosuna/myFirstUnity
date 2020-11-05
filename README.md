Game features
---------------
(Les mouvements sont conçus pour un clavier QWERTY.)
Le joueur est une sphère qui peut se déplacer vers le haut (en appuyant sur W), vers le bas (en appuyant sur S), vers la droite (en appuyant sur D), vers la gauche (en appuyant sur A), et sauter (en appuyant sur espace).
Il a une barre de vie qui se conserve tout au long des niveaux.

Le caméra suit le jour tout au long du jou et il est possible d'utiliser la molette de défilement de la souris pour s'approcher ou s'éloiger de la perspective donnée.

On peut sortir du jeu à tout moment en appuyant sur Escape et puis en cliquant _Yes_, sinon on peut revenir au jeu en cliquant sur _No_ ou en rappuyant sur Escape.

### Niveau 1:

C'est le niveau le plus simple.
L'utiliser peut intéragir avec les objets, et en pressant le button une porte lui dirigéant vers le niveau 2 s'ouvre.

### Niveau 2:

Plusieurs types d'objets sont présents sur ce niveau:
* Un ennemi qui est en mouvement. On perd des points de vie si on rentre en contact avec lui. 
* Une fusée qui permet de détruire l'ennemi. Il faut se rapprocher et en rentrant en contact avec elle on l'active. Elle est programmée pour un lancement vers le haut et 2 secondes après vers l'ennemi.
* Des points de vie sous forme des bières et des bouteilles de vin, en les prennant on change de couleur pendant 2 secondes.
* Un bouton qui marche de manière similaire à celui du niveau 1.

### Niveau 3:
* Un ennemi qui suit le joueur, et qui, comme pour le niveau précedent, lui fait perdre des points de vie en rentrant en contact avec lui.
* Des points de vie.
* Un isoloir dans lequel on trouve un bouton pour fermer la porte, et qui nous permet de passer au niveau suivant en se rapprochant du texte qu'il a l'intérieur.


### Niveau 4:
Ce niveau est un environnement simple qui possède des trous, quand on y tombe on perd de la vie, et on revient à la position de départ de ce niveau.
On passe au niveau suivant en appuyant sur le bouton.
(Si on essaye de rajouter du matériel pour changer la couleur du terrain les trous sont cachés.)

### Niveau 5:
Au début du niveau on se trouve derrière deux portes et la pièce est plutôt sombre, avec une lumière qui rayonne legèrement, elle pointe vers un interrumpteur d'éclairage.
Quand on touche cette interrumpteur une autre lumière s'allume, si on le retouche elle s'éteint.

On peut aussi y trouver:
* Des potions magiques qui permettent de rendre le joueur invincible pendant 10 secondes, il le font changer d'une couleur différente que celle des points de vie.
* Des points de vie sous forme de bières.
* Un grand ennemi qui suit le joueur seulement quand la lumière est allumée, il possède une barre de vie en rouge. Pour le tuer il faut lui tirer dessus avec un raycastshoot du joueur qui est activé quand on clique. Une fois que l'ennemi est tué, on a gagné le joue, et un message apparait en demandant si on veut rejouer.
