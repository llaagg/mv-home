﻿using MV.OneD.UI;

var manifest = new Home.HomeManifest();

await Clients.StartOneD(manifest);

//await Clients.StartTwoD(manifest);

