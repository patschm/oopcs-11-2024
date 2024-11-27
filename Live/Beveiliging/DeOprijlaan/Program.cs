using Bosch;
using DoomsdayPreppers;
using Heras;
using Philips;
using Yunex;

DetectieLus lus = new DetectieLus();
Hek hek = new Hek();
Camera camera = new Camera();
Valkuil valkuil = new Valkuil();
Lamp lamp = new Lamp();

lus.Connect(hek);
lus.Connect(camera);
lus.Connect(valkuil);
lus.Connect(lamp);

lus.Detect();

// Dit is GEEN goed oplossing
//hek.Open();
//camera.Start();
//valkuil.Open();
