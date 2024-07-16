```
<cL cl="Sstm" [...]
```
this seems to be the type I want, BUT it is nested and backwards :-/
like... markets contain references to systems, not the other way around

Searching for Corvus system: Find the system in the systems XML node. search for its ID: 

This one: contains the System name
`/CampaignEngine/hyperspace/o/saved/LocationToken[1]/orbit/s/o/saved/CCEnt[2]/market/economy/stepper/econ/markets/Market[2]/primaryEntity/orbit/f/cL/o/saved/CCEnt[4]/market/commDirectory/entries/CommDirectoryEntry[5]/entryData/m/d/e[4]/OfficerManagerEvent/available/AvailableOfficer[3]/person/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved/Flt[3]/dL/RouteManager/r/RouteData[185]/m/primaryEntity/orbit/f/cL`
Name:
`/CampaignEngine/hyperspace/o/saved/LocationToken[1]/orbit/s/o/saved/CCEnt[2]/market/economy/stepper/econ/markets/Market[2]/primaryEntity/orbit/f/cL/o/saved/CCEnt[4]/market/commDirectory/entries/CommDirectoryEntry[5]/entryData/m/d/e[4]/OfficerManagerEvent/available/AvailableOfficer[3]/person/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved/Flt[3]/dL/RouteManager/r/RouteData[185]/m/primaryEntity/orbit/f/cL/@bN`
this SEEMS to contain the whole system info:
`/CampaignEngine/hyperspace/o/saved/LocationToken[1]/orbit/s/o/saved/CCEnt[2]/market/economy/stepper/econ/markets/Market[2]/primaryEntity/orbit/f/cL/o/saved/CCEnt[4]/market/commDirectory/entries/CommDirectoryEntry[5]/entryData/m/d/e[4]/OfficerManagerEvent/available/AvailableOfficer[3]/person/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved/Flt[3]/dL/RouteManager/r/RouteData[185]/m/primaryEntity/orbit/f/cL/o/saved`

`/CampaignEngine/hyperspace/o/saved/LocationToken[1]/orbit/s/o/saved/CCEnt[2]/market/economy/stepper/econ/markets/Market[2]/primaryEntity/orbit/f/cL/o/saved/CCEnt[4]/market/commDirectory/entries/CommDirectoryEntry[5]/entryData/m/d/e[4]/OfficerManagerEvent/available/AvailableOfficer[3]/person/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved/Flt[3]/dL/RouteManager/r/RouteData[185]/m/primaryEntity/orbit/f/cL/o/saved/CampaignTerrain[1]/cL/@ref`

...
a bunch of hits to random objects (navs, planets, stations, etc)
...

Gate:
`/CampaignEngine/hyperspace/o/saved/LocationToken[1]/orbit/s/o/saved/CCEnt[2]/market/economy/stepper/econ/markets/Market[2]/primaryEntity/orbit/f/cL/o/saved/CCEnt[4]/market/commDirectory/entries/CommDirectoryEntry[5]/entryData/m/d/e[4]/OfficerManagerEvent/available/AvailableOfficer[3]/person/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved/Flt[3]/dL/RouteManager/r/RouteData[185]/m/primaryEntity/orbit/f/cL/o/saved/CCEnt[6]/p/@cl`


Random stuff:
`/CampaignEngine/hyperspace/o/saved/LocationToken[1]/orbit/s/o/saved/CCEnt[2]/market/economy/stepper/econ/markets/Market[2]/primaryEntity/orbit/f/cL/o/saved/CCEnt[4]/market/commDirectory/entries/CommDirectoryEntry[5]/entryData/m/d/e[4]/OfficerManagerEvent/available/AvailableOfficer[3]/person/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved/Flt[3]/dL/RouteManager/r/RouteData[185]/m/primaryEntity/orbit/f/cL/o/saved/JumpPoint[2]/cL/@ref`



Another system in another game:
`/CampaignEngine/hyperspace/o/saved/LocationToken[1]/orbit/s/o/saved/CCEnt[2]/market/economy/stepper/econ/markets/Market[2]/primaryEntity/orbit/f/cL/o/saved/CCEnt[4]/market/immigrationModifiers/ColonyMngr/npcConstructionQueues/e[1]/Market/primaryEntity/orbit/f/cL/o/saved/CCEnt[1]/market/commDirectory/entries/CommDirectoryEntry[4]/entryData/m/d/e[3]/OfficerManagerEvent/available/AvailableOfficer[2]/person/market/primaryEntity/orbit/f/orbit/f/cL/o/saved/Plnt[2]/market/industries/boggled.campaign.econ.industries.Boggled__Cryosanctum/thisIndustry/ctx/fleet/cL/o/saved/Flt[1]/sc/MissionFleetAutoDespawn/mission/triggers/MissionTrigger/actions/com.fs.starfarer.api.impl.campaign.missions.hub.HubMissionWithTriggers_-SetMemoryValueAction/memory/d/e[33]/WarSimScript/queue/Sstm[22]/con/systems/Sstm[1]/o/saved/CCEnt[5]/me/d/e[4]/kentington.diyplanets.GenesisStationIntel/event/shownAt/primaryEntity/orbit/f/orbit/f/cL/o/saved/Plnt[7]/market/commDirectory/entries/CommDirectoryEntry[1]/entryData/stats/fleet/dL/RouteManager/r/RouteData[49]/e/RtSeg[2]/t/cL/con/systems/Sstm[4]/@bN`


# Notes on `/CampaignEngine/hyperspace/o/saved/`:
The `LocationToken` seem to refer to systems, or rather maps. I suspect that "66" is the hyperspace map.
Furthermore, I suspect that Starsector loads reference data in like a hashset, and whenever it encounters a ref it just populates it. Also with like an isDirty flag,
so when SAVING the data, it just dumps everything at the first reference of the reference in the model, which is a SHIT SOLUTION

Also weird is how the objects in saved are just dumped in this array of multiple types just mixed together.