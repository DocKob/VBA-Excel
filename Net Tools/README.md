### https://crea-scratch.fr/projects

# Installation de la librairie Winsock

Attention: la librairie utilisée n'est pour l'instant, compatible qu'avec Windows 7 32 bits !

Commencez par copier le fichier "OSWINSCK.dll" dans le dossier C:\Windows\System32\

Puis pour activer la librairie, ouvrez un invité de commande et tapez :

> regsvr32 OSWINSCK.dll

# Utilisation

Effectuer un ping sur une IP :
```
Ping ("ip")
```

Effectuer un nslookup sur une IP
```
GetHostName("ip")
```

### Console socket :

![Net Console](https://hitea.fr//wp-content/uploads/2016/11/console.jpg)

- Entrez une Ip et un Port pour la connexion puis appuyez sur "GO".
- Vous pouvez alors envoyer des commandes et visualiser la réponse de l'hôte dans la console.
- Appuyez sur "Save TxT" pour sauvegarder le fichier de log dans le même dossier.
- Appuyez sur "Clear" pour remettre à zéro la console ou "Close" pour la fermer.
