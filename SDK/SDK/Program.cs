var manifest = new Home.HomeManifest();


MV.Client.MVClient c = new MV.Client.MVClient();
await c.Init(manifest.Definition());

