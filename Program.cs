using ConsoleApp19;
ICharger NormalCharging = new NormalCharging(25, "Black", "Normal Charger");
Mobile mobile1 = new Mobile(NormalCharging);
mobile1.DisplayChargerInfo();


ICharger FastCharging = new FastCharging(120, "Red", "Fast Chaeger");
Mobile mobile2 = new Mobile(FastCharging);
mobile2.DisplayChargerInfo();
