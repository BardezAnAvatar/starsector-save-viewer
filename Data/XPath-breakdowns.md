# Root
/CampaignEngine/hyperspace/o/saved/*

## Location Token
    ./LocationToken[1]/orbit/s/o/saved
---------------------------------------------
    ./LocationToken[n]/orbit/*

## Orbits
	./orbit/f/cL
	./orbit/f/cL/o/saved
	./orbit/f/orbit/f/cL/o/saved #Recursive!!
---------------------------------------------
	./orbit/s/*
	./orbit/f/*

## Planet
    ./Plnt[7]/market/commDirectory/entries/CommDirectoryEntry[1]/entryData/stats/fleet/dL/RouteManager/r/RouteData[49]/e/RtSeg[2]/t/cL/con/systems/Sstm[4]/@bN
	./Plnt[2]/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved
---------------------------------------------
    ./Plnt[n]/market/*

## CCEnt
    ./CCEnt[2]/market/economy/stepper/econ/markets/Market[2]/primaryEntity/orbit/f/cL/o/saved
    ./CCEnt[4]/market/commDirectory/entries/CommDirectoryEntry[5]/entryData/m/d/e[4]/OfficerManagerEvent/available/AvailableOfficer[3]/person/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved
    ./CCEnt[1]/market/commDirectory/entries/CommDirectoryEntry[4]/entryData/m/d/e[3]/OfficerManagerEvent/available/AvailableOfficer[2]/person/market/primaryEntity/orbit/f/orbit/f/cL/o/saved
    ./CCEnt[4]/market/immigrationModifiers/ColonyMngr/npcConstructionQueues/e[1]/Market/primaryEntity/orbit/f/cL/o/saved
    ./CCEnt[5]/me/d/e[4]/kentington.diyplanets.GenesisStationIntel/event/shownAt/primaryEntity/orbit/f/orbit/f/cL/o/saved
---------------------------------------------
    ./CCEnt[n]/market/*
    ./CCEnt[n]/me/*

## Fleet
    ./Flt[3]/dL/RouteManager/r/RouteData[185]/m/primaryEntity/orbit/f/cL
    ./Flt[1]/sc/MissionFleetAutoDespawn/mission/triggers/MissionTrigger/actions/com.fs.starfarer.api.impl.campaign.missions.hub.HubMissionWithTriggers_-SetMemoryValueAction/memory/d/e[33]/WarSimScript/queue/Sstm[22]/con/systems/Sstm[1]/o/saved
---------------------------------------------
    ./Flt[n]/dL/*
    ./Flt[n]/sc/*

## `dL`
	./dL/RouteManager/r/RouteData[49]/e/RtSeg[2]/t/cL/con/systems/Sstm[4]/@bN
    ./dL/RouteManager/r/RouteData[185]/m/primaryEntity/orbit/f/cL
---------------------------------------------
	./dL/RouteManager/r/RouteData[n]/*

## RouteData
	./RouteData[49]/e/RtSeg[2]/t/cL/con/systems/Sstm[4]/@bN
    ./RouteData[185]/m/primaryEntity/orbit/f/cL
---------------------------------------------
	./RouteData[n]/e/*
    ./RouteData[n]/m/*

## `f`
    ./f/cL
    ./f/cL/o/saved
	./f/orbit/f/cL/o/saved #Recursive!!
---------------------------------------------
    ./f/cL
	./f/orbit/*

## OfficerManagerEvent
    ./OfficerManagerEvent/available/AvailableOfficer[3]/person/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved
    ./OfficerManagerEvent/available/AvailableOfficer[2]/person/market/primaryEntity/orbit/f/orbit/f/cL/o/saved
---------------------------------------------
    ./OfficerManagerEvent/available/AvailableOfficer[n]/person/market/*

## person
    ./person/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved
    ./person/market/primaryEntity/orbit/f/orbit/f/cL/o/saved
---------------------------------------------
    ./person/market/*

## market
    /market/economy/
    /market/commDirectory/entries/CommDirectoryEntry[n]/entryData/*
	/market/immigrationModifiers/ColonyMngr/npcConstructionQueues/e[1]/Market/primaryEntity/orbit/f/cL/o/saved
	/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved
    /market/primaryEntity/orbit/f/orbit/f/cL/o/saved
---------------------------------------------
    /market/economy/
    /market/commDirectory/entries/CommDirectoryEntry[n]/entryData/*
	/market/immigrationModifiers/ColonyMngr/npcConstructionQueues/e[1]/Market/primaryEntity/orbit/f/cL/o/saved
	/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved
    /market/primaryEntity/orbit/f/orbit/f/cL/o/saved

## Entry (`e`)
	./e[n]/OfficerManagerEvent/
	./e[n]/Market/primaryEntity/orbit/f/cL/o/saved
    ./e[n]/kentington.diyplanets.GenesisStationIntel/event/shownAt/primaryEntity/orbit/f/orbit/f/cL/o/saved
    ./e[n]/WarSimScript/queue/Sstm[22]/con/systems/Sstm[1]/o/saved
    ./e/RtSeg[2]/t/cL/con/systems/Sstm[4]/@bN
---------------------------------------------
	./e[n]/Market/primaryEntity/orbit/f/cL/o/saved
    ./e[n]/kentington.diyplanets.GenesisStationIntel/event/shownAt/primaryEntity/orbit/f/orbit/f/cL/o/saved
    ./e[n]/WarSimScript/queue/Sstm[22]/con/systems/Sstm[1]/o/saved
    ./e/RtSeg[2]/t/cL/con/systems/Sstm[4]/@bN

## `t`
    ./e/RtSeg[2]/t/cL/con/systems/Sstm[4]/@bN
---------------------------------------------
    ./t/cL/*

## RtSeg
    ./RtSeg[2]/t/cL/con/systems/Sstm[4]/@bN
---------------------------------------------
	./RtSeg[n]/t/*

## Script (`sc`)
    ./sc/MissionFleetAutoDespawn/mission/triggers/MissionTrigger/actions/com.fs.starfarer.api.impl.campaign.missions.hub.HubMissionWithTriggers_-SetMemoryValueAction/memory/d/e[33]/WarSimScript/queue/Sstm[22]/con/systems/Sstm[1]/o/saved
---------------------------------------------
    ./sc/MissionFleetAutoDespawn/mission/triggers/MissionTrigger/actions/com.fs.starfarer.api.impl.campaign.missions.hub.HubMissionWithTriggers_-SetMemoryValueAction/memory/d/e[n]/*

## economy
    ./economy/stepper/econ/markets/Market[2]/primaryEntity/orbit/f/cL/o/saved
---------------------------------------------
    ./economy/stepper/econ/markets/Market[n]/*

## commDirectory
    ./commDirectory/entries/CommDirectoryEntry[n]/entryData/*
---------------------------------------------
    ./commDirectory/entries/CommDirectoryEntry[n]/entryData/*

## immigrationModifiers
    ./immigrationModifiers/ColonyMngr/npcConstructionQueues/e[1]/Market/primaryEntity/orbit/f/cL/o/saved
---------------------------------------------
    ./immigrationModifiers/ColonyMngr/npcConstructionQueues/e[n]/*

## industries
	./industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved

## primaryEntity
    ./primaryEntity/orbit/f/orbit/f/cL/o/saved

## kentington.diyplanets.GenesisStationIntel
    ./kentington.diyplanets.GenesisStationIntel/event/shownAt/primaryEntity/orbit/f/orbit/f/cL/o/saved

## WarSimScript
    ./WarSimScript/queue/Sstm[22]/con/systems/Sstm[1]/o/saved

## `cL`
    ./cL
	./cL/o/saved
    ./cL/con/systems/Sstm[4]/@bN
---------------------------------------------
    ./cL
	./cL/o/saved/*
    ./cL/con/*



# Readers
- [X] ./o/saved/*
- [X] ./orbit/*
- [X] ./LocationToken/*
- [X] ./Plnt/*
- [X] ./CCEnt/*
- [X] ./Flt/*
- [X] ./dL/*
- [X] ./RouteData/*
- [X] ./f/*
- [X] ./OfficerManagerEvent/*
- [X] ./person/*
- [X] ./market/*
    - [X] ./Market/* (implied? looks like the same class, with a different casing)
- [X] ./e/*
- [X] ./t/*
- [X] ./RtSeg/*
- [X] ./sc/*
- [X] ./economy/*
- [X] ./commDirectory/*
- [X] ./immigrationModifiers/*
- [ ] ./industries/*
- [ ] ./primaryEntity/*
- [ ] ./kentington.diyplanets.GenesisStationIntel/*
- [ ] ./WarSimScript/*
- [ ] ./entryData/*
- [ ] ./cL