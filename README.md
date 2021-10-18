

Test introduction à Unity

Objectif

Reproduire un jeu simple, **Doodle Jump**

Description

Il y a plein de versions différentes de ce jeu, mais vous pouvez vous baser sur la vidéo

d’exemple d’un extrait du jeu, ou bien avec la version jouable en ligne (cf ci-dessous)

Vous avez à votre disposition des images et sons provenant du jeu.

Liens :

\-

\-

\-

Doodle Jump en ligne : <https://poki.com/fr/g/sauter+vers+le+haut/doodle+jump>

Vidéo d’exemple : [Doodle](https://www.youtube.com/watch?v=QVfkpZGOGBY)[ ](https://www.youtube.com/watch?v=QVfkpZGOGBY)[Jump](https://www.youtube.com/watch?v=QVfkpZGOGBY)[ ](https://www.youtube.com/watch?v=QVfkpZGOGBY)[Full](https://www.youtube.com/watch?v=QVfkpZGOGBY)[ ](https://www.youtube.com/watch?v=QVfkpZGOGBY)[Gameplay](https://www.youtube.com/watch?v=QVfkpZGOGBY)[ ](https://www.youtube.com/watch?v=QVfkpZGOGBY)[Walkthrough](https://www.youtube.com/watch?v=QVfkpZGOGBY)

Images et sons / Ressources : [Doodle](https://drive.google.com/drive/folders/1DtT2XCwOLfZBNj114iF7FQ1WyBMWvJzv?usp=sharing)[ ](https://drive.google.com/drive/folders/1DtT2XCwOLfZBNj114iF7FQ1WyBMWvJzv?usp=sharing)[Jump](https://drive.google.com/drive/folders/1DtT2XCwOLfZBNj114iF7FQ1WyBMWvJzv?usp=sharing)

Le jeu devra comporter :

● **Un menu principal**, avec un bouton “Jouer”, et un bouton “Quitter”

● **une boucle complète du jeu** (c'est-à-dire, du menu, puis le jeu en lui-même, et le

retour au menu quand on perd).

● Un **score** atteint par le joueur, visible tout le temps, et à la fin du jeu

● Un **personnage jouable** avec :

○ des animations : **une animation idle** (quand il ne se passe rien), de quand il

**saute** (il plie ses petites jambes), et de quand il **tire** à la verticale (pas besoin

de la version quand il tire en diagonale).





○ des **déplacements horizontaux** contrôlables avec les touches “flèche de

gauche” et “flèche de droite”

○ des **sauts** dès qu’il touche une plateforme, ou un ennemi par dessus.

○ une **téléportation** quand il sort de la zone de jeu horizontalement, pour

réapparaître de l’autre côté de l’écran

○ qui déclenche **la fin du jeu si il sort de la zone de jeu par le bas**

**○** (*Optionnel*) la possibilité de **tirer** au dessus de soi pour détruire des ennemis

en appuyant sur la “flèche du haut” ou espace

● Une **caméra qui ne peut que monter**

● Des plateformes qui apparaissent quand le joueur monte :

○ Des **plateformes vertes**, fixes

○ Des **plateformes bleues**, qui bougent de manière horizontale sur tout l’écran

○ Des **plateformes marron**, qui se cassent quand le personnage-joueur les

touche

● Des obstacles :

○ des **trous noirs** qui déclenchent la fin du jeu si le joueur les touche

○

des **ennemis** qui déclenchent aussi la fin du jeu si le joueur les touche.

*(Optionnel)* le joueur peut tirer dessus ou tomber dessus pour s’en

débarrasser

● D’objets bonus qui aident à monter :

○ des **ressorts** qui font sauter beaucoup plus haut le joueur s’il tombe dessus

○

○

*(Optionnel)* des **hélico-chapeaux** qui l’aident à monter, puis disparaît

*(Optionnel)* des **jet-packs**, qui font comme les hélico-chapeaux, mais en plus

fort

Rendu

Les critères de notation sont basés sur **la qualité de l’expérience de jeu**. Je préfère

recevoir un projet avec moins de fonctionnalités, mais qui fonctionne bien, qu’un projet avec

beaucoup de fonctionnalités qui ne sont pas finies.





Ce projet est à faire par **groupe de 2 à 3 personnes**.

Vous ferez votre jeu avec la version de **Unity 2020.3.19f1**.

Il sera jouable sur **PC**.

Pour le rendu, il faudra me rendre sur Moodle :

**-**

**-**

**-**

**Votre projet Unity en entier**

**Une build de votre jeu pour Windows**

**Un bloc-note contenant les noms des différentes personnes de votre équipe**

Comme vous allez travailler en équipe, je vous conseille d’utiliser **Git**, mais il y a des choses

à savoir si c’est avec Unity.

D'abord, Unity génère BEAUCOUP de fichiers qui vont sont inutiles à mettre sur votre

répertoire Git, car ils seront régénérés de toute manière à chaque fois.

Pour palier à ce problème, utilisez un fichier **.gitignore**, trouvable facilement sur internet, et

mettez-le **dès votre premier commit !** (Ce n’est pas irrattrapable, mais il faut rentrer des

commandes en plus pour corriger le problème)

Deuxièmement, certains fichiers d’Unity ne vont pas merge correctement, et vous allez

perdre beaucoup de votre temps à régler ces conflits…

Les fichiers scripts, les .cs, devraient bien fusionner.

Mais pour les fichiers des différentes **scènes** que vous allez créer (les fichiers .unity), ainsi

que les **prefabs**, **il va falloir que vous ne travailliez pas en même temps dessus**.

Vous pouvez me contacter par mail avec <nathanbardin.pro@gmail.com>

Voilà, bonne chance !

