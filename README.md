# Unity_Plateau
 
	- Partie Technique :
		
		- Gestion des animations :
			- Un Timer pour déclencher des animations d'idle et de saut aléatoires toutes les 3 secondes lorsque le personnage est immobile.
			- L'animation est choisie au hasard parmi les valeurs 0, 1 et 2, et le paramètre IdleRandom est mis à jour dans l'Animator.
			
		- Gestion des déplacements :
			- Le personnage se déplace vers un point cible en utilisant un NavMeshAgent.
			- La vitesse du personnage est synchronisée avec l'Animator grâce au paramètre Speed.

	- Réponse à la question :
		
		- Les formats qui sont supportés par le moteur (FBX,OBJ) ?
		- Est ce que il y a des plugins ou des outils qui facilite la gestion des animations ou d'intégrer les assets ?
		- Quelles sont les paramètres utilisés pour contrôlé les transitions entre les états ? 
		- Comment sont gérer les états et les transitions ?

	 - Fonctionnement d'un FSM :
		- Etats : états qui représente une animation (Idle, Run...)
		- Transitions : Des conditions qui déterminent quand et comment on passe d'un état a un autre.
		- Conditions : Des critères qui déclenches les transitions (exemple "IsMoving" pour passe de l'état Idle a Walk)
