Star (Corvus)

Seems to be a PLNT type or tag
```
<* cl="Plnt" z="318495">
	<j0>{"f6":0,"f0":"Labyrinth","f2":[255,210,200,255],"f4":"askonia:planet_6"}</j0>
	<tags z="318505">
		<st>planet</st>
	</tags>
	<orbit cl="COrbt" z="318498" r="11850.936" op="504.05246" ca="250.66376">
		<e cl="Plnt" ref="318495"/> <!-- self -->
		<f cl="Plnt" ref="2809"/>	<!-- star -->
	</orbit>
</*>
```


Planet XML:
```
<primaryEntity cl="Plnt" z="467987">
	<loc z="467988">0.0|0.0</loc>
	<vel z="467989">0.0|0.0</vel>
	<j0>{"f6":0,"f0":"Perseus 2C8A-A05P","f2":[100,100,100,255],"f4":"514594:planet_0"}</j0>
	<ow z="467990">
		<id>neutral</id>
		<memory z="467991">
			<d z="467992">
				<e>
					<st>$id</st>
					<st>neutral</st>
				</e>
				<e>
					<st>$neutralToPlayer</st>
					<bp>true</bp>
				</e>
				<e>
					<st>$isHostile</st>
					<bp>false</bp>
				</e>
				<e>
					<st>$c:starshipLegendsConfig</st>
					<st>{"allowFamousDerelictBarEvent":"false","forcedPreset":{"defaultNumberOfTraits":"0"},"allowFamousFlagshipsInFleets":"false","useCrewlessTraitNames":"true","descriptionOverride":"Nothing is known about this fleet.","allowFamousFlagshipBarEvent":"false"}</st>
				</e>
				<e>
					<st>$color</st>
					<st>100,100,100,255</st>
				</e>
				<e>
					<st>$baseColor</st>
					<st>155,155,155,255</st>
				</e>
				<e>
					<st>$brightColor</st>
					<st>171,186,190,255</st>
				</e>
				<e>
					<st>$darkColor</st>
					<st>40,40,40,175</st>
				</e>
				<e>
					<st>$gridColor</st>
					<st>100,100,100,75</st>
				</e>
				<e>
					<st>$isNeutralFaction</st>
					<bp>true</bp>
				</e>
				<e>
					<st>$relValue</st>
					<fp>0.0</fp>
				</e>
				<e>
					<st>$rel</st>
					<st>NEUTRAL</st>
				</e>
				<e>
					<st>$relName</st>
					<st>NEUTRAL</st>
				</e>
				<e>
					<st>$theFaction</st>
					<st>Neutral</st>
				</e>
				<e>
					<st>$warWeariness</st>
					<fp>0.0</fp>
				</e>
				<e>
					<st>$numWars</st>
					<ip>0</ip>
				</e>
				<e>
					<st>$isInAlliance</st>
					<bp>false</bp>
				</e>
			</d>
			<e z="467993">
				<MExp z="467994" k="$id" t="0.0"/>
				<MExp z="467995" k="$neutralToPlayer" t="0.0"/>
				<MExp z="467996" k="$isHostile" t="0.0"/>
				<MExp z="467997" k="$c:starshipLegendsConfig" t="0.0"/>
				<MExp z="467998" k="$color" t="0.0"/>
				<MExp z="467999" k="$baseColor" t="0.0"/>
				<MExp z="468000" k="$brightColor" t="0.0"/>
				<MExp z="468001" k="$darkColor" t="0.0"/>
				<MExp z="468002" k="$gridColor" t="0.0"/>
				<MExp z="468003" k="$isNeutralFaction" t="0.0"/>
				<MExp z="468004" k="$relValue" t="0.0"/>
				<MExp z="468005" k="$rel" t="0.0"/>
				<MExp z="468006" k="$relName" t="0.0"/>
				<MExp z="468007" k="$theFaction" t="0.0"/>
				<MExp z="468008" k="$warWeariness" t="0.0"/>
				<MExp z="468009" k="$numWars" t="0.0"/>
				<MExp z="468010" k="$isInAlliance" t="0.0"/>
			</e>
		</memory>
		<illegal z="468011"/>
		<shipsWhenImporting z="468012"/>
		<knownShips z="468013"/>
		<knownWeapons z="468014"/>
		<knownFighters z="468015"/>
		<knownIndustries z="468016"/>
		<knownHullMods z="468017"/>
		<priorityShips z="468018"/>
		<priorityWeapons z="468019"/>
		<priorityFighters z="468020"/>
		<priorityHullMods z="468021"/>
		<hullFrequency cl="l-h-m" z="468022"/>
		<variantOverrides cl="l-h-m" z="468023"/>
		<overriddenHulls z="468024"/>
		<doctrine z="468025">
			<warships>4</warships>
			<carriers>2</carriers>
			<phaseShips>1</phaseShips>
			<officerQuality>2</officerQuality>
			<shipQuality>3</shipQuality>
			<numShips>2</numShips>
			<shipSize>3</shipSize>
			<aggression>3</aggression>
			<fleets>3</fleets>
			<autofitRandomizeProbability>0.0</autofitRandomizeProbability>
			<combatFreighterProbability>0.0</combatFreighterProbability>
			<combatFreighterCombatUseFraction>0.0</combatFreighterCombatUseFraction>
			<combatFreighterCombatUseFractionWhenPriority>0.0</combatFreighterCombatUseFractionWhenPriority>
			<commanderSkillsShuffleProbability>0.0</commanderSkillsShuffleProbability>
			<strictComposition>false</strictComposition>
			<commanderSkills z="468026"/>
			<officerSkillsShuffleProbability>0.0</officerSkillsShuffleProbability>
			<officerSkills z="468027"/>
		</doctrine>
		<production z="468028">
			<interrupted z="468029"/>
			<current z="468030"/>
			<faction cl="Faction" ref="467990"/>
			<accruedProduction>0</accruedProduction>
			<costMult>1.0</costMult>
		</production>
		<weaponTimestamps cl="l-h-m" z="468031"/>
		<fighterTimestamps cl="l-h-m" z="468032"/>
		<shipTimestamps cl="l-h-m" z="468033"/>
		<showInIntelTabOverridden>false</showInIntelTabOverridden>
		<isShowInIntelTab>false</isShowInIntelTab>
		<autoEnableKnownShips>false</autoEnableKnownShips>
		<autoEnableKnownWeapons>false</autoEnableKnownWeapons>
		<autoEnableKnownFighters>false</autoEnableKnownFighters>
		<autoEnableKnownHullmods>false</autoEnableKnownHullmods>
		<secondaryColorSegmentsOverride>0</secondaryColorSegmentsOverride>
	</ow>
	<cL cl="Sstm" z="468034" dN="Deep Space" bTF="graphics/backgrounds/background5.jpg" hM="false" lPV="-55515648569000" ty="DEEP_SPACE" pg="true" bN="Deep Space" mRIH="28.905685" eBP="true">
		<o z="468035">
			<lists z="468036"/>
			<maps z="468037"/>
			<classifier cl="FastIterationClassifier" z="468038">
				<cache z="468039"/>
			</classifier>
			<nextId>0</nextId>
			<forFastContains z="468040"/>
			<saved z="468041">
				<LocationToken z="468042">
					<loc z="468043">0.0|0.0</loc>
					<where cl="Sstm" ref="468034"/>
					<id>514594</id>
					<faction ref="13"/>
					<tags z="468044">
						<st>ambient_ls</st>
					</tags>
				</LocationToken>
				<Plnt ref="467987"/>
				<CCEnt z="468045" fL="TERRAIN_1">
					<loc z="468046">0.0|0.0</loc>
					<vel z="468047">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"","f2":[100,100,100,255],"f4":"luna_campaign_renderer_51459f"}</j0>
					<ow ref="13"/>
					<cL cl="Sstm" ref="468034"/>
					<ls cl="LocationToken" ref="468042"/>
					<me z="468048">
						<d z="468049"/>
					</me>
					<sc z="468050"/>
					<j1>{"f0":64,"f1":64,"f2":0,"f3":-1,"f4":-1,"f5":"luna_campaign_renderer"}</j1>
					<la z="468051" enum-type="CaEnLa">TERRAIN_1,TERRAIN_2,PLANETS,TERRAIN_3,RINGS,TERRAIN_4,ASTEROIDS,TERRAIN_5,JUMP_POINTS,TERRAIN_6,TERRAIN_6A,TERRAIN_6B,BELOW_STATIONS,STATIONS,ABOVE_STATIONS,TERRAIN_7,TERRAIN_7A,TERRAIN_SLIPSTREAM,FLEETS,TERRAIN_8,TERRAIN_9,TERRAIN_10,ABOVE</la>
					<p cl="lunalib.backend.scripts.LunaCampaignRendererEntity" z="468052">
						<e cl="CCEnt" ref="468045"/>
					</p>
				</CCEnt>
			</saved>
		</o>
		<b z="468053" hM="false">
			<bgO z="468054">657.9437|150.89764</bgO>
			<s z="468055" o="graphics/backgrounds/background4.jpg" t="graphics/backgrounds/background5.jpg">
				<d cl="BackgroundAndStars" ref="468053"/>
			</s>
			<colorShifter z="468056">
				<b ref="4164"/>
				<c ref="4164"/>
				<d cl="l-h-m" z="468057"/>
			</colorShifter>
			<particleColorShifter z="468058">
				<b z="468059">191,191,191,200</b>
				<c ref="468059"/>
				<d cl="l-h-m" z="468060"/>
			</particleColorShifter>
			<wasShifted>false</wasShifted>
		</b>
		<hP z="468061" d="1.0" nF="1" lp="false" r="false" e="0.0" pr="0.0" cF="0" cL="0" sN="false" l="2000">
			<p z="468062"/>
		</hP>
		<l z="468063">-64549.805|-42204.47</l>
		<lC z="468064">100,100,100,255</lC>
		<lH z="468065" b="0.68560004" i="10.0" o="10.0" s="IN" d="true" u="true"/>
		<fS z="468066"/>
		<pDat z="468067"/>
		<sPts z="468068"/>
		<scr z="468069"/>
		<activeThisFrame>true</activeThisFrame>
		<tags z="468070">
			<st>theme_special</st>
			<st>system_abyssal</st>
			<st>theme_hidden</st>
			<st>temporary_location</st>
		</tags>
		<memory z="468071">
			<d z="468072">
				<e>
					<st>$IndEvo_locatorSystemRating</st>
					<ip>0</ip>
				</e>
			</d>
		</memory>
		<optionalUniqueId>514593</optionalUniqueId>
		<ce cl="LocationToken" ref="468042"/>
		<hA cl="LocationToken" z="468073">
			<loc z="468074">-64549.805|-42204.47</loc>
			<where cl="Hyperspace" ref="2"/>
			<orbit cl="UFHLOrbt" z="468075">
				<s cl="Sstm" ref="468034"/>
				<a cl="LocationToken" ref="468073"/>
			</orbit>
			<id>51459c</id>
			<faction ref="13"/>
			<tags z="468076">
				<st>system_anchor</st>
			</tags>
			<memory z="468077">
				<d z="468078">
					<e>
						<st>$anchor_starSystem</st>
						<Sstm ref="468034"/>
					</e>
				</d>
			</memory>
		</hA>
	</cL>
	<ls cl="LocationToken" ref="468042"/>
	<me z="468079">
		<d z="468080">
			<e>
				<st>$salvageSeed</st>
				<Lp>-2341519222508495824</Lp>
			</e>
		</d>
	</me>
	<market cl="PCMarket" z="468081">
		<id>market_514594:planet_0</id>
		<name>Perseus 2C8A-A05P</name>
		<primaryEntity cl="Plnt" ref="467987"/>
		<memory cl="Memory" z="468082">
			<d z="468083">
				<e>
					<st>$visitedBefore</st>
					<bp>true</bp>
				</e>
			</d>
		</memory>
		<surveyLevel>FULL</surveyLevel>
		<cond z="468084">
			<st>very_cold</st>
			<st>rare_ore_ultrarich</st>
			<st>dark</st>
			<st>ore_moderate</st>
			<st>high_gravity</st>
			<st>tectonic_activity</st>
			<st>volatiles_plentiful</st>
		</cond>
		<surveyed z="468085">
			<st>very_cold</st>
			<st>rare_ore_ultrarich</st>
			<st>dark</st>
			<st>ore_moderate</st>
			<st>high_gravity</st>
			<st>tectonic_activity</st>
			<st>volatiles_plentiful</st>
		</surveyed>
	</market>
	<sc z="468086"/>
	<tags z="468087">
		<st>planet</st>
	</tags>
	<angle>70.00708</angle>
	<cloudAngle>224.30457</cloudAngle>
	<radius>192.70454</radius>
	<type>cryovolcanic</type>
	<diff z="468088">
		<j>{"atmosphereColor":[155,228,236,90],"tilt":71.93712615966797,"pitch":0.8938810229301453,"planetColor":[229,251,252,255]}</j>
	</diff>
	<layers z="468089" enum-type="CaEnLa">PLANETS,ABOVE</layers>
</primaryEntity>
```

### Labyrinth (In Askonia):
```
<Plnt z="318495">
	<loc z="318496">-3923.978|-11182.444</loc>
	<vel z="318497">0.0|0.0</vel>
	<j0>{"f6":0,"f0":"Labyrinth","f2":[255,210,200,255],"f4":"askonia:planet_6"}</j0>
	<ow ref="91"/>
	<orbit cl="COrbt" z="318498" r="11850.936" op="504.05246" ca="250.66376">
		<e cl="Plnt" ref="318495"/>
		<f cl="Plnt" ref="2809"/>
	</orbit>
	<cL cl="Sstm" ref="2812"/>
	<ls cl="Plnt" ref="2809"/>
	<me z="318499">
		<d z="318500">
			<e>
				<st>$salvageSeed</st>
				<Lp>-817106673732973019</Lp>
			</e>
		</d>
	</me>
	<market cl="PCMarket" z="318501">
		<id>market_askonia:planet_6</id>
		<name>Labyrinth</name>
		<primaryEntity cl="Plnt" ref="318495"/>
		<surveyLevel>FULL</surveyLevel>
		<cond z="318502">
			<st>no_atmosphere</st>
			<st>cold</st>
			<st>ore_moderate</st>
		</cond>
		<surveyed z="318503">
			<st>no_atmosphere</st>
			<st>cold</st>
			<st>ore_moderate</st>
		</surveyed>
	</market>
	<sc z="318504"/>
	<tags z="318505">
		<st>planet</st>
	</tags>
	<angle>117.79401</angle>
	<cloudAngle>0.0</cloudAngle>
	<radius>100.93519</radius>
	<type>US_burnt</type>
	<diff z="318506">
		<j>{"tilt":15.13033676147461,"pitch":19.050621032714844,"planetColor":[240,234,242,255]}</j>
	</diff>
	<layers z="318507" enum-type="CaEnLa">PLANETS,ABOVE</layers>
</Plnt>
```


### Sindria
```
<Plnt z="2842">
	<loc z="2843">1461.0974|2505.0337</loc>
	<vel z="2844">0.0|0.0</vel>
	<j0>{"f6":0,"f0":"Sindria","f2":[255,210,200,255],"f3":"planet_sindria","f4":"sindria"}</j0>
	<ow ref="2762"/>
	<orbit cl="COrbt" z="2845" r="2900.0" op="100.0" ca="59.74652">
		<e cl="Plnt" ref="2842"/>
		<f cl="Plnt" ref="2809"/>
	</orbit>
	<cL cl="Sstm" ref="2812"/>
	<ls cl="Plnt" ref="2809"/>
	<me z="2846">
		<d z="2847">
			<e>
				<st>$salvageSeed</st>
				<Lp>2757229567845719937</Lp>
			</e>
			<e>
				<st>$IndEvo_ArtilleryStationScript</st>
				<indevo.industries.artillery.scripts.ArtilleryStationScript z="2848">
					<isDestroyed>true</isDestroyed>
					<isDiscoverable>true</isDiscoverable>
					<primaryEntity cl="Plnt" ref="2842"/>
				</indevo.industries.artillery.scripts.ArtilleryStationScript>
			</e>
		</d>
	</me>
	<market cl="Market" z="2849">
		<id>sindria</id>
		<name>Sindria</name>
		<commodities z="2850">
			<COMkt z="2851" c="supplies" sto="8045.7827" mS="7" iSL="true" mD="8" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="2852" b="0.0" m="1508.0554">
					<fMs z="2853" s="core" v="1508.0554"/>
				</g>
				<d z="2854" dC="supplies">
					<d z="2855" b="0.0" m="4524.166">
						<fMs z="2856" s="core" v="4524.166"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="2857" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="2858" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="2859" b="0.0" m="8.0">
					<fMs z="2860" s="core_local" d="Local production" v="7.0"/>
					<fMs z="2861" s="core_base" d="Desired import volume" v="1.0"/>
				</available>
				<tradeMod z="2862" b="0.0" m="0.0"/>
				<tradeModPlus z="2863" b="0.0" m="0.0"/>
				<tradeModMinus z="2864" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="2865" c="fuel" sto="23264.035" mS="10" iSL="true" mD="8" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="2866" b="0.0" m="3631.6614">
					<fMs z="2867" s="core" v="3631.6614"/>
				</g>
				<d z="2868" dC="fuel">
					<d z="2869" b="0.0" m="10894.984">
						<fMs z="2870" s="core" v="10894.984"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="2871" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="2872" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="2873" b="0.0" m="10.0">
					<fMs z="2874" s="core_local" d="Local production" v="10.0"/>
				</available>
				<tradeMod z="2875" b="0.0" m="0.0"/>
				<tradeModPlus z="2876" b="0.0" m="-13757.0">
					<fMs z="2877" s="buy_bc7949" v="-5727.0"/>
					<fMs z="2878" s="buy_bc7b0e" v="-6514.0"/>
					<fMs z="2879" s="buy_bc7cdf" v="-1516.0"/>
					<tM z="2880">
						<e>
							<st>buy_bc7949</st>
							<WTMTSM z="2881" tR="119.93904" s="buy_bc7949"/>
						</e>
						<e>
							<st>buy_bc7b0e</st>
							<WTMTSM z="2882" tR="119.93904" s="buy_bc7b0e"/>
						</e>
						<e>
							<st>buy_bc7cdf</st>
							<WTMTSM z="2883" tR="119.93904" s="buy_bc7cdf"/>
						</e>
					</tM>
				</tradeModPlus>
				<tradeModMinus z="2884" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="2885" c="crew" sto="6772.347" mS="9" iSL="true" mD="7" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="2886" b="0.0" m="1164.9119">
					<fMs z="2887" s="core" v="1164.9119"/>
				</g>
				<d z="2888" dC="crew">
					<d z="2889" b="0.0" m="3494.7356">
						<fMs z="2890" s="core" v="3494.7356"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="2891" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="2892" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="2893" b="0.0" m="9.0">
					<fMs z="2894" s="core_local" d="Local production" v="9.0"/>
				</available>
				<tradeMod z="2895" b="0.0" m="0.0"/>
				<tradeModPlus z="2896" b="0.0" m="0.0"/>
				<tradeModMinus z="2897" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="2898" c="marines" sto="1194.2269" mS="8" iSL="true" mD="7" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="2899" b="0.0" m="246.28674">
					<fMs z="2900" s="core" v="246.28674"/>
				</g>
				<d z="2901" dC="marines">
					<d z="2902" b="0.0" m="738.8602">
						<fMs z="2903" s="core" v="738.8602"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="2904" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="2905" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="2906" b="0.0" m="8.0">
					<fMs z="2907" s="core_local" d="Local production" v="8.0"/>
				</available>
				<tradeMod z="2908" b="0.0" m="0.0"/>
				<tradeModPlus z="2909" b="0.0" m="0.0"/>
				<tradeModMinus z="2910" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="2911" c="food" sto="15841.461" mS="0" iSL="true" mD="8" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="2912" b="0.0" m="4143.9824">
					<fMs z="2913" s="core" v="4143.9824"/>
				</g>
				<d z="2914" dC="food">
					<d z="2915" b="0.0" m="12431.947">
						<fMs z="2916" s="core" v="12431.947"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="2917" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="2918" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="2919" b="0.0" m="8.0">
					<fMs z="2920" s="core_base" d="Desired import volume (in-faction)" v="8.0"/>
				</available>
				<tradeMod z="2921" b="0.0" m="0.0"/>
				<tradeModPlus z="2922" b="0.0" m="0.0"/>
				<tradeModMinus z="2923" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="2924" c="organics" sto="9297.9" mS="0" iSL="true" mD="6" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="2925" b="0.0" m="2372.1882">
					<fMs z="2926" s="core" v="2372.1882"/>
				</g>
				<d z="2927" dC="organics">
					<d z="2928" b="0.0" m="7116.5645">
						<fMs z="2929" s="core" v="7116.5645"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="2930" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="2931" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="2932" b="0.0" m="6.0">
					<fMs z="2933" s="core_base" d="Desired import volume (in-faction)" v="6.0"/>
				</available>
				<tradeMod z="2934" b="0.0" m="0.0"/>
				<tradeModPlus z="2935" b="0.0" m="0.0"/>
				<tradeModMinus z="2936" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="2937" c="volatiles" sto="1336.8511" mS="0" iSL="true" mD="7" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="2938" b="0.0" m="381.43362">
					<fMs z="2939" s="core" v="381.43362"/>
				</g>
				<d z="2940" dC="volatiles">
					<d z="2941" b="0.0" m="1144.3009">
						<fMs z="2942" s="core" v="1144.3009"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="2943" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="2944" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="2945" b="0.0" m="7.0">
					<fMs z="2946" s="core_base" d="Desired import volume (in-faction)" v="7.0"/>
				</available>
				<tradeMod z="2947" b="0.0" m="0.0"/>
				<tradeModPlus z="2948" b="0.0" m="0.0"/>
				<tradeModMinus z="2949" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="2950" c="ore" sto="43644.066" mS="0" iSL="true" mD="9" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="2951" b="0.0" m="10844.499">
					<fMs z="2952" s="core" v="10844.499"/>
				</g>
				<d z="2953" dC="ore">
					<d z="2954" b="0.0" m="32533.496">
						<fMs z="2955" s="core" v="32533.496"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="2956" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="2957" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="2958" b="0.0" m="9.0">
					<fMs z="2959" s="core_base" d="Desired import volume (in-faction)" v="9.0"/>
				</available>
				<tradeMod z="2960" b="0.0" m="0.0"/>
				<tradeModPlus z="2961" b="0.0" m="0.0"/>
				<tradeModMinus z="2962" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="2963" c="rare_ore" sto="3534.5833" mS="0" iSL="true" mD="7" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="2964" b="0.0" m="951.5547">
					<fMs z="2965" s="core" v="951.5547"/>
				</g>
				<d z="2966" dC="rare_ore">
					<d z="2967" b="0.0" m="2854.664">
						<fMs z="2968" s="core" v="2854.664"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="2969" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="2970" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="2971" b="0.0" m="7.0">
					<fMs z="2972" s="core_base" d="Desired import volume (in-faction)" v="7.0"/>
				</available>
				<tradeMod z="2973" b="0.0" m="0.0"/>
				<tradeModPlus z="2974" b="0.0" m="0.0"/>
				<tradeModMinus z="2975" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="2976" c="metals" sto="23083.98" mS="8" iSL="true" mD="7" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="2977" b="0.0" m="3939.7498">
					<fMs z="2978" s="core" v="3939.7498"/>
				</g>
				<d z="2979" dC="metals">
					<d z="2980" b="0.0" m="11819.249">
						<fMs z="2981" s="core" v="11819.249"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="2982" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="2983" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="2984" b="0.0" m="8.0">
					<fMs z="2985" s="core_local" d="Local production" v="8.0"/>
				</available>
				<tradeMod z="2986" b="0.0" m="0.0"/>
				<tradeModPlus z="2987" b="0.0" m="0.0"/>
				<tradeModMinus z="2988" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="2989" c="rare_metals" sto="1744.8934" mS="6" iSL="true" mD="5" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="2990" b="0.0" m="348.37955">
					<fMs z="2991" s="core" v="348.37955"/>
				</g>
				<d z="2992" dC="rare_metals">
					<d z="2993" b="0.0" m="1045.1387">
						<fMs z="2994" s="core" v="1045.1387"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="2995" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="2996" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="2997" b="0.0" m="6.0">
					<fMs z="2998" s="core_local" d="Local production" v="6.0"/>
				</available>
				<tradeMod z="2999" b="0.0" m="0.0"/>
				<tradeModPlus z="3000" b="0.0" m="0.0"/>
				<tradeModMinus z="3001" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3002" c="heavy_machinery" sto="2809.1108" mS="7" iSL="true" mD="5" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3003" b="0.0" m="597.9095">
					<fMs z="3004" s="core" v="597.9095"/>
				</g>
				<d z="3005" dC="heavy_machinery">
					<d z="3006" b="0.0" m="1793.7285">
						<fMs z="3007" s="core" v="1793.7285"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3008" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="3009" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3010" b="0.0" m="7.0">
					<fMs z="3011" s="core_local" d="Local production" v="7.0"/>
				</available>
				<tradeMod z="3012" b="0.0" m="0.0"/>
				<tradeModPlus z="3013" b="0.0" m="0.0"/>
				<tradeModMinus z="3014" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3015" c="domestic_goods" sto="6172.5557" mS="0" iSL="true" mD="6" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3016" b="0.0" m="1623.008">
					<fMs z="3017" s="core" v="1623.008"/>
				</g>
				<d z="3018" dC="domestic_goods">
					<d z="3019" b="0.0" m="4869.0244">
						<fMs z="3020" s="core" v="4869.0244"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3021" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="3022" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3023" b="0.0" m="6.0">
					<fMs z="3024" s="core_base" d="Desired import volume (in-faction)" v="6.0"/>
				</available>
				<tradeMod z="3025" b="0.0" m="0.0"/>
				<tradeModPlus z="3026" b="0.0" m="0.0"/>
				<tradeModMinus z="3027" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3028" c="organs" sto="1185.9484" mS="3" iSL="false" mD="4" iDL="false" eU="0.0">
				<m ref="2849"/>
				<g z="3029" b="0.0" m="241.74261">
					<fMs z="3030" s="core" v="241.74261"/>
				</g>
				<d z="3031" dC="organs">
					<d z="3032" b="0.0" m="725.22784">
						<fMs z="3033" s="core" v="725.22784"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3034" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="3035" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3036" b="0.0" m="4.0">
					<fMs z="3037" s="core_local" d="Local production" v="3.0"/>
					<fMs z="3038" s="core_base" d="Desired smuggling volume" v="1.0"/>
				</available>
				<tradeMod z="3039" b="0.0" m="0.0"/>
				<tradeModPlus z="3040" b="0.0" m="0.0"/>
				<tradeModMinus z="3041" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3042" c="drugs" sto="3281.1208" mS="4" iSL="false" mD="5" iDL="false" eU="0.0">
				<m ref="2849"/>
				<g z="3043" b="0.0" m="545.58484">
					<fMs z="3044" s="core" v="545.58484"/>
				</g>
				<d z="3045" dC="drugs">
					<d z="3046" b="0.0" m="1636.7545">
						<fMs z="3047" s="core" v="1636.7545"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3048" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="3049" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3050" b="0.0" m="5.0">
					<fMs z="3051" s="core_local" d="Local production" v="4.0"/>
					<fMs z="3052" s="core_base" d="Desired smuggling volume" v="1.0"/>
				</available>
				<tradeMod z="3053" b="0.0" m="0.0"/>
				<tradeModPlus z="3054" b="0.0" m="0.0"/>
				<tradeModMinus z="3055" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3056" c="hand_weapons" sto="1853.6927" mS="7" iSL="true" mD="7" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3057" b="0.0" m="406.65826">
					<fMs z="3058" s="core" v="406.65826"/>
				</g>
				<d z="3059" dC="hand_weapons">
					<d z="3060" b="0.0" m="1219.9749">
						<fMs z="3061" s="core" v="1219.9749"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3062" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="3063" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3064" b="0.0" m="7.0">
					<fMs z="3065" s="core_local" d="Local production" v="7.0"/>
				</available>
				<tradeMod z="3066" b="0.0" m="0.0"/>
				<tradeModPlus z="3067" b="0.0" m="0.0"/>
				<tradeModMinus z="3068" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3069" c="luxury_goods" sto="2037.3752" mS="0" iSL="true" mD="4" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3070" b="0.0" m="533.44147">
					<fMs z="3071" s="core" v="533.44147"/>
				</g>
				<d z="3072" dC="luxury_goods">
					<d z="3073" b="0.0" m="1600.3245">
						<fMs z="3074" s="core" v="1600.3245"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3075" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="3076" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3077" b="0.0" m="4.0">
					<fMs z="3078" s="core_base" d="Desired import volume (in-faction)" v="4.0"/>
				</available>
				<tradeMod z="3079" b="0.0" m="0.0"/>
				<tradeModPlus z="3080" b="0.0" m="0.0"/>
				<tradeModMinus z="3081" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3082" c="ships" sto="2085.8608" mS="7" iSL="true" mD="8" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3083" b="0.0" m="460.16428">
					<fMs z="3084" s="core" v="460.16428"/>
				</g>
				<d z="3085" dC="ships">
					<d z="3086" b="0.0" m="1380.4928">
						<fMs z="3087" s="core" v="1380.4928"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3088" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="3089" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3090" b="0.0" m="8.0">
					<fMs z="3091" s="core_local" d="Local production" v="7.0"/>
					<fMs z="3092" s="core_base" d="Desired import volume" v="1.0"/>
				</available>
				<tradeMod z="3093" b="0.0" m="0.0"/>
				<tradeModPlus z="3094" b="0.0" m="0.0"/>
				<tradeModMinus z="3095" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3096" c="electronics" sto="621.05664" mS="0" iSL="true" mD="3" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3097" b="0.0" m="202.17288">
					<fMs z="3098" s="core" v="202.17288"/>
				</g>
				<d z="3099" dC="electronics">
					<d z="3100" b="0.0" m="606.5187">
						<fMs z="3101" s="core" v="606.5187"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3102" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="3103" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3104" b="0.0" m="3.0">
					<fMs z="3105" s="core_base" d="Desired import volume" v="3.0"/>
				</available>
				<tradeMod z="3106" b="0.0" m="0.0"/>
				<tradeModPlus z="3107" b="0.0" m="0.0"/>
				<tradeModMinus z="3108" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3109" c="water" sto="34676.812" mS="0" iSL="true" mD="7" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3110" b="0.0" m="9052.574">
					<fMs z="3111" s="core" v="9052.574"/>
				</g>
				<d z="3112" dC="water">
					<d z="3113" b="0.0" m="27157.723">
						<fMs z="3114" s="core" v="27157.723"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3115" fB="0.0" m="1.0" pM="0.0" nR="true"/>
				<pSM z="3116" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3117" b="0.0" m="7.0">
					<fMs z="3118" s="core_base" d="Desired import volume (in-faction)" v="7.0"/>
				</available>
				<tradeMod z="3119" b="0.0" m="0.0"/>
				<tradeModPlus z="3120" b="0.0" m="0.0"/>
				<tradeModMinus z="3121" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3122" c="biotics" sto="509.8793" mS="0" iSL="true" mD="5" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3123" b="0.0" m="183.02054">
					<fMs z="3124" s="core" v="183.02054"/>
				</g>
				<d z="3125" dC="biotics">
					<d z="3126" b="0.0" m="549.06165">
						<fMs z="3127" s="core" v="549.06165"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3128" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="3129" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3130" b="0.0" m="5.0">
					<fMs z="3131" s="core_base" d="Desired import volume" v="5.0"/>
				</available>
				<tradeMod z="3132" b="0.0" m="0.0"/>
				<tradeModPlus z="3133" b="0.0" m="0.0"/>
				<tradeModMinus z="3134" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3135" c="recitificates" sto="3106.0889" mS="0" iSL="true" mD="6" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3136" b="0.0" m="816.63086">
					<fMs z="3137" s="core" v="816.63086"/>
				</g>
				<d z="3138" dC="recitificates">
					<d z="3139" b="0.0" m="2449.8926">
						<fMs z="3140" s="core" v="2449.8926"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3141" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="3142" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3143" b="0.0" m="6.0">
					<fMs z="3144" s="core_base" d="Desired import volume" v="6.0"/>
				</available>
				<tradeMod z="3145" b="0.0" m="0.0"/>
				<tradeModPlus z="3146" b="0.0" m="0.0"/>
				<tradeModMinus z="3147" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3148" c="IndEvo_parts" sto="2450.813" mS="4" iSL="true" mD="6" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3149" b="0.0" m="521.2678">
					<fMs z="3150" s="core" v="521.2678"/>
				</g>
				<d z="3151" dC="IndEvo_parts">
					<d z="3152" b="0.0" m="1563.8035">
						<fMs z="3153" s="core" v="1563.8035"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3154" fB="0.0" m="1.0" pM="0.0" nR="true"/>
				<pSM z="3155" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3156" b="0.0" m="6.0">
					<fMs z="3157" s="core_local" d="Local production" v="4.0"/>
					<fMs z="3158" s="core_base" d="Desired import volume" v="2.0"/>
				</available>
				<tradeMod z="3159" b="0.0" m="0.0"/>
				<tradeModPlus z="3160" b="0.0" m="0.0"/>
				<tradeModMinus z="3161" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3162" c="alcoholism_sunshine_c" sto="2412.0474" mS="0" iSL="true" mD="5" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3163" b="0.0" m="657.1165">
					<fMs z="3164" s="core" v="657.1165"/>
				</g>
				<d z="3165" dC="alcoholism_sunshine_c">
					<d z="3166" b="0.0" m="1971.3496">
						<fMs z="3167" s="core" v="1971.3496"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3168" fB="0.0" m="1.0" pM="0.0" nR="true"/>
				<pSM z="3169" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3170" b="0.0" m="5.0">
					<fMs z="3171" s="core_base" d="Desired import volume (in-faction)" v="5.0"/>
				</available>
				<tradeMod z="3172" b="0.0" m="0.0"/>
				<tradeModPlus z="3173" b="0.0" m="0.0"/>
				<tradeModMinus z="3174" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3175" c="alcoholism_tea_c" sto="968.77277" mS="0" iSL="true" mD="2" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3176" b="0.0" m="292.97726">
					<fMs z="3177" s="core" v="292.97726"/>
				</g>
				<d z="3178" dC="alcoholism_tea_c">
					<d z="3179" b="0.0" m="878.93176">
						<fMs z="3180" s="core" v="878.93176"/>
					</d>
					<m ref="2849"/>
				</d>
				<pDM z="3181" fB="0.0" m="1.0" pM="0.0" nR="true"/>
				<pSM z="3182" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3183" b="0.0" m="2.0">
					<fMs z="3184" s="core_base" d="Desired import volume" v="2.0"/>
				</available>
				<tradeMod z="3185" b="0.0" m="0.0"/>
				<tradeModPlus z="3186" b="0.0" m="0.0"/>
				<tradeModMinus z="3187" b="0.0" m="0.0"/>
			</COMkt>
			<COMkt z="3188" c="sotf_planetkiller" sto="0.0" mS="0" iSL="true" mD="7" iDL="true" eU="0.0">
				<m ref="2849"/>
				<g z="3189" b="0.0" m="406.65826">
					<fMs z="3190" s="core" v="406.65826"/>
				</g>
				<d ref="3059"/>
				<pDM z="3191" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<pSM z="3192" fB="0.0" m="1.0" pM="0.0" nR="false"/>
				<available z="3193" b="0.0" m="0.0"/>
				<tradeMod z="3194" b="0.0" m="0.0"/>
				<tradeModPlus z="3195" b="0.0" m="0.0"/>
				<tradeModMinus z="3196" b="0.0" m="0.0"/>
			</COMkt>
		</commodities>
		<demandData z="3197">
			<demand z="3198" dC="polymer">
				<d z="3199" b="0.0" m="517.9093">
					<fMs z="3200" s="core" v="517.9093"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="2966"/>
			<demand ref="3099"/>
			<demand z="3201" dC="alcoholism_water_c">
				<d z="3202" b="0.0" m="699.4623">
					<fMs z="3203" s="core" v="699.4623"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="3178"/>
			<demand ref="3018"/>
			<demand ref="2868"/>
			<demand z="3204" dC="alcoholism_blood_c">
				<d z="3205" b="0.0" m="503.6044">
					<fMs z="3206" s="core" v="503.6044"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand z="3207" dC="ms_hdbatteries">
				<d z="3208" b="0.0" m="225.5788">
					<fMs z="3209" s="core" v="225.5788"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="2979"/>
			<demand ref="3125"/>
			<demand ref="2888"/>
			<demand ref="3059"/>
			<demand z="3210" dC="vic_booze_c">
				<d z="3211" b="0.0" m="306.69476">
					<fMs z="3212" s="core" v="306.69476"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="2854"/>
			<demand z="3213" dC="purified_rare_ore">
				<d z="3214" b="0.0" m="545.7701">
					<fMs z="3215" s="core" v="545.7701"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="3072"/>
			<demand ref="2927"/>
			<demand z="3216" dC="vic_genetech">
				<d z="3217" b="0.0" m="260.0539">
					<fMs z="3218" s="core" v="260.0539"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="3005"/>
			<demand z="3219" dC="alcoholism_stout_c">
				<d z="3220" b="0.0" m="546.195">
					<fMs z="3221" s="core" v="546.195"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="3165"/>
			<demand ref="3151"/>
			<demand z="3222" dC="alcoholism_absynth_c">
				<d z="3223" b="0.0" m="545.9479">
					<fMs z="3224" s="core" v="545.9479"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="3031"/>
			<demand z="3225" dC="alcoholism_king_c">
				<d z="3226" b="0.0" m="545.6683">
					<fMs z="3227" s="core" v="545.6683"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="2953"/>
			<demand ref="3045"/>
			<demand z="3228" dC="alcoholism_tears_c">
				<d z="3229" b="0.0" m="501.48517">
					<fMs z="3230" s="core" v="501.48517"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand z="3231" dC="alcoholism_freedom_c">
				<d z="3232" b="0.0" m="638.485">
					<fMs z="3233" s="core" v="638.485"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand z="3234" dC="alcoholism_fuel_c">
				<d z="3235" b="0.0" m="535.6761">
					<fMs z="3236" s="core" v="535.6761"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="3112"/>
			<demand z="3237" dC="compound">
				<d z="3238" b="0.0" m="550.40704">
					<fMs z="3239" s="core" v="550.40704"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="2914"/>
			<demand z="3240" dC="purified_ore">
				<d z="3241" b="0.0" m="548.035">
					<fMs z="3242" s="core" v="548.035"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="3085"/>
			<demand ref="2901"/>
			<demand ref="3138"/>
			<demand z="3243" dC="domain_artifacts">
				<d z="3244" b="0.0" m="303.8979">
					<fMs z="3245" s="core" v="303.8979"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="2992"/>
			<demand z="3246" dC="refined_metal">
				<d z="3247" b="0.0" m="500.15045">
					<fMs z="3248" s="core" v="500.15045"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand z="3249" dC="purified_rare_metal">
				<d z="3250" b="0.0" m="507.09952">
					<fMs z="3251" s="core" v="507.09952"/>
				</d>
				<m ref="2849"/>
			</demand>
			<demand ref="2940"/>
			<market ref="2849"/>
		</demandData>
		<size>7</size>
		<location z="3252">-4400.0|-4500.0</location>
		<demandPriceMod z="3253" fB="0.0" m="1.0" pM="0.0" nR="false"/>
		<supplyPriceMod z="3254" fB="0.0" m="1.0" pM="0.0" nR="false"/>
		<tariff z="3255" b="0.0" m="0.07440001">
			<fMs z="3256" s="default_tariff" v="0.3"/>
			<mMs z="3257" s="nexerelinMult" v="0.6"/>
		</tariff>
		<factionId>sindrian_diktat</factionId>
		<power z="3258" b="0.0" m="20.0">
			<fMs z="3259" s="DE_Patrioticfervor_6598" d="Patriotic Fervor" v="3.0"/>
			<fMs z="3260" s="core_comm_relay" d="Comm relay" v="2.0"/>
			<fMs z="3261" s="_ind_population_3_ms" d="Base value" v="5.0"/>
			<fMs z="3262" s="ind_population_0" d="Domestic goods demand met" v="1.0"/>
			<fMs z="3263" s="ind_population_1" d="Luxury goods demand met" v="1.0"/>
			<fMs z="3264" s="ind_heavybatteries" d="Heavy batteries" v="1.0"/>
			<fMs z="3265" s="ind_highcommand" d="High command" v="2.0"/>
			<fMs z="3266" s="ind_lionsguard" d="Lion's Guard HQ" v="2.0"/>
			<fMs z="3267" s="ind_starfortress" d="Star fortress - low tech" v="3.0"/>
		</power>
		<hazard z="3268" b="0.0" m="1.9">
			<fMs z="3269" s="haz_base" d="Base value" v="1.0"/>
			<fMs z="3270" s="very_hot_3d83" d="Extreme Heat" v="0.5"/>
			<fMs z="3271" s="no_atmosphere_3d84" d="No Atmosphere" v="0.5"/>
			<fMs z="3272" s="tech_hazmmat" d="Hazmat Working Equipment" v="-0.1"/>
		</hazard>
		<primaryEntity cl="Plnt" ref="2842"/>
		<submarkets z="3273">
			<Submarket z="3274" s="open_market">
				<m ref="2849"/>
				<p cl="NexOpnMkt" z="3275" mSWUI="30.0" msSWU="9.731686" sLCU="0.0">
					<m cl="Market" ref="2849"/>
					<s cl="Submarket" ref="3274"/>
					<c cl="CargoData" z="3276" uS="true" mC="1000.0" sU="23352.066" mF="500.0" mP="750.0" fT="false">
						<s z="3277">
							<CIStack z="3278" rS="false" s="2074.5325" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">supplies</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3279" rS="false" s="10.9922905" mS="1000000.0" cSPU="0.0" t="RESOURCES">
								<d cl="st">fuel</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3280" rS="false" s="1716.6139" mS="1000000.0" cSPU="0.0" t="RESOURCES">
								<d cl="st">crew</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3281" rS="false" s="304.9309" mS="1000000.0" cSPU="0.0" t="RESOURCES">
								<d cl="st">marines</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3282" rS="false" s="800.82117" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">heavy_machinery</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3283" rS="false" s="189.95935" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">luxury_goods</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3284" rS="false" s="571.86993" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">domestic_goods</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3285" rS="false" s="237.94716" mS="1000000.0" cSPU="0.5" t="RESOURCES">
								<d cl="st">alcoholism_sunshine_c</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3286" rS="false" s="93.98374" mS="1000000.0" cSPU="0.5" t="RESOURCES">
								<d cl="st">alcoholism_tea_c</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3287" rS="false" s="456.89838" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">rare_metals</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3288" rS="false" s="5544.724" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">metals</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3289" rS="false" s="513.88617" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">IndEvo_parts</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3290" rS="false" s="332.92685" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">rare_ore</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3291" rS="false" s="5033.0127" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">ore</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3292" rS="false" s="56.98781" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">electronics</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3293" rS="false" s="132.97154" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">volatiles</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3294" rS="false" s="1079.9026" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">organics</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3295" rS="false" s="1822.4474" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">food</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3296" rS="false" s="4079.2283" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">water</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3297" rS="false" s="46.99187" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">biotics</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3298" rS="false" s="284.93903" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">recitificates</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3299" rS="true" s="8.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">heavymortar</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3300" rS="true" s="5.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">miningblaster</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3301" rS="true" s="4.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">wpnxt_minimortarbattery</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3302" rS="true" s="2.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">pilum</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3303" rS="true" s="1.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">arbalest</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3304" rS="true" s="17.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_miniblaster</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3305" rS="true" s="4.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">annihilator</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3306" rS="true" s="3.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">lightac</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3307" rS="true" s="3.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">lightmg</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3308" rS="true" s="2.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">harpoon_single</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3309" rS="true" s="1.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">hammer</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3310" rS="true" s="1.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">sabot_single</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3311" rS="true" s="10.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">broadsword_wing</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3312" rS="true" s="2.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">mining_drone_wing</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3313" rS="true" s="5.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">salshiexp_salvage_drone</d>
								<c ref="3276"/>
							</CIStack>
							<CIStack z="3314" rS="true" s="5.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">talon_wing</d>
								<c ref="3276"/>
							</CIStack>
						</s>
						<c z="3315">
							<value>0.0</value>
						</c>
						<mS z="3316" nP="SDS" nSf="sindrian_diktat" nS="false" oSML="false">
							<m z="3317">
								<FMmbr z="3318" o="0" sid="de_ingress_lg_Hull" sN="SDS Leader's Will" t="SHIP" iF="false" id="bbb0d2" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3319" hId="de_ingress_lg_default_D" v="0" c="0" hVId="de_ingress_lg_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3320">
											<e>
												<st>WS0023</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0045</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0022</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0044</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0025</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0047</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0024</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0046</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0041</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0040</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0021</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0043</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0020</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0042</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0038</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0037</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0039</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0034</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0033</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0014</st>
												<st>de_pulsecarbine</st>
											</e>
											<e>
												<st>WS0036</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0035</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0030</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0051</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0032</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0031</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0050</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0027</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0049</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0026</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0048</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0029</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0028</st>
												<st>de_flaregun</st>
											</e>
										</wpn>
										<sM z="3321"/>
										<wng z="3322"/>
										<wG z="3323"/>
										<hM z="3324">
											<st>andrada_mods</st>
											<st>solar_shielding</st>
											<st>increased_maintenance</st>
											<st>comp_structure</st>
										</hM>
										<pM z="3325">
											<st>increased_maintenance</st>
											<st>comp_structure</st>
										</pM>
										<sMods z="3326"/>
										<sModdedBuiltIns z="3327"/>
										<suM z="3328"/>
									</savedVariant>
									<rT z="3329" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3318"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3330" o="0" sid="supportships_geoid_Hull" sN="SDS Patalena" t="SHIP" iF="false" id="bbb090" sUN="false" civ="false" cCiv="false">
									<rT z="3331" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3330"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3332" o="0" sid="atlas_Hull" sN="SDS Vandal" t="SHIP" iF="false" id="bbb092" sUN="false" civ="false" cCiv="false">
									<rT z="3333" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3332"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3334" o="0" sid="salshiexp_recovery_Hull" sN="SDS Meskhenet" t="SHIP" iF="false" id="bbb094" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3335" hId="salshiexp_recovery_default_D" v="0" c="0" hVId="salshiexp_recovery_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3336"/>
										<sM z="3337"/>
										<wng z="3338"/>
										<wG z="3339"/>
										<hM z="3340">
											<st>salshiexp_salvagescanner</st>
											<st>repair_gantry</st>
											<st>civgrade</st>
											<st>degraded_drive_field</st>
										</hM>
										<pM z="3341">
											<st>degraded_drive_field</st>
										</pM>
										<sMods z="3342"/>
										<sModdedBuiltIns z="3343"/>
										<suM z="3344"/>
									</savedVariant>
									<rT z="3345" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3334"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3346" o="0" sid="de_voyager_Hull" sN="SDS Immortal Emperor" t="SHIP" iF="false" id="bbb096" sUN="false" civ="false" cCiv="false">
									<rT z="3347" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3346"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3348" o="0" sid="supportships_ossifrage_Hull" sN="SDS Karkadann" t="SHIP" iF="false" id="bbb0d4" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3349" hId="supportships_ossifrage_default_D" v="0" c="0" hVId="supportships_ossifrage_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3350">
											<e>
												<st>WS0005</st>
												<st>supportships_ossifrage_mask</st>
											</e>
										</wpn>
										<sM z="3351"/>
										<wng z="3352"/>
										<wG z="3353"/>
										<hM z="3354">
											<st>comp_hull</st>
											<st>damaged_mounts</st>
											<st>faulty_auto</st>
											<st>degraded_shields</st>
											<st>glitched_sensors</st>
										</hM>
										<pM z="3355">
											<st>comp_hull</st>
											<st>damaged_mounts</st>
											<st>faulty_auto</st>
											<st>degraded_shields</st>
											<st>glitched_sensors</st>
										</pM>
										<sMods z="3356"/>
										<sModdedBuiltIns z="3357"/>
										<suM z="3358"/>
									</savedVariant>
									<rT z="3359" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3348"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3360" o="0" sid="falcon_Hull" sN="SDS Allegiant Ultimus" t="SHIP" iF="false" id="bbb0d6" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3361" hId="falcon_default_D" v="0" c="0" hVId="falcon_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3362"/>
										<sM z="3363"/>
										<wng z="3364"/>
										<wG z="3365"/>
										<hM z="3366">
											<st>degraded_life_support</st>
											<st>fragile_subsystems</st>
											<st>erratic_injector</st>
											<st>increased_maintenance</st>
											<st>comp_hull</st>
										</hM>
										<pM z="3367">
											<st>degraded_life_support</st>
											<st>fragile_subsystems</st>
											<st>erratic_injector</st>
											<st>increased_maintenance</st>
											<st>comp_hull</st>
										</pM>
										<sMods z="3368"/>
										<sModdedBuiltIns z="3369"/>
										<suM z="3370"/>
									</savedVariant>
									<rT z="3371" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3360"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3372" o="0" sid="pranker_Hull" sN="SDS Domitius" t="SHIP" iF="false" id="bbb112" sUN="false" civ="false" cCiv="false">
									<rT z="3373" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3372"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3374" o="0" sid="pranker_Hull" sN="SDS Satevis" t="SHIP" iF="false" id="bbb114" sUN="false" civ="false" cCiv="false">
									<rT z="3375" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3374"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3376" o="0" sid="pranker_Hull" sN="SDS Victory of the Potentate" t="SHIP" iF="false" id="bbb116" sUN="false" civ="false" cCiv="false">
									<rT z="3377" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3376"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3378" o="0" sid="pranker_Hull" sN="SDS Pride of Sindria" t="SHIP" iF="false" id="bbb118" sUN="false" civ="false" cCiv="false">
									<rT z="3379" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3378"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3380" o="0" sid="pranker_Hull" sN="SDS Thunder Child" t="SHIP" iF="false" id="bbb11a" sUN="false" civ="false" cCiv="false">
									<rT z="3381" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3380"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3382" o="0" sid="pranker_Hull" sN="SDS Geus-Urvani" t="SHIP" iF="false" id="bbb11c" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3383" hId="pranker_default_D" v="0" c="0" hVId="pranker_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3384"/>
										<sM z="3385"/>
										<wng z="3386"/>
										<wG z="3387"/>
										<hM z="3388">
											<st>civgrade</st>
											<st>rugged</st>
											<st>comp_storage</st>
										</hM>
										<pM z="3389">
											<st>comp_storage</st>
										</pM>
										<sMods z="3390"/>
										<sModdedBuiltIns z="3391"/>
										<suM z="3392"/>
									</savedVariant>
									<rT z="3393" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3382"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3394" o="0" sid="pranker_Hull" sN="SDS Nasu" t="SHIP" iF="false" id="bbb11e" sUN="false" civ="false" cCiv="false">
									<rT z="3395" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3394"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3396" o="0" sid="pranker_Hull" sN="SDS Emperor of Salus" t="SHIP" iF="false" id="bbb120" sUN="false" civ="false" cCiv="false">
									<rT z="3397" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3396"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3398" o="0" sid="pranker_Hull" sN="SDS Jinn" t="SHIP" iF="false" id="bbb122" sUN="false" civ="false" cCiv="false">
									<rT z="3399" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3398"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3400" o="0" sid="pranker_Hull" sN="SDS Dawn of Empire" t="SHIP" iF="false" id="bbb124" sUN="false" civ="false" cCiv="false">
									<rT z="3401" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3400"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3402" o="0" sid="starliner_Hull" sN="SDS Mnewer" t="SHIP" iF="false" id="bbb098" sUN="false" civ="false" cCiv="false">
									<rT z="3403" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3402"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3404" o="0" sid="starliner_Hull" sN="SDS Rabbits to the Moon" t="SHIP" iF="false" id="bbb09a" sUN="false" civ="false" cCiv="false">
									<rT z="3405" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3404"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3406" o="0" sid="salshiexp_collector_Hull" sN="SDS Tibertus" t="SHIP" iF="false" id="bbb09c" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3407" hId="salshiexp_collector_default_D" v="0" c="0" hVId="salshiexp_collector_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3408"/>
										<sM z="3409"/>
										<wng z="3410">
											<st>salshiexp_salvage_drone</st>
											<st>salshiexp_salvage_drone</st>
										</wng>
										<wG z="3411"/>
										<hM z="3412">
											<st>repair_gantry</st>
											<st>salshiexp_salvagedrones</st>
											<st>civgrade</st>
											<st>degraded_drive_field</st>
										</hM>
										<pM z="3413">
											<st>degraded_drive_field</st>
										</pM>
										<sMods z="3414"/>
										<sModdedBuiltIns z="3415"/>
										<suM z="3416"/>
									</savedVariant>
									<rT z="3417" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3406"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3418" o="0" sid="salshiexp_collector_Hull" sN="SDS Mnewer" t="SHIP" iF="false" id="bbb09e" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3419" hId="salshiexp_collector_default_D" v="0" c="0" hVId="salshiexp_collector_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3420"/>
										<sM z="3421"/>
										<wng z="3422">
											<st>salshiexp_salvage_drone</st>
											<st>salshiexp_salvage_drone</st>
										</wng>
										<wG z="3423"/>
										<hM z="3424">
											<st>repair_gantry</st>
											<st>salshiexp_salvagedrones</st>
											<st>civgrade</st>
											<st>degraded_drive_field</st>
										</hM>
										<pM z="3425">
											<st>degraded_drive_field</st>
										</pM>
										<sMods z="3426"/>
										<sModdedBuiltIns z="3427"/>
										<suM z="3428"/>
									</savedVariant>
									<rT z="3429" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3418"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3430" o="0" sid="de_laticlavus_Hull" sN="SDS Aquilo" t="SHIP" iF="false" id="bbb0d8" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3431" hId="de_laticlavus_default_D" v="0" c="0" hVId="de_laticlavus_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3432"/>
										<sM z="3433"/>
										<wng z="3434"/>
										<wG z="3435"/>
										<hM z="3436">
											<st>pointdefenseai</st>
											<st>comp_structure</st>
											<st>degraded_engines</st>
											<st>erratic_injector</st>
											<st>increased_maintenance</st>
											<st>degraded_shields</st>
										</hM>
										<pM z="3437">
											<st>comp_structure</st>
											<st>degraded_engines</st>
											<st>erratic_injector</st>
											<st>increased_maintenance</st>
											<st>degraded_shields</st>
										</pM>
										<sMods z="3438"/>
										<sModdedBuiltIns z="3439"/>
										<suM z="3440"/>
									</savedVariant>
									<rT z="3441" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3430"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3442" o="0" sid="valkyrie_Hull" sN="SDS Danaus" t="SHIP" iF="false" id="bbb0a0" sUN="false" civ="false" cCiv="false">
									<rT z="3443" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3442"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3444" o="0" sid="nebula_Hull" sN="SDS Phase Space" t="SHIP" iF="false" id="bbb0a2" sUN="false" civ="false" cCiv="false">
									<rT z="3445" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3444"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3446" o="0" sid="nebula_Hull" sN="SDS Antinous" t="SHIP" iF="false" id="bbb0a4" sUN="false" civ="false" cCiv="false">
									<rT z="3447" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3446"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3448" o="0" sid="de_regulus_lg_Hull" sN="SDS Anubis" t="SHIP" iF="false" id="bbb0da" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3449" hId="de_regulus_lg_default_D" v="0" c="0" hVId="de_regulus_lg_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3450">
											<e>
												<st>WS0009</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0008</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0010</st>
												<st>de_flaregun</st>
											</e>
											<e>
												<st>WS0006</st>
												<st>de_flaregun</st>
											</e>
										</wpn>
										<sM z="3451"/>
										<wng z="3452"/>
										<wG z="3453"/>
										<hM z="3454">
											<st>andrada_mods</st>
											<st>andradaresonator</st>
											<st>solar_shielding</st>
											<st>comp_structure</st>
											<st>fragile_subsystems</st>
											<st>damaged_mounts</st>
											<st>erratic_injector</st>
										</hM>
										<pM z="3455">
											<st>comp_structure</st>
											<st>fragile_subsystems</st>
											<st>damaged_mounts</st>
											<st>erratic_injector</st>
										</pM>
										<sMods z="3456"/>
										<sModdedBuiltIns z="3457"/>
										<suM z="3458"/>
									</savedVariant>
									<rT z="3459" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3448"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3460" o="0" sid="de_regulus_Hull" sN="SDS Brizo" t="SHIP" iF="false" id="bbb0dc" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3461" hId="de_regulus_default_D" v="0" c="0" hVId="de_regulus_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3462"/>
										<sM z="3463"/>
										<wng z="3464"/>
										<wG z="3465"/>
										<hM z="3466">
											<st>glitched_sensors</st>
											<st>degraded_engines</st>
											<st>degraded_shields</st>
											<st>comp_structure</st>
											<st>increased_maintenance</st>
										</hM>
										<pM z="3467">
											<st>glitched_sensors</st>
											<st>degraded_engines</st>
											<st>degraded_shields</st>
											<st>comp_structure</st>
											<st>increased_maintenance</st>
										</pM>
										<sMods z="3468"/>
										<sModdedBuiltIns z="3469"/>
										<suM z="3470"/>
									</savedVariant>
									<rT z="3471" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3460"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3472" o="0" sid="de_jackdaw_Hull" sN="SDS Virulent" t="SHIP" iF="false" id="bbb0de" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3473" hId="de_jackdaw_default_D" v="0" c="0" hVId="de_jackdaw_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3474"/>
										<sM z="3475"/>
										<wng z="3476"/>
										<wG z="3477"/>
										<hM z="3478">
											<st>spinalgenerator</st>
											<st>increased_maintenance</st>
											<st>comp_hull</st>
											<st>fragile_subsystems</st>
											<st>glitched_sensors</st>
											<st>faulty_auto</st>
										</hM>
										<pM z="3479">
											<st>increased_maintenance</st>
											<st>comp_hull</st>
											<st>fragile_subsystems</st>
											<st>glitched_sensors</st>
											<st>faulty_auto</st>
										</pM>
										<sMods z="3480"/>
										<sModdedBuiltIns z="3481"/>
										<suM z="3482"/>
									</savedVariant>
									<rT z="3483" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3472"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3484" o="0" sid="de_mynah_Hull" sN="SDS The Space Ark" t="SHIP" iF="false" id="bbb0a6" sUN="false" civ="false" cCiv="false">
									<rT z="3485" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3484"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3486" o="0" sid="mercury_Hull" sN="SDS Pelias" t="SHIP" iF="false" id="bbb0a8" sUN="false" civ="false" cCiv="false">
									<rT z="3487" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3486"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3488" o="0" sid="de_mynah_Hull" sN="SDS Interceptor" t="SHIP" iF="false" id="bbb0e0" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3489" hId="de_mynah_default_D" v="0" c="0" hVId="de_mynah_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3490"/>
										<sM z="3491"/>
										<wng z="3492"/>
										<wG z="3493"/>
										<hM z="3494">
											<st>glitched_sensors</st>
											<st>comp_hull</st>
											<st>fragile_subsystems</st>
											<st>damaged_mounts</st>
											<st>faulty_grid</st>
										</hM>
										<pM z="3495">
											<st>glitched_sensors</st>
											<st>comp_hull</st>
											<st>fragile_subsystems</st>
											<st>damaged_mounts</st>
											<st>faulty_grid</st>
										</pM>
										<sMods z="3496"/>
										<sModdedBuiltIns z="3497"/>
										<suM z="3498"/>
									</savedVariant>
									<rT z="3499" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3488"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3500" o="0" sid="de_mynah_Hull" sN="SDS Astennu" t="SHIP" iF="false" id="bbb0e2" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3501" hId="de_mynah_default_D" v="0" c="0" hVId="de_mynah_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3502"/>
										<sM z="3503"/>
										<wng z="3504"/>
										<wG z="3505"/>
										<hM z="3506">
											<st>degraded_shields</st>
											<st>comp_structure</st>
											<st>fragile_subsystems</st>
											<st>increased_maintenance</st>
										</hM>
										<pM z="3507">
											<st>degraded_shields</st>
											<st>comp_structure</st>
											<st>fragile_subsystems</st>
											<st>increased_maintenance</st>
										</pM>
										<sMods z="3508"/>
										<sModdedBuiltIns z="3509"/>
										<suM z="3510"/>
									</savedVariant>
									<rT z="3511" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3500"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
								<FMmbr z="3512" o="0" sid="de_mynah_Hull" sN="SDS Herulus" t="SHIP" iF="false" id="bbb0e4" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3513" hId="de_mynah_default_D" v="0" c="0" hVId="de_mynah_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3514"/>
										<sM z="3515"/>
										<wng z="3516"/>
										<wG z="3517"/>
										<hM z="3518">
											<st>comp_structure</st>
											<st>erratic_injector</st>
											<st>degraded_shields</st>
										</hM>
										<pM z="3519">
											<st>comp_structure</st>
											<st>erratic_injector</st>
											<st>degraded_shields</st>
										</pM>
										<sMods z="3520"/>
										<sModdedBuiltIns z="3521"/>
										<suM z="3522"/>
									</savedVariant>
									<rT z="3523" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3512"/>
									</rT>
									<fD ref="3316"/>
								</FMmbr>
							</m>
						</mS>
					</c>
					<iGR z="3524" serialization="custom">
						<Random>
							<default>
								<s>176853028273671</s>
								<n>0.0</n>
								<h>false</h>
							</default>
						</Random>
					</iGR>
				</p>
				<f ref="2762"/>
			</Submarket>
			<Submarket z="3525" s="generic_military">
				<m ref="2849"/>
				<p cl="NexMilSubmkt" z="3526" mSWUI="30.0" msSWU="9.731686" sLCU="0.0" mS="FAVORABLE">
					<m cl="Market" ref="2849"/>
					<s cl="Submarket" ref="3525"/>
					<c cl="CargoData" z="3527" uS="true" mC="1000.0" sU="3153.0" mF="500.0" mP="750.0" fT="false">
						<s z="3528">
							<CIStack z="3529" rS="false" s="2361.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">supplies</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3530" rS="false" s="13.237896" mS="1000000.0" cSPU="0.0" t="RESOURCES">
								<d cl="st">fuel</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3531" rS="false" s="1954.0" mS="1000000.0" cSPU="0.0" t="RESOURCES">
								<d cl="st">crew</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3532" rS="false" s="347.0" mS="1000000.0" cSPU="0.0" t="RESOURCES">
								<d cl="st">marines</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3533" rS="false" s="608.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">hand_weapons</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3534" rS="true" s="1.0" mS="1000000.0" cSPU="8.0" t="WEAPONS">
								<d cl="st">devastator</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3535" rS="true" s="1.0" mS="1000000.0" cSPU="8.0" t="WEAPONS">
								<d cl="st">hil</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3536" rS="true" s="4.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">wpnxt_heavypounder</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3537" rS="true" s="4.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">heavymortar</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3538" rS="true" s="3.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">wpnxt_fragpdbeam</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3539" rS="true" s="3.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">harpoonpod</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3540" rS="true" s="3.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">heavyac</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3541" rS="true" s="1.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">flak</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3542" rS="true" s="1.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">gravitonbeam</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3543" rS="true" s="1.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">sabotpod</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3544" rS="true" s="8.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">railgun</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3545" rS="true" s="5.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">swarmer</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3546" rS="true" s="4.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">lightdualac</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3547" rS="true" s="4.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_miniblaster</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3548" rS="true" s="4.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">taclaser</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3549" rS="true" s="3.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_impactbeam</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3550" rS="true" s="3.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">reaper</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3551" rS="true" s="1.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_minivulcan</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3552" rS="true" s="1.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">filgap_scattergun</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3553" rS="true" s="4.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">de_bretais_LG_wing</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3554" rS="true" s="7.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">claw_wing</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3555" rS="true" s="2.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">missp_midline_patrol_craft_wing</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3556" rS="true" s="3.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">gladius_wing</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3557" rS="true" s="1.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">missp_gun_craft_wing</d>
								<c ref="3527"/>
							</CIStack>
							<CIStack z="3558" rS="true" s="5.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">thunder_wing</d>
								<c ref="3527"/>
							</CIStack>
						</s>
						<c z="3559">
							<value>0.0</value>
						</c>
						<mS z="3560" nP="SDS" nSf="sindrian_diktat" nS="false" oSML="false">
							<m z="3561">
								<FMmbr z="3562" o="0" sid="de_ingress_lg_Hull" sN="SDS Meskhenet" t="SHIP" iF="false" id="bbb31a" sUN="false" civ="false" cCiv="false">
									<rT z="3563" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3562"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
								<FMmbr z="3564" o="0" sid="de_ingress_lg_Hull" sN="SDS Vindicator" t="SHIP" iF="false" id="bbb31c" sUN="false" civ="false" cCiv="false">
									<rT z="3565" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3564"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
								<FMmbr z="3566" o="0" sid="de_ingress_lg_Hull" sN="SDS Vengeance of Opis" t="SHIP" iF="false" id="bbb31e" sUN="false" civ="false" cCiv="false">
									<rT z="3567" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3566"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
								<FMmbr z="3568" o="0" sid="de_ingress_lg_Hull" sN="SDS Alcaeus" t="SHIP" iF="false" id="bbb320" sUN="false" civ="false" cCiv="false">
									<rT z="3569" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3568"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
								<FMmbr z="3570" o="0" sid="de_exult_Hull" sN="SDS Primis Prepotence" t="SHIP" iF="false" id="bbb322" sUN="false" civ="false" cCiv="false">
									<rT z="3571" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3570"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
								<FMmbr z="3572" o="0" sid="de_starliner_lg_Hull" sN="SDS Heket" t="SHIP" iF="false" id="bbb324" sUN="false" civ="false" cCiv="false">
									<rT z="3573" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3572"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
								<FMmbr z="3574" o="0" sid="missp_venture_gamble_Hull" sN="SDS Andrada Invictus" t="SHIP" iF="false" id="bbb326" sUN="false" civ="false" cCiv="false">
									<rT z="3575" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3574"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
								<FMmbr z="3576" o="0" sid="missp_venture_gamble_Hull" sN="SDS Novus Temujin" t="SHIP" iF="false" id="bbb328" sUN="false" civ="false" cCiv="false">
									<rT z="3577" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3576"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
								<FMmbr z="3578" o="0" sid="starliner_Hull" sN="SDS Hatmehit" t="SHIP" iF="false" id="bbb32a" sUN="false" civ="false" cCiv="false">
									<rT z="3579" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3578"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
								<FMmbr z="3580" o="0" sid="starliner_Hull" sN="SDS Angra Mainyu" t="SHIP" iF="false" id="bbb32c" sUN="false" civ="false" cCiv="false">
									<rT z="3581" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3580"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
								<FMmbr z="3582" o="0" sid="gizzard_lion_Hull" sN="SDS Judgement of Andrada" t="SHIP" iF="false" id="bbb32e" sUN="false" civ="false" cCiv="false">
									<rT z="3583" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3582"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
								<FMmbr z="3584" o="0" sid="de_mynah_Hull" sN="SDS Anouke" t="SHIP" iF="false" id="bbb330" sUN="false" civ="false" cCiv="false">
									<rT z="3585" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3584"/>
									</rT>
									<fD ref="3560"/>
								</FMmbr>
							</m>
						</mS>
					</c>
					<iGR z="3586" serialization="custom">
						<Random>
							<default>
								<s>150518589323499</s>
								<n>0.0</n>
								<h>false</h>
							</default>
						</Random>
					</iGR>
				</p>
				<f ref="2762"/>
			</Submarket>
			<Submarket z="3587" s="de_LGmarket">
				<m ref="2849"/>
				<p cl="DE.campaign.submarkets.DE_LGMarketPlugin" z="3588" mSWUI="30.0" msSWU="9.731686" sLCU="0.0">
					<m cl="Market" ref="2849"/>
					<s cl="Submarket" ref="3587"/>
					<c cl="CargoData" z="3589" uS="true" mC="1000.0" sU="56.0" mF="500.0" mP="750.0" fT="false">
						<s z="3590">
							<CIStack z="3591" rS="true" s="4.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">de_incisorpod</d>
								<c ref="3589"/>
							</CIStack>
							<CIStack z="3592" rS="true" s="6.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">atropos_single</d>
								<c ref="3589"/>
							</CIStack>
							<CIStack z="3593" rS="true" s="6.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_minivulcan</d>
								<c ref="3589"/>
							</CIStack>
							<CIStack z="3594" rS="true" s="3.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_miniblaster</d>
								<c ref="3589"/>
							</CIStack>
							<CIStack z="3595" rS="true" s="3.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">sabot</d>
								<c ref="3589"/>
							</CIStack>
							<CIStack z="3596" rS="true" s="2.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_lightrailburst</d>
								<c ref="3589"/>
							</CIStack>
						</s>
						<c z="3597">
							<value>0.0</value>
						</c>
						<mS z="3598" nP="LGS" nSf="lions_guard" nS="false" oSML="false">
							<m z="3599">
								<FMmbr z="3600" o="0" sid="executor_Hull" sN="LGS Baucis" t="SHIP" iF="false" id="bbb542" sUN="false" civ="false" cCiv="false">
									<rT z="3601" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3600"/>
									</rT>
									<fD ref="3598"/>
								</FMmbr>
								<FMmbr z="3602" o="0" sid="de_ingress_lg_Hull" sN="LGS Dawn of the Final Era" t="SHIP" iF="false" id="bbb544" sUN="false" civ="false" cCiv="false">
									<rT z="3603" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3602"/>
									</rT>
									<fD ref="3598"/>
								</FMmbr>
								<FMmbr z="3604" o="0" sid="de_ingress_lg_Hull" sN="LGS Occator" t="SHIP" iF="false" id="bbb546" sUN="false" civ="false" cCiv="false">
									<rT z="3605" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3604"/>
									</rT>
									<fD ref="3598"/>
								</FMmbr>
								<FMmbr z="3606" o="0" sid="de_ingress_lg_Hull" sN="LGS A Rescue From Jupiter" t="SHIP" iF="false" id="bbb548" sUN="false" civ="false" cCiv="false">
									<rT z="3607" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3606"/>
									</rT>
									<fD ref="3598"/>
								</FMmbr>
								<FMmbr z="3608" o="0" sid="de_ingress_lg_Hull" sN="LGS Halcyon Drift" t="SHIP" iF="false" id="bbb54a" sUN="false" civ="false" cCiv="false">
									<rT z="3609" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3608"/>
									</rT>
									<fD ref="3598"/>
								</FMmbr>
								<FMmbr z="3610" o="0" sid="eagle_LG_Hull" sN="LGS Ascendant Command" t="SHIP" iF="false" id="bbb54c" sUN="false" civ="false" cCiv="false">
									<rT z="3611" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3610"/>
									</rT>
									<fD ref="3598"/>
								</FMmbr>
								<FMmbr z="3612" o="0" sid="falcon_LG_Hull" sN="LGS Khshathra Vairya" t="SHIP" iF="false" id="bbb550" sUN="false" civ="false" cCiv="false">
									<rT z="3613" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3612"/>
									</rT>
									<fD ref="3598"/>
								</FMmbr>
								<FMmbr z="3614" o="0" sid="falcon_LG_Hull" sN="LGS Dawn of Empire" t="SHIP" iF="false" id="bbb552" sUN="false" civ="false" cCiv="false">
									<rT z="3615" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3614"/>
									</rT>
									<fD ref="3598"/>
								</FMmbr>
								<FMmbr z="3616" o="0" sid="centurion_LG_Hull" sN="LGS Sesmu" t="SHIP" iF="false" id="bbb556" sUN="false" civ="false" cCiv="false">
									<rT z="3617" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3616"/>
									</rT>
									<fD ref="3598"/>
								</FMmbr>
							</m>
						</mS>
					</c>
					<iGR z="3618" serialization="custom">
						<Random>
							<default>
								<s>83779489534462</s>
								<n>0.0</n>
								<h>false</h>
							</default>
						</Random>
					</iGR>
					<MIN__STANDING>COOPERATIVE</MIN__STANDING>
				</p>
				<f z="3619">
					<id>lions_guard</id>
					<memory z="3620">
						<d z="3621">
							<e>
								<st>$nex_alignments</st>
								<map z="3622">
									<e>
										<NexAlign>DIPLOMATIC</NexAlign>
										<MStat z="3623" b="0.0" m="0.0"/>
									</e>
									<e>
										<NexAlign>CORPORATE</NexAlign>
										<MStat z="3624" b="0.0" m="0.0"/>
									</e>
									<e>
										<NexAlign>MILITARIST</NexAlign>
										<MStat z="3625" b="0.0" m="0.0"/>
									</e>
									<e>
										<NexAlign>IDEOLOGICAL</NexAlign>
										<MStat z="3626" b="0.0" m="0.0"/>
									</e>
									<e>
										<NexAlign>TECHNOCRATIC</NexAlign>
										<MStat z="3627" b="0.0" m="0.0"/>
									</e>
									<e>
										<NexAlign>HIERARCHICAL</NexAlign>
										<MStat z="3628" b="0.0" m="0.0"/>
									</e>
								</map>
							</e>
							<e>
								<st>$nex_max_relations</st>
								<map z="3629"/>
							</e>
						</d>
					</memory>
					<illegal z="3630">
						<st>hand_weapons</st>
						<st>organs</st>
						<st>drugs</st>
						<st>ai_cores</st>
					</illegal>
					<shipsWhenImporting z="3631">
						<st>executor</st>
						<st>BSC_Hartfell_LG</st>
						<st>de_legate</st>
						<st>BSC_Cassina_LG</st>
						<st>sunder_LG</st>
						<st>hammerhead_LG</st>
						<st>pranker</st>
						<st>de_vanquisher</st>
						<st>de_starliner_lg</st>
						<st>supportships_lammergeierlg</st>
						<st>brawler_LG</st>
						<st>de_ingress_lg</st>
						<st>gizzard_lion</st>
						<st>eagle_LG</st>
						<st>de_laticlavus_lg</st>
						<st>de_mynah</st>
						<st>falcon_LG</st>
						<st>de_regulus_lg</st>
						<st>gizzard</st>
						<st>de_sagittarii</st>
						<st>de_jackdaw</st>
						<st>de_mynah_lg</st>
						<st>de_exult</st>
						<st>de_voyager</st>
						<st>de_regulus</st>
						<st>de_vanquisher_lg</st>
						<st>de_laticlavus</st>
						<st>centurion_LG</st>
						<st>crig</st>
						<st>ox</st>
						<st>dram</st>
						<st>phaeton</st>
						<st>prometheus</st>
						<st>gemini</st>
						<st>atlas</st>
						<st>mercury</st>
						<st>hermes</st>
						<st>kite_original</st>
						<st>mudskipper</st>
						<st>wayfarer</st>
						<st>nebula</st>
						<st>valkyrie</st>
						<st>starliner</st>
						<st>buffalo</st>
						<st>colossus</st>
					</shipsWhenImporting>
					<knownShips z="3632">
						<st>executor</st>
						<st>BSC_Hartfell_LG</st>
						<st>de_legate</st>
						<st>BSC_Cassina_LG</st>
						<st>sunder_LG</st>
						<st>hammerhead_LG</st>
						<st>pranker</st>
						<st>de_vanquisher</st>
						<st>de_starliner_lg</st>
						<st>supportships_lammergeierlg</st>
						<st>brawler_LG</st>
						<st>de_ingress_lg</st>
						<st>gizzard_lion</st>
						<st>eagle_LG</st>
						<st>de_laticlavus_lg</st>
						<st>de_mynah</st>
						<st>falcon_LG</st>
						<st>de_regulus_lg</st>
						<st>gizzard</st>
						<st>de_sagittarii</st>
						<st>de_jackdaw</st>
						<st>de_mynah_lg</st>
						<st>de_exult</st>
						<st>de_voyager</st>
						<st>de_regulus</st>
						<st>de_vanquisher_lg</st>
						<st>de_laticlavus</st>
						<st>centurion_LG</st>
						<st>crig</st>
						<st>ox</st>
						<st>dram</st>
						<st>phaeton</st>
						<st>prometheus</st>
						<st>gemini</st>
						<st>atlas</st>
						<st>mercury</st>
						<st>hermes</st>
						<st>kite_original</st>
						<st>mudskipper</st>
						<st>wayfarer</st>
						<st>nebula</st>
						<st>valkyrie</st>
						<st>starliner</st>
						<st>buffalo</st>
						<st>colossus</st>
					</knownShips>
					<knownWeapons z="3633">
						<st>lightmg</st>
						<st>lightdualmg</st>
						<st>vulcan</st>
						<st>lightac</st>
						<st>lightdualac</st>
						<st>lightag</st>
						<st>lightneedler</st>
						<st>railgun</st>
						<st>hveldriver</st>
						<st>heavymauler</st>
						<st>heavyneedler</st>
						<st>heavymortar</st>
						<st>chaingun</st>
						<st>heavyac</st>
						<st>flak</st>
						<st>dualflak</st>
						<st>hephag</st>
						<st>mark9</st>
						<st>devastator</st>
						<st>reaper</st>
						<st>atropos</st>
						<st>atropos_single</st>
						<st>swarmer</st>
						<st>annihilator</st>
						<st>heatseeker</st>
						<st>harpoon</st>
						<st>harpoon_single</st>
						<st>breach</st>
						<st>sabot</st>
						<st>sabot_single</st>
						<st>pilum</st>
						<st>breachpod</st>
						<st>harpoonpod</st>
						<st>sabotpod</st>
						<st>phasecl</st>
						<st>typhoon</st>
						<st>squall</st>
						<st>locust</st>
						<st>amblaster</st>
						<st>taclaser</st>
						<st>pdlaser</st>
						<st>lrpdlaser</st>
						<st>ioncannon</st>
						<st>gravitonbeam</st>
						<st>pulselaser</st>
						<st>phasebeam</st>
						<st>heavyblaster</st>
						<st>hil</st>
						<st>autopulse</st>
						<st>kineticblaster</st>
						<st>gigacannon</st>
						<st>de_incisor</st>
						<st>de_incisorpod</st>
						<st>de_incisormaw</st>
						<st>de_cruordriver</st>
						<st>de_tacsuperlaser</st>
						<st>de_scatter</st>
						<st>de_shoal</st>
						<st>wpnxt_minivulcan</st>
						<st>wpnxt_fragcannon</st>
						<st>wpnxt_lightpounder</st>
						<st>wpnxt_lightrailburst</st>
						<st>wpnxt_minimortarbattery</st>
						<st>wpnxt_heavyrailgun</st>
						<st>wpnxt_heavypounder</st>
						<st>wpnxt_splinterbattery</st>
						<st>wpnxt_clusterlauncherbig</st>
						<st>wpnxt_spikebarrage</st>
						<st>wpnxt_impaler</st>
						<st>wpnxt_ionrocket</st>
						<st>wpnxt_minispiker</st>
						<st>wpnxt_clusterminelauncher</st>
						<st>wpnxt_fragpdbeam</st>
						<st>wpnxt_enhtaclaser</st>
						<st>wpnxt_mininglasermk2</st>
						<st>wpnxt_miniblaster</st>
						<st>wpnxt_impactbeam</st>
						<st>wpnxt_impactlance</st>
						<st>wpnxt_ultrablaster</st>
					</knownWeapons>
					<knownFighters z="3634">
						<st>de_bretais_LG_wing</st>
						<st>de_bretais_wing</st>
						<st>de_babirusa_LG_wing</st>
						<st>de_woodpecker_wing</st>
						<st>de_bretasinge_wing</st>
						<st>de_metanephrops_wing</st>
						<st>de_bretasinge_LG_wing</st>
						<st>de_nephrops_wing</st>
						<st>de_flurry_LG_bomber_wing</st>
						<st>de_flurry_bomber_wing</st>
						<st>de_homarus_wing</st>
						<st>talon_wing</st>
						<st>wasp_wing</st>
						<st>xyphos_wing</st>
						<st>broadsword_wing</st>
						<st>dagger_wing</st>
						<st>hoplon_wing</st>
					</knownFighters>
					<knownIndustries z="3635"/>
					<knownHullMods z="3636">
						<st>advancedshieldemitter</st>
						<st>adaptive_coils</st>
						<st>advancedoptics</st>
						<st>turretgyros</st>
						<st>armoredweapons</st>
						<st>autorepair</st>
						<st>auxiliarythrusters</st>
						<st>ballistic_rangefinder</st>
						<st>blast_doors</st>
						<st>converted_hangar</st>
						<st>converted_fighterbay</st>
						<st>dedicated_targeting_core</st>
						<st>defensive_targeting_array</st>
						<st>eccm</st>
						<st>ecm</st>
						<st>escort_package</st>
						<st>expanded_deck_crew</st>
						<st>magazines</st>
						<st>missleracks</st>
						<st>extendedshieldemitter</st>
						<st>fluxcoil</st>
						<st>fluxdistributor</st>
						<st>shield_shunt</st>
						<st>frontshield</st>
						<st>missile_autoloader</st>
						<st>hardenedshieldemitter</st>
						<st>hardened_subsystems</st>
						<st>heavyarmor</st>
						<st>high_scatter_amp</st>
						<st>pointdefenseai</st>
						<st>targetingunit</st>
						<st>nav_relay</st>
						<st>frontemitter</st>
						<st>adaptiveshields</st>
						<st>phase_anchor</st>
						<st>recovery_shuttles</st>
						<st>reinforcedhull</st>
						<st>fluxbreakers</st>
						<st>safetyoverrides</st>
						<st>stabilizedshieldemitter</st>
						<st>unstable_injector</st>
						<st>additional_berthing</st>
						<st>augmentedengines</st>
						<st>auxiliary_fuel_tanks</st>
						<st>efficiency_overhaul</st>
						<st>expanded_cargo_holds</st>
						<st>hiressensors</st>
						<st>insulatedengine</st>
						<st>militarized_subsystems</st>
						<st>solar_shielding</st>
						<st>surveying_equipment</st>
						<st>ash_advance_radar_systems</st>
						<st>ash_circuit_breakers</st>
						<st>ash_external_cargo_holds</st>
						<st>ash_external_cryo_pods</st>
						<st>ash_external_fuel_tanks</st>
						<st>ash_flux_limiters</st>
						<st>ash_fuel_ramscoop</st>
						<st>ash_industrial_machine_forge</st>
						<st>ash_mineral_refinery</st>
						<st>ash_targeting_transceiver</st>
						<st>adf_AttunedEngines</st>
						<st>diableavionics_sniperkit</st>
						<st>diableavionics_mountBI</st>
						<st>diableavionics_universaldecksExtra</st>
						<st>ML_skinSwap</st>
						<st>mhmods_fluxgenerator</st>
						<st>mhmods_voltageregulationsystem</st>
						<st>mhmods_weaponinhibitor</st>
						<st>st_parcelsorter</st>
						<st>tahlan_daemoncore</st>
						<st>vic_PDArcEmitter</st>
					</knownHullMods>
					<priorityShips z="3637"/>
					<priorityWeapons z="3638"/>
					<priorityFighters z="3639">
						<st>de_bretais_LG_wing</st>
						<st>de_bretais_wing</st>
						<st>de_babirusa_LG_wing</st>
						<st>de_woodpecker_wing</st>
						<st>de_bretasinge_wing</st>
						<st>de_metanephrops_wing</st>
						<st>de_bretasinge_LG_wing</st>
						<st>de_nephrops_wing</st>
						<st>de_flurry_LG_bomber_wing</st>
						<st>de_flurry_bomber_wing</st>
						<st>de_homarus_wing</st>
						<st>wasp_wing</st>
						<st>xyphos_wing</st>
						<st>dagger_wing</st>
						<st>hoplon_wing</st>
					</priorityFighters>
					<priorityHullMods z="3640"/>
					<hullFrequency cl="l-h-m" z="3641">
						<e>
							<st>BSC_Tramp</st>
							<fp>0.0</fp>
						</e>
						<e>
							<st>de_exult</st>
							<fp>0.0</fp>
						</e>
						<e>
							<st>de_jackdaw</st>
							<fp>0.0</fp>
						</e>
						<e>
							<st>BSC_Baldricmk2</st>
							<fp>0.0</fp>
						</e>
						<e>
							<st>de_sagittarii</st>
							<fp>0.0</fp>
						</e>
						<e>
							<st>de_regulus</st>
							<fp>0.0</fp>
						</e>
						<e>
							<st>de_voyager</st>
							<fp>0.0</fp>
						</e>
						<e>
							<st>de_legate</st>
							<fp>0.0</fp>
						</e>
						<e>
							<st>de_vanquisher</st>
							<fp>0.0</fp>
						</e>
						<e>
							<st>de_mynah</st>
							<fp>0.0</fp>
						</e>
						<e>
							<st>de_regulus_lg</st>
							<fp>0.5</fp>
						</e>
						<e>
							<st>de_laticlavus</st>
							<fp>0.0</fp>
						</e>
						<e>
							<st>BSC_Buffalo_Mk3</st>
							<fp>0.0</fp>
						</e>
					</hullFrequency>
					<variantOverrides cl="l-h-m" z="3642">
						<e>
							<st>de_ingress_lg_Hammer</st>
							<fp>10.0</fp>
						</e>
						<e>
							<st>BSC_Hartfell_LG_Pulser</st>
							<fp>4.0</fp>
						</e>
						<e>
							<st>BSC_Cassina_LG_Elite</st>
							<fp>3.0</fp>
						</e>
						<e>
							<st>executor_Elite</st>
							<fp>10.0</fp>
						</e>
						<e>
							<st>BSC_Cassina_LG_Standard</st>
							<fp>5.0</fp>
						</e>
						<e>
							<st>BSC_Hartfell_LG_Elite</st>
							<fp>3.0</fp>
						</e>
					</variantOverrides>
					<overriddenHulls z="3643">
						<st>de_ingress_lg</st>
						<st>BSC_Hartfell_LG</st>
						<st>BSC_Cassina_LG</st>
						<st>executor</st>
					</overriddenHulls>
					<doctrine z="3644">
						<warships>5</warships>
						<carriers>0</carriers>
						<phaseShips>0</phaseShips>
						<officerQuality>1</officerQuality>
						<shipQuality>5</shipQuality>
						<numShips>1</numShips>
						<shipSize>5</shipSize>
						<aggression>4</aggression>
						<fleets>3</fleets>
						<autofitRandomizeProbability>0.0</autofitRandomizeProbability>
						<combatFreighterProbability>0.0</combatFreighterProbability>
						<combatFreighterCombatUseFraction>0.0</combatFreighterCombatUseFraction>
						<combatFreighterCombatUseFractionWhenPriority>0.0</combatFreighterCombatUseFractionWhenPriority>
						<commanderSkillsShuffleProbability>0.0</commanderSkillsShuffleProbability>
						<strictComposition>false</strictComposition>
						<commanderSkills z="3645">
							<st>coordinated_maneuvers</st>
							<st>crew_training</st>
							<st>tactical_drills</st>
							<st>crew_training</st>
							<st>officer_training</st>
						</commanderSkills>
						<officerSkillsShuffleProbability>0.0</officerSkillsShuffleProbability>
						<officerSkills z="3646"/>
					</doctrine>
					<production z="3647">
						<interrupted z="3648"/>
						<current z="3649"/>
						<faction cl="Faction" ref="3619"/>
						<accruedProduction>0</accruedProduction>
						<costMult>1.0</costMult>
					</production>
					<weaponTimestamps cl="l-h-m" z="3650"/>
					<fighterTimestamps cl="l-h-m" z="3651"/>
					<shipTimestamps cl="l-h-m" z="3652"/>
					<showInIntelTabOverridden>true</showInIntelTabOverridden>
					<isShowInIntelTab>false</isShowInIntelTab>
					<autoEnableKnownShips>false</autoEnableKnownShips>
					<autoEnableKnownWeapons>false</autoEnableKnownWeapons>
					<autoEnableKnownFighters>false</autoEnableKnownFighters>
					<autoEnableKnownHullmods>false</autoEnableKnownHullmods>
					<secondaryColorSegmentsOverride>0</secondaryColorSegmentsOverride>
				</f>
			</Submarket>
			<Submarket z="3653" s="black_market">
				<m ref="2849"/>
				<p cl="NexBlackMkt" z="3654" mSWUI="30.0" msSWU="9.731686" sLCU="0.0">
					<m cl="Market" ref="2849"/>
					<s cl="Submarket" ref="3653"/>
					<c cl="CargoData" z="3655" uS="true" mC="1000.0" sU="6664.402" mF="500.0" mP="750.0" fT="false">
						<s z="3656">
							<CIStack z="3657" rS="false" s="548.9756" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">supplies</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3658" rS="false" s="3.0463014" mS="1000000.0" cSPU="0.0" t="RESOURCES">
								<d cl="st">fuel</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3659" rS="false" s="453.97968" mS="1000000.0" cSPU="0.0" t="RESOURCES">
								<d cl="st">crew</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3660" rS="false" s="79.99593" mS="1000000.0" cSPU="0.0" t="RESOURCES">
								<d cl="st">marines</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3661" rS="false" s="211.98781" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">heavy_machinery</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3662" rS="false" s="49.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">luxury_goods</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3663" rS="false" s="140.99187" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">hand_weapons</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3664" rS="false" s="130.34344" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">drugs</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3665" rS="false" s="42.130062" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">organs</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3666" rS="false" s="150.99187" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">domestic_goods</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3667" rS="false" s="62.0" mS="1000000.0" cSPU="0.5" t="RESOURCES">
								<d cl="st">alcoholism_sunshine_c</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3668" rS="false" s="24.0" mS="1000000.0" cSPU="0.5" t="RESOURCES">
								<d cl="st">alcoholism_tea_c</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3669" rS="false" s="119.99593" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">rare_metals</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3670" rS="false" s="1458.2495" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">metals</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3671" rS="false" s="135.99187" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">IndEvo_parts</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3672" rS="false" s="87.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">rare_ore</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3673" rS="false" s="1330.1587" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">ore</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3674" rS="false" s="14.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">electronics</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3675" rS="false" s="34.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">volatiles</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3676" rS="false" s="284.75208" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">organics</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3677" rS="false" s="480.66672" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">food</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3678" rS="false" s="1077.1709" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">water</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3679" rS="false" s="12.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">biotics</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3680" rS="false" s="74.99593" mS="1000000.0" cSPU="1.0" t="RESOURCES">
								<d cl="st">recitificates</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3681" rS="true" s="2.0" mS="1000000.0" cSPU="8.0" t="WEAPONS">
								<d cl="st">madmaiden</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3682" rS="true" s="1.0" mS="1000000.0" cSPU="8.0" t="WEAPONS">
								<d cl="st">devastator</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3683" rS="true" s="6.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">miningblaster</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3684" rS="true" s="5.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">SKR_stepMissilesLauncher</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3685" rS="true" s="4.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">heavymortar</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3686" rS="true" s="4.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">sabotpod</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3687" rS="true" s="3.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">tahlan_dualvolkite</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3688" rS="true" s="2.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">phasebeam</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3689" rS="true" s="7.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">flicker_pdl</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3690" rS="true" s="7.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">hammer</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3691" rS="true" s="6.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_minivulcan</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3692" rS="true" s="6.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">reaper</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3693" rS="true" s="5.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_lightpounder</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3694" rS="true" s="5.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_impactbeam</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3695" rS="true" s="5.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_minispiker</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3696" rS="true" s="2.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">railgun</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3697" rS="true" s="2.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">swarmer</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3698" rS="true" s="1.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_miniblaster</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3699" rS="true" s="1.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">filgap_saturation_launcher</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3700" rS="true" s="2.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">dagger_wing</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3701" rS="true" s="5.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">gladius_wing</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3702" rS="true" s="1.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">longbow_wing</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3703" rS="true" s="2.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">mining_drone_wing</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3704" rS="true" s="3.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">missp_patrol_craft_wing</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3705" rS="true" s="5.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">piranha_wing</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3706" rS="true" s="2.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">talon_wing</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3707" rS="true" s="3.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">tahlan_Valacor_hunter_wing</d>
								<c ref="3655"/>
							</CIStack>
							<CIStack z="3708" rS="true" s="1.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
								<d cl="st">de_woodpecker_wing</d>
								<c ref="3655"/>
							</CIStack>
						</s>
						<c z="3709">
							<value>0.0</value>
						</c>
						<mS z="3710" nP="" nSf="pirates" nS="false" oSML="false">
							<m z="3711">
								<FMmbr z="3712" o="0" sid="tahlan_nelson_Hull" sN="Short Change Hero" t="SHIP" iF="false" id="bbb57a" sUN="false" civ="false" cCiv="false">
									<rT z="3713" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3712"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3714" o="0" sid="tahlan_nelson_Hull" sN="Shadowless World" t="SHIP" iF="false" id="bbb57c" sUN="false" civ="false" cCiv="false">
									<rT z="3715" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3714"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3716" o="0" sid="dominator_Hull" sN="Nandi" t="SHIP" iF="false" id="bbb57e" sUN="false" civ="false" cCiv="false">
									<rT z="3717" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3716"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3718" o="0" sid="mora_Hull" sN="Chronos" t="SHIP" iF="false" id="bbb6b8" sUN="false" civ="false" cCiv="false">
									<rT z="3719" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3718"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3720" o="0" sid="gryphon_Hull" sN="Killer-trap" t="SHIP" iF="false" id="bbb580" sUN="false" civ="false" cCiv="false">
									<rT z="3721" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3720"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3722" o="0" sid="filgap_opportunity_Hull" sN="Liberation Please" t="SHIP" iF="false" id="bbb66e" sUN="false" civ="false" cCiv="false">
									<rT z="3723" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3722"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3724" o="0" sid="missp_starliner_battlecarrier_Hull" sN="Skvader" t="SHIP" iF="false" id="bbb670" sUN="false" civ="false" cCiv="false">
									<rT z="3725" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3724"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3726" o="0" sid="uw_barbarian_Hull" sN="Pontianak" t="SHIP" iF="false" id="bbb672" sUN="false" civ="false" cCiv="false">
									<rT z="3727" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3726"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3728" o="0" sid="eradicator_pirates_Hull" sN="Black Dagger" t="SHIP" iF="false" id="bbb674" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3729" hId="eradicator_pirates_default_D" v="0" c="0" hVId="eradicator_pirates_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3730"/>
										<sM z="3731"/>
										<wng z="3732"/>
										<wG z="3733"/>
										<hM z="3734">
											<st>damaged_mounts</st>
										</hM>
										<pM z="3735">
											<st>damaged_mounts</st>
										</pM>
										<sMods z="3736"/>
										<sModdedBuiltIns z="3737"/>
										<suM z="3738"/>
									</savedVariant>
									<rT z="3739" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3728"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3740" o="0" sid="filgap_adjudicator_Hull" sN="Cosmological Constant" t="SHIP" iF="false" id="bbb676" sUN="false" civ="false" cCiv="false">
									<rT z="3741" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3740"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3742" o="0" sid="falcon_Hull" sN="Sun Invisible" t="SHIP" iF="false" id="bbb6ba" sUN="false" civ="false" cCiv="false">
									<rT z="3743" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3742"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3744" o="0" sid="BSC_Starliner_MK2_Hull" sN="Tjinimin" t="SHIP" iF="false" id="bbb678" sUN="false" civ="false" cCiv="false">
									<rT z="3745" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3744"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3746" o="0" sid="BSC_Brigantine_Hull" sN="Kelpie" t="SHIP" iF="false" id="bbb67a" sUN="false" civ="false" cCiv="false">
									<rT z="3747" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3746"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3748" o="0" sid="colossus3_Hull" sN="The Gold-seekers" t="SHIP" iF="false" id="bbb67c" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3749" hId="colossus3_default_D" v="0" c="0" hVId="colossus3_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3750"/>
										<sM z="3751"/>
										<wng z="3752"/>
										<wG z="3753"/>
										<hM z="3754">
											<st>civgrade</st>
											<st>converted_bay</st>
											<st>ground_support</st>
											<st>comp_hull</st>
										</hM>
										<pM z="3755">
											<st>comp_hull</st>
										</pM>
										<sMods z="3756"/>
										<sModdedBuiltIns z="3757"/>
										<suM z="3758"/>
									</savedVariant>
									<rT z="3759" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3748"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3760" o="0" sid="colossus_Hull" sN="Burned Once" t="SHIP" iF="false" id="bbb67e" sUN="false" civ="false" cCiv="false">
									<rT z="3761" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3760"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3762" o="0" sid="shrike_pirates_Hull" sN="Our Fair City" t="SHIP" iF="false" id="bbb680" sUN="false" civ="false" cCiv="false">
									<rT z="3763" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3762"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3764" o="0" sid="XHAN_Ketsil_export_Hull" sN="Clean Escape" t="SHIP" iF="false" id="bbb6bc" sUN="false" civ="false" cCiv="false">
									<rT z="3765" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3764"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3766" o="0" sid="nebula_Hull" sN="Betrayal of Ideals" t="SHIP" iF="false" id="bbb682" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3767" hId="nebula_default_D" v="0" c="0" hVId="nebula_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3768"/>
										<sM z="3769"/>
										<wng z="3770"/>
										<wG z="3771"/>
										<hM z="3772">
											<st>civgrade</st>
											<st>degraded_drive_field</st>
										</hM>
										<pM z="3773">
											<st>degraded_drive_field</st>
										</pM>
										<sMods z="3774"/>
										<sModdedBuiltIns z="3775"/>
										<suM z="3776"/>
									</savedVariant>
									<rT z="3777" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3766"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3778" o="0" sid="de_regulus_Hull" sN="Song at the Ready" t="SHIP" iF="false" id="bbb582" sUN="false" civ="false" cCiv="false">
									<rT z="3779" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3778"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3780" o="0" sid="de_regulus_Hull" sN="Minyades" t="SHIP" iF="false" id="bbb584" sUN="false" civ="false" cCiv="false">
									<rT z="3781" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3780"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3782" o="0" sid="de_jackdaw_Hull" sN="Chocolate Insomnia" t="SHIP" iF="false" id="bbb586" sUN="false" civ="false" cCiv="false">
									<rT z="3783" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3782"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3784" o="0" sid="de_jackdaw_Hull" sN="Nostalgia for Infinity" t="SHIP" iF="false" id="bbb588" sUN="false" civ="false" cCiv="false">
									<rT z="3785" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3784"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3786" o="0" sid="gremlin_Hull" sN="Starbreaker" t="SHIP" iF="false" id="bbb6be" sUN="false" civ="false" cCiv="false">
									<rT z="3787" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3786"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3788" o="0" sid="cerberus_d_pirates_Hull" sN="The Golden Girl" t="SHIP" iF="false" id="bbb684" sUN="false" civ="false" cCiv="false">
									<savedVariant z="3789" hId="cerberus_d_pirates_default_D" v="0" c="0" hVId="cerberus_d_pirates_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
										<wpn z="3790"/>
										<sM z="3791"/>
										<wng z="3792"/>
										<wG z="3793"/>
										<hM z="3794">
											<st>rugged</st>
											<st>shielded_holds</st>
											<st>degraded_life_support</st>
										</hM>
										<pM z="3795">
											<st>degraded_life_support</st>
										</pM>
										<sMods z="3796"/>
										<sModdedBuiltIns z="3797"/>
										<suM z="3798"/>
									</savedVariant>
									<rT z="3799" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3788"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3800" o="0" sid="lasher_Hull" sN="The Dead Don't Vote" t="SHIP" iF="false" id="bbb6c0" sUN="false" civ="false" cCiv="false">
									<rT z="3801" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3800"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3802" o="0" sid="BSC_Brave_Hull" sN="Once Upon a Monbeast" t="SHIP" iF="false" id="bbb6c2" sUN="false" civ="false" cCiv="false">
									<rT z="3803" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3802"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3804" o="0" sid="de_mynah_Hull" sN="Jingwei" t="SHIP" iF="false" id="bbb58a" sUN="false" civ="false" cCiv="false">
									<rT z="3805" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3804"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3806" o="0" sid="de_mynah_Hull" sN="Ghost Pit" t="SHIP" iF="false" id="bbb58c" sUN="false" civ="false" cCiv="false">
									<rT z="3807" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3806"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3808" o="0" sid="mudskipper_Hull" sN="Death's Last Bargain" t="SHIP" iF="false" id="bbb686" sUN="false" civ="false" cCiv="false">
									<rT z="3809" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3808"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3810" o="0" sid="mudskipper_Hull" sN="Among the Blobs" t="SHIP" iF="false" id="bbb688" sUN="false" civ="false" cCiv="false">
									<rT z="3811" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3810"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3812" o="0" sid="kite_Hull" sN="Mind Your Own Business" t="SHIP" iF="false" id="bbb6c4" sUN="false" civ="false" cCiv="false">
									<rT z="3813" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3812"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3814" o="0" sid="kite_Hull" sN="Ladies Only" t="SHIP" iF="false" id="bbb6c6" sUN="false" civ="false" cCiv="false">
									<rT z="3815" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3814"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
								<FMmbr z="3816" o="0" sid="kite_Hull" sN="What Entropy Means to Me" t="SHIP" iF="false" id="bbb6c8" sUN="false" civ="false" cCiv="false">
									<rT z="3817" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
										<m ref="3816"/>
									</rT>
									<fD ref="3710"/>
								</FMmbr>
							</m>
						</mS>
					</c>
					<iGR z="3818" serialization="custom">
						<Random>
							<default>
								<s>13330440473409</s>
								<n>0.0</n>
								<h>false</h>
							</default>
						</Random>
					</iGR>
				</p>
				<f ref="2093"/>
			</Submarket>
			<Submarket z="3819" s="storage">
				<m ref="2849"/>
				<p cl="NexStoreSubmkt" z="3820" mSWUI="30.0" msSWU="4099.626" sLCU="4099.626" paid="false">
					<m cl="Market" ref="2849"/>
					<s cl="Submarket" ref="3819"/>
					<c cl="CargoData" z="3821" uS="true" mC="1000.0" sU="50.0" mF="500.0" mP="750.0" fT="false">
						<s z="3822"/>
						<c z="3823">
							<value>0.0</value>
						</c>
						<mS z="3824" nP="ISS" nSf="player" nS="false" oSML="false">
							<m z="3825"/>
						</mS>
					</c>
					<iGR z="3826" serialization="custom">
						<Random>
							<default>
								<s>272489457934904</s>
								<n>0.0</n>
								<h>false</h>
							</default>
						</Random>
					</iGR>
				</p>
				<f ref="1084"/>
			</Submarket>
			<Submarket z="3827" s="IndEvo_ReqCenterMarket">
				<m ref="2849"/>
				<p cl="indevo.submarkets.RequisitionsCenterSubmarketPlugin" z="3828" mSWUI="30.0" msSWU="9.731686" sLCU="0.0">
					<m cl="Market" ref="2849"/>
					<s cl="Submarket" ref="3827"/>
					<c cl="CargoData" z="3829" uS="true" mC="1000.0" sU="296.0" mF="500.0" mP="750.0" fT="false">
						<s z="3830">
							<CIStack z="3831" rS="true" s="10.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">heavymortar</d>
								<c ref="3829"/>
							</CIStack>
							<CIStack z="3832" rS="true" s="8.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">miningblaster</d>
								<c ref="3829"/>
							</CIStack>
							<CIStack z="3833" rS="true" s="8.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">shredder</d>
								<c ref="3829"/>
							</CIStack>
							<CIStack z="3834" rS="true" s="2.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">arbalest</d>
								<c ref="3829"/>
							</CIStack>
							<CIStack z="3835" rS="true" s="2.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
								<d cl="st">filgap_davidsystem</d>
								<c ref="3829"/>
							</CIStack>
							<CIStack z="3836" rS="true" s="22.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">maiden</d>
								<c ref="3829"/>
							</CIStack>
							<CIStack z="3837" rS="true" s="19.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">flicker_pdl</d>
								<c ref="3829"/>
							</CIStack>
							<CIStack z="3838" rS="true" s="16.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">lightmortar</d>
								<c ref="3829"/>
							</CIStack>
							<CIStack z="3839" rS="true" s="11.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">wpnxt_minivulcan</d>
								<c ref="3829"/>
							</CIStack>
							<CIStack z="3840" rS="true" s="10.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">annihilator</d>
								<c ref="3829"/>
							</CIStack>
							<CIStack z="3841" rS="true" s="10.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
								<d cl="st">hammer_single</d>
								<c ref="3829"/>
							</CIStack>
						</s>
						<c z="3842">
							<value>0.0</value>
						</c>
						<mS z="3843" nP="HIS GREAT AND ALL POWERFUL MAJESTY SIR HARTLEY THE FIRST" nSf="reqSellStorageColour" nS="false" oSML="false">
							<m z="3844"/>
						</mS>
					</c>
					<iGR z="3845" serialization="custom">
						<Random>
							<default>
								<s>172896707889507</s>
								<n>0.0</n>
								<h>false</h>
							</default>
						</Random>
					</iGR>
					<isSetForRemoval>false</isSetForRemoval>
					<playerPaidToUnlock>true</playerPaidToUnlock>
				</p>
				<f z="3846">
					<id>reqSellStorageColour</id>
					<memory z="3847">
						<d z="3848">
							<e>
								<st>$nex_max_relations</st>
								<map z="3849"/>
							</e>
						</d>
					</memory>
					<illegal z="3850"/>
					<shipsWhenImporting z="3851"/>
					<knownShips z="3852"/>
					<knownWeapons z="3853"/>
					<knownFighters z="3854"/>
					<knownIndustries z="3855"/>
					<knownHullMods z="3856"/>
					<priorityShips z="3857"/>
					<priorityWeapons z="3858"/>
					<priorityFighters z="3859"/>
					<priorityHullMods z="3860"/>
					<hullFrequency cl="l-h-m" z="3861"/>
					<variantOverrides cl="l-h-m" z="3862"/>
					<overriddenHulls z="3863"/>
					<doctrine z="3864">
						<warships>4</warships>
						<carriers>2</carriers>
						<phaseShips>1</phaseShips>
						<officerQuality>2</officerQuality>
						<shipQuality>3</shipQuality>
						<numShips>2</numShips>
						<shipSize>3</shipSize>
						<aggression>3</aggression>
						<fleets>3</fleets>
						<autofitRandomizeProbability>0.0</autofitRandomizeProbability>
						<combatFreighterProbability>0.0</combatFreighterProbability>
						<combatFreighterCombatUseFraction>0.0</combatFreighterCombatUseFraction>
						<combatFreighterCombatUseFractionWhenPriority>0.0</combatFreighterCombatUseFractionWhenPriority>
						<commanderSkillsShuffleProbability>0.0</commanderSkillsShuffleProbability>
						<strictComposition>false</strictComposition>
						<commanderSkills z="3865"/>
						<officerSkillsShuffleProbability>0.0</officerSkillsShuffleProbability>
						<officerSkills z="3866"/>
					</doctrine>
					<production z="3867">
						<interrupted z="3868"/>
						<current z="3869"/>
						<faction cl="Faction" ref="3846"/>
						<accruedProduction>0</accruedProduction>
						<costMult>1.0</costMult>
					</production>
					<weaponTimestamps cl="l-h-m" z="3870"/>
					<fighterTimestamps cl="l-h-m" z="3871"/>
					<shipTimestamps cl="l-h-m" z="3872"/>
					<showInIntelTabOverridden>false</showInIntelTabOverridden>
					<isShowInIntelTab>false</isShowInIntelTab>
					<autoEnableKnownShips>false</autoEnableKnownShips>
					<autoEnableKnownWeapons>false</autoEnableKnownWeapons>
					<autoEnableKnownFighters>false</autoEnableKnownFighters>
					<autoEnableKnownHullmods>false</autoEnableKnownHullmods>
					<secondaryColorSegmentsOverride>0</secondaryColorSegmentsOverride>
				</f>
			</Submarket>
		</submarkets>
		<memory cl="Memory" z="3873">
			<d z="3874">
				<e>
					<st>$patrol</st>
					<bp>true</bp>
				</e>
				<e>
					<st>$military</st>
					<bp>true</bp>
				</e>
				<e>
					<st>$startingFactionId</st>
					<st>sindrian_diktat</st>
				</e>
				<e>
					<st>$nex_existed_at_start</st>
					<bp>true</bp>
				</e>
				<e>
					<st>$startingFreeMarket</st>
					<bp>false</bp>
				</e>
				<e>
					<st>$nex_fleetPoolPointsLastTick</st>
					<fp>1.14</fp>
				</e>
				<e>
					<st>$nex_groundPoolPointsLastTick</st>
					<fp>1.548</fp>
				</e>
				<e>
					<st>$IndEvo_ArtilleryStation_Destroyed</st>
					<bp>false</bp>
				</e>
				<e>
					<st>$visitedBefore</st>
					<bp>true</bp>
				</e>
				<e>
					<st>$mmm_mbm_random</st>
					<Random z="3875" serialization="custom">
						<Random>
							<default>
								<s>2086736899103</s>
								<n>0.0</n>
								<h>false</h>
							</default>
						</Random>
					</Random>
				</e>
				<e>
					<st>$mmm_mbm_data</st>
					<map z="3876">
						<e>
							<st>dsp</st>
							<Lp-array z="3877">
								<Lp>1</Lp>
								<Lp>-55313423768563</Lp>
								<Lp>7287617083348905377</Lp>
							</Lp-array>
						</e>
						<e>
							<st>DiktatLobsterBarEvent</st>
							<Lp-array z="3878">
								<Lp>0</Lp>
								<Lp>-55314153050692</Lp>
								<Lp>2530809707949579500</Lp>
							</Lp-array>
						</e>
						<e>
							<st>LuddicCraftBarEvent</st>
							<Lp-array z="3879">
								<Lp>0</Lp>
								<Lp>-55313064344906</Lp>
								<Lp>5686259250737909924</Lp>
							</Lp-array>
						</e>
						<e>
							<st>seco</st>
							<Lp-array z="3880">
								<Lp>2</Lp>
								<Lp>-55314975432064</Lp>
								<Lp>4430062656107913574</Lp>
							</Lp-array>
						</e>
						<e>
							<st>proCom</st>
							<Lp-array z="3881">
								<Lp>0</Lp>
								<Lp>-55314513693832</Lp>
								<Lp>-7950904705065096628</Lp>
							</Lp-array>
						</e>
						<e>
							<st>tabo</st>
							<Lp-array z="3882">
								<Lp>0</Lp>
								<Lp>-55313881793966</Lp>
								<Lp>5763274213057233056</Lp>
							</Lp-array>
						</e>
						<e>
							<st>HistorianBarEvent</st>
							<Lp-array z="3883">
								<Lp>2</Lp>
								<Lp>-55316483329000</Lp>
								<Lp>1046740478922819014</Lp>
							</Lp-array>
						</e>
						<e>
							<st>mcb</st>
							<Lp-array z="3884">
								<Lp>0</Lp>
								<Lp>-55313034577669</Lp>
								<Lp>7078595447385000514</Lp>
							</Lp-array>
						</e>
						<e>
							<st>nex_msb</st>
							<Lp-array z="3885">
								<Lp>0</Lp>
								<Lp>-55313040287813</Lp>
								<Lp>1992938476741544792</Lp>
							</Lp-array>
						</e>
						<e>
							<st>hijack</st>
							<Lp-array z="3886">
								<Lp>2</Lp>
								<Lp>-55314877505648</Lp>
								<Lp>3303451028019906232</Lp>
							</Lp-array>
						</e>
						<e>
							<st>ddro</st>
							<Lp-array z="3887">
								<Lp>0</Lp>
								<Lp>-55313127876974</Lp>
								<Lp>-7575238033386163524</Lp>
							</Lp-array>
						</e>
						<e>
							<st>LuddicFarmerBarEvent</st>
							<Lp-array z="3888">
								<Lp>0</Lp>
								<Lp>-55314149558358</Lp>
								<Lp>-3832159818052017550</Lp>
							</Lp-array>
						</e>
						<e>
							<st>ucb</st>
							<Lp-array z="3889">
								<Lp>1</Lp>
								<Lp>-55313414516976</Lp>
								<Lp>-1528928512118634191</Lp>
							</Lp-array>
						</e>
						<e>
							<st>cpc</st>
							<Lp-array z="3890">
								<Lp>2</Lp>
								<Lp>-55315019685268</Lp>
								<Lp>5388489127840045808</Lp>
							</Lp-array>
						</e>
						<e>
							<st>CorruptPLClerkSuppliesBarEvent</st>
							<Lp-array z="3891">
								<Lp>0</Lp>
								<Lp>-55314025407467</Lp>
								<Lp>-2696430550060811969</Lp>
							</Lp-array>
						</e>
						<e>
							<st>smug</st>
							<Lp-array z="3892">
								<Lp>0</Lp>
								<Lp>-55314463076906</Lp>
								<Lp>1379958040145247749</Lp>
							</Lp-array>
						</e>
						<e>
							<st>extr</st>
							<Lp-array z="3893">
								<Lp>1</Lp>
								<Lp>-55313246287069</Lp>
								<Lp>3744333558314630626</Lp>
							</Lp-array>
						</e>
						<e>
							<st>cpm</st>
							<Lp-array z="3894">
								<Lp>1</Lp>
								<Lp>-55313464892806</Lp>
								<Lp>6932216049521491934</Lp>
							</Lp-array>
						</e>
						<e>
							<st>dhi</st>
							<Lp-array z="3895">
								<Lp>0</Lp>
								<Lp>-55314686947018</Lp>
								<Lp>-2693445477886428783</Lp>
							</Lp-array>
						</e>
						<e>
							<st>ssat</st>
							<Lp-array z="3896">
								<Lp>1</Lp>
								<Lp>-55313239215389</Lp>
								<Lp>-7467070726150405228</Lp>
							</Lp-array>
						</e>
						<e>
							<st>DeliveryBarEvent</st>
							<Lp-array z="3897">
								<Lp>0</Lp>
								<Lp>-55313048653463</Lp>
								<Lp>-1189164970889581437</Lp>
							</Lp-array>
						</e>
						<e>
							<st>QuartermasterCargoSwapBarEvent</st>
							<Lp-array z="3898">
								<Lp>0</Lp>
								<Lp>-55314344787606</Lp>
								<Lp>4056274920169907659</Lp>
							</Lp-array>
						</e>
						<e>
							<st>MercsOnTheRunBarEvent</st>
							<Lp-array z="3899">
								<Lp>1</Lp>
								<Lp>-55313762029256</Lp>
								<Lp>-3448112908015935945</Lp>
							</Lp-array>
						</e>
						<e>
							<st>lpt</st>
							<Lp-array z="3900">
								<Lp>0</Lp>
								<Lp>-55313270041268</Lp>
								<Lp>656591193587357524</Lp>
							</Lp-array>
						</e>
						<e>
							<st>ttscmtwo</st>
							<Lp-array z="3901">
								<Lp>0</Lp>
								<Lp>-55313593438448</Lp>
								<Lp>-1161175629715273527</Lp>
							</Lp-array>
						</e>
						<e>
							<st>cheapCom</st>
							<Lp-array z="3902">
								<Lp>2</Lp>
								<Lp>-55315159990758</Lp>
								<Lp>4776927188941605402</Lp>
							</Lp-array>
						</e>
						<e>
							<st>nex_bShip</st>
							<Lp-array z="3903">
								<Lp>0</Lp>
								<Lp>-55314445347445</Lp>
								<Lp>6922727011023610176</Lp>
							</Lp-array>
						</e>
						<e>
							<st>dcom</st>
							<Lp-array z="3904">
								<Lp>1</Lp>
								<Lp>-55313397798531</Lp>
								<Lp>1534197543282192942</Lp>
							</Lp-array>
						</e>
						<e>
							<st>sShip</st>
							<Lp-array z="3905">
								<Lp>2</Lp>
								<Lp>-55314995266616</Lp>
								<Lp>-8289656369525097299</Lp>
							</Lp-array>
						</e>
						<e>
							<st>jabr</st>
							<Lp-array z="3906">
								<Lp>1</Lp>
								<Lp>-55313094482931</Lp>
								<Lp>-6197575799207430575</Lp>
							</Lp-array>
						</e>
						<e>
							<st>TriTachLoanBarEvent</st>
							<Lp-array z="3907">
								<Lp>0</Lp>
								<Lp>-55313110723141</Lp>
								<Lp>803199379278201798</Lp>
							</Lp-array>
						</e>
						<e>
							<st>hmdf</st>
							<Lp-array z="3908">
								<Lp>2</Lp>
								<Lp>-55314890626949</Lp>
								<Lp>-5898247738773435397</Lp>
							</Lp-array>
						</e>
						<e>
							<st>sitm</st>
							<Lp-array z="3909">
								<Lp>2</Lp>
								<Lp>-55314961132644</Lp>
								<Lp>8948683183666137080</Lp>
							</Lp-array>
						</e>
						<e>
							<st>locrlf</st>
							<Lp-array z="3910">
								<Lp>0</Lp>
								<Lp>-55314124039864</Lp>
								<Lp>7572430765319503156</Lp>
							</Lp-array>
						</e>
						<e>
							<st>TriTachMajorLoanBarEvent</st>
							<Lp-array z="3911">
								<Lp>0</Lp>
								<Lp>-55314306704159</Lp>
								<Lp>-9170477047183456956</Lp>
							</Lp-array>
						</e>
						<e>
							<st>psb</st>
							<Lp-array z="3912">
								<Lp>0</Lp>
								<Lp>-55313289935970</Lp>
								<Lp>7238312494542839265</Lp>
							</Lp-array>
						</e>
						<e>
							<st>nex_dcom</st>
							<Lp-array z="3913">
								<Lp>0</Lp>
								<Lp>-55314351899496</Lp>
								<Lp>-3654399666932470085</Lp>
							</Lp-array>
						</e>
					</map>
				</e>
				<e>
					<st>$mmm_mbm_last_added</st>
					<Lp>-55316483329000</Lp>
				</e>
				<e>
					<st>$ST_SmallFreightMissions</st>
					<list z="3914">
						<Util.MissionGen.USLMissionDetails z="3915">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>hera</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>13447</reward>
							<escrow>0</escrow>
							<quantity>487</quantity>
							<unitPrice>0</unitPrice>
							<duration>22.0</duration>
							<distance>4.4212666</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3916">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>ryzan_supercomplex_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>sindrian_diktat</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>9858</reward>
							<escrow>0</escrow>
							<quantity>301</quantity>
							<unitPrice>0</unitPrice>
							<duration>26.0</duration>
							<distance>6.7529626</distance>
							<expiration>10.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3917">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>volturn</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>sindrian_diktat</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>9120</reward>
							<escrow>0</escrow>
							<quantity>320</quantity>
							<unitPrice>0</unitPrice>
							<duration>8.0</duration>
							<distance>0.0</distance>
							<expiration>2.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3918">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>Ymenn</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>apocrita_association</destinationFactionID>
							<commodityID>heavy_machinery</commodityID>
							<reward>18844</reward>
							<escrow>0</escrow>
							<quantity>481</quantity>
							<unitPrice>0</unitPrice>
							<duration>28.0</duration>
							<distance>6.5024996</distance>
							<expiration>10.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3919">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>Apocrita</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>apocrita_association</destinationFactionID>
							<commodityID>metals</commodityID>
							<reward>5020</reward>
							<escrow>0</escrow>
							<quantity>236</quantity>
							<unitPrice>0</unitPrice>
							<duration>32.0</duration>
							<distance>6.5024996</distance>
							<expiration>6.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3920">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>ii_cydonia</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>tritachyon</destinationFactionID>
							<commodityID>rare_metals</commodityID>
							<reward>16278</reward>
							<escrow>0</escrow>
							<quantity>343</quantity>
							<unitPrice>0</unitPrice>
							<duration>23.0</duration>
							<distance>5.0982842</distance>
							<expiration>3.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3921">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>vic_planet_phlegethon_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>tritachyon</destinationFactionID>
							<commodityID>metals</commodityID>
							<reward>5271</reward>
							<escrow>0</escrow>
							<quantity>247</quantity>
							<unitPrice>0</unitPrice>
							<duration>28.0</duration>
							<distance>7.3186407</distance>
							<expiration>6.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3922">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>ii_saltus_divinus</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>luddic_church</destinationFactionID>
							<commodityID>heavy_machinery</commodityID>
							<reward>19527</reward>
							<escrow>0</escrow>
							<quantity>479</quantity>
							<unitPrice>0</unitPrice>
							<duration>32.0</duration>
							<distance>8.730694</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3923">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>market_system_1c5e:planet_4_L5</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>14017</reward>
							<escrow>0</escrow>
							<quantity>300</quantity>
							<unitPrice>0</unitPrice>
							<duration>103.0</duration>
							<distance>30.911673</distance>
							<expiration>2.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3924">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>tahlan_lethia_p05_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>11701</reward>
							<escrow>0</escrow>
							<quantity>244</quantity>
							<unitPrice>0</unitPrice>
							<duration>98.0</duration>
							<distance>30.127272</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3925">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>asgard1_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>metals</commodityID>
							<reward>3908</reward>
							<escrow>0</escrow>
							<quantity>189</quantity>
							<unitPrice>0</unitPrice>
							<duration>12.0</duration>
							<distance>2.4738634</distance>
							<expiration>4.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3926">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>scrumpy</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>tritachyon</destinationFactionID>
							<commodityID>rare_metals</commodityID>
							<reward>7987</reward>
							<escrow>0</escrow>
							<quantity>148</quantity>
							<unitPrice>0</unitPrice>
							<duration>30.0</duration>
							<distance>7.750161</distance>
							<expiration>6.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3927">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>market_system_235b:planet_2</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>persean</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>7404</reward>
							<escrow>0</escrow>
							<quantity>175</quantity>
							<unitPrice>0</unitPrice>
							<duration>61.0</duration>
							<distance>17.76232</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
					</list>
				</e>
				<e>
					<st>$ST_MediumFreightMissions</st>
					<list z="3928">
						<Util.MissionGen.USLMissionDetails z="3929">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>chicomoztoc</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>27829</reward>
							<escrow>0</escrow>
							<quantity>1112</quantity>
							<unitPrice>0</unitPrice>
							<duration>28.0</duration>
							<distance>5.3368998</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3930">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>ryzan_supercomplex_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>sindrian_diktat</destinationFactionID>
							<commodityID>heavy_machinery</commodityID>
							<reward>28707</reward>
							<escrow>0</escrow>
							<quantity>819</quantity>
							<unitPrice>0</unitPrice>
							<duration>26.0</duration>
							<distance>6.7529626</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3931">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>market_brahmin</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>shadow_industry</destinationFactionID>
							<commodityID>heavy_machinery</commodityID>
							<reward>21466</reward>
							<escrow>0</escrow>
							<quantity>666</quantity>
							<unitPrice>0</unitPrice>
							<duration>11.0</duration>
							<distance>2.1868927</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3932">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>orthrus</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>41004</reward>
							<escrow>0</escrow>
							<quantity>1599</quantity>
							<unitPrice>0</unitPrice>
							<duration>28.0</duration>
							<distance>6.702658</distance>
							<expiration>8.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3933">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>Apocrita</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>apocrita_association</destinationFactionID>
							<commodityID>IndEvo_parts</commodityID>
							<reward>46219</reward>
							<escrow>0</escrow>
							<quantity>1534</quantity>
							<unitPrice>0</unitPrice>
							<duration>27.0</duration>
							<distance>6.5024996</distance>
							<expiration>3.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3934">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>eochu_bres</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>tritachyon</destinationFactionID>
							<commodityID>metals</commodityID>
							<reward>22798</reward>
							<escrow>0</escrow>
							<quantity>1715</quantity>
							<unitPrice>0</unitPrice>
							<duration>20.0</duration>
							<distance>3.2268405</distance>
							<expiration>3.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3935">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>scrumpy</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>tritachyon</destinationFactionID>
							<commodityID>heavy_machinery</commodityID>
							<reward>39555</reward>
							<escrow>0</escrow>
							<quantity>1109</quantity>
							<unitPrice>0</unitPrice>
							<duration>36.0</duration>
							<distance>7.750161</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3936">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>clusterOrbital_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>xhanempire</destinationFactionID>
							<commodityID>metals</commodityID>
							<reward>31872</reward>
							<escrow>0</escrow>
							<quantity>1854</quantity>
							<unitPrice>0</unitPrice>
							<duration>63.0</duration>
							<distance>18.833548</distance>
							<expiration>9.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3937">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>Pamed_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>unitedpamed</destinationFactionID>
							<commodityID>rare_metals</commodityID>
							<reward>53432</reward>
							<escrow>0</escrow>
							<quantity>1206</quantity>
							<unitPrice>0</unitPrice>
							<duration>43.0</duration>
							<distance>10.034565</distance>
							<expiration>6.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3938">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>theramin</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>shadow_industry</destinationFactionID>
							<commodityID>rare_metals</commodityID>
							<reward>33628</reward>
							<escrow>0</escrow>
							<quantity>835</quantity>
							<unitPrice>0</unitPrice>
							<duration>18.0</duration>
							<distance>4.570832</distance>
							<expiration>4.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3939">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>athulf</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>persean</destinationFactionID>
							<commodityID>heavy_machinery</commodityID>
							<reward>67463</reward>
							<escrow>0</escrow>
							<quantity>1963</quantity>
							<unitPrice>0</unitPrice>
							<duration>30.0</duration>
							<distance>5.6449094</distance>
							<expiration>4.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3940">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>market_system_1c5e:planet_4_L5</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>40434</reward>
							<escrow>0</escrow>
							<quantity>1105</quantity>
							<unitPrice>0</unitPrice>
							<duration>104.0</duration>
							<distance>30.911673</distance>
							<expiration>10.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3941">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>ilm</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>heavy_machinery</commodityID>
							<reward>30636</reward>
							<escrow>0</escrow>
							<quantity>921</quantity>
							<unitPrice>0</unitPrice>
							<duration>21.0</duration>
							<distance>3.8581083</distance>
							<expiration>8.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
					</list>
				</e>
				<e>
					<st>$ST_LargeFreightMissions</st>
					<list z="3942">
						<Util.MissionGen.USLMissionDetails z="3943">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>nortia</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>109143</reward>
							<escrow>0</escrow>
							<quantity>5430</quantity>
							<unitPrice>0</unitPrice>
							<duration>10.0</duration>
							<distance>0.0</distance>
							<expiration>11.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3944">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>madeira</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>persean</destinationFactionID>
							<commodityID>heavy_machinery</commodityID>
							<reward>118560</reward>
							<escrow>0</escrow>
							<quantity>3762</quantity>
							<unitPrice>0</unitPrice>
							<duration>27.0</duration>
							<distance>7.4048967</distance>
							<expiration>4.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3945">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>vic_planet_megaera_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>vic</destinationFactionID>
							<commodityID>IndEvo_parts</commodityID>
							<reward>126553</reward>
							<escrow>0</escrow>
							<quantity>4658</quantity>
							<unitPrice>0</unitPrice>
							<duration>29.0</duration>
							<distance>7.3186407</distance>
							<expiration>2.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3946">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>ii_embassy</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>interstellarimperium</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>113895</reward>
							<escrow>0</escrow>
							<quantity>5214</quantity>
							<unitPrice>0</unitPrice>
							<duration>21.0</duration>
							<distance>4.3384905</distance>
							<expiration>8.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3947">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>diableavionics_prison</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>diableavionics</destinationFactionID>
							<commodityID>rare_metals</commodityID>
							<reward>257725</reward>
							<escrow>0</escrow>
							<quantity>5890</quantity>
							<unitPrice>0</unitPrice>
							<duration>57.0</duration>
							<distance>16.701872</distance>
							<expiration>2.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3948">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>ilm</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>54170</reward>
							<escrow>0</escrow>
							<quantity>2502</quantity>
							<unitPrice>0</unitPrice>
							<duration>16.0</duration>
							<distance>3.8581083</distance>
							<expiration>5.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3949">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>nepheria</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>IndEvo_parts</commodityID>
							<reward>89940</reward>
							<escrow>0</escrow>
							<quantity>3403</quantity>
							<unitPrice>0</unitPrice>
							<duration>29.0</duration>
							<distance>5.7589602</distance>
							<expiration>10.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3950">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>market_system_2525:planet_3</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>unitedpamed</destinationFactionID>
							<commodityID>heavy_machinery</commodityID>
							<reward>154963</reward>
							<escrow>0</escrow>
							<quantity>3813</quantity>
							<unitPrice>0</unitPrice>
							<duration>79.0</duration>
							<distance>24.026857</distance>
							<expiration>8.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3951">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>khuno_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>diableavionics</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>122676</reward>
							<escrow>0</escrow>
							<quantity>5616</quantity>
							<unitPrice>0</unitPrice>
							<duration>25.0</duration>
							<distance>4.3384905</distance>
							<expiration>9.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3952">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>vayra_refugestationmarket</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>metals</commodityID>
							<reward>40963</reward>
							<escrow>0</escrow>
							<quantity>3120</quantity>
							<unitPrice>0</unitPrice>
							<duration>39.0</duration>
							<distance>9.141664</distance>
							<expiration>3.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3953">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>orbitalOne_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>xhanempire</destinationFactionID>
							<commodityID>supplies</commodityID>
							<reward>158749</reward>
							<escrow>0</escrow>
							<quantity>5737</quantity>
							<unitPrice>0</unitPrice>
							<duration>63.0</duration>
							<distance>18.833548</distance>
							<expiration>10.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3954">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>tahlan_lethia_p05_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>IndEvo_parts</commodityID>
							<reward>218424</reward>
							<escrow>0</escrow>
							<quantity>5751</quantity>
							<unitPrice>0</unitPrice>
							<duration>103.0</duration>
							<distance>30.127272</distance>
							<expiration>10.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3955">
							<missionType>FREIGHT</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>yesod</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>interstellarimperium</destinationFactionID>
							<commodityID>heavy_machinery</commodityID>
							<reward>153606</reward>
							<escrow>0</escrow>
							<quantity>5195</quantity>
							<unitPrice>0</unitPrice>
							<duration>20.0</duration>
							<distance>3.8581083</distance>
							<expiration>9.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
					</list>
				</e>
				<e>
					<st>$ST_StandardParcelMissions</st>
					<list z="3956">
						<Util.MissionGen.USLMissionDetails z="3957">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>jangala</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>9380</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>17.0</duration>
							<distance>3.42965</distance>
							<expiration>2.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3958">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>eis_yami</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>vic</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>10838</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>23.0</duration>
							<distance>7.8447437</distance>
							<expiration>4.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3959">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>midgard_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>9066</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>16.0</duration>
							<distance>2.4738634</distance>
							<expiration>5.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3960">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>vic_planet_maria_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>11150</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>29.0</duration>
							<distance>8.791188</distance>
							<expiration>4.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3961">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>vic_planet_kalada_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>vic</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>11150</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>27.0</duration>
							<distance>8.791188</distance>
							<expiration>9.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3962">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>clusterOrbital_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>xhanempire</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>14465</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>49.0</duration>
							<distance>18.833548</distance>
							<expiration>8.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3963">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>vayra_kadur_revenantmarket</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>10873</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>23.0</duration>
							<distance>7.95</distance>
							<expiration>4.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3964">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>mirageIVmarket</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>xhanempire</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>10873</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>23.0</duration>
							<distance>7.95</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3965">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>tahlan_lethia_p05_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>18191</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>71.0</duration>
							<distance>30.127272</distance>
							<expiration>6.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3966">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>eventide</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>10461</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>24.0</duration>
							<distance>6.702658</distance>
							<expiration>3.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3967">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>market_penelope1</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>vic</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>10101</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>19.0</duration>
							<distance>5.612709</distance>
							<expiration>8.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3968">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>euripides</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>shadow_industry</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>9758</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>19.0</duration>
							<distance>4.570832</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3969">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>ii_hadrian</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>interstellarimperium</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>10138</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>22.0</duration>
							<distance>5.7238536</distance>
							<expiration>5.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
					</list>
				</e>
				<e>
					<st>$ST_ExpeditedParcelMissions</st>
					<list z="3970">
						<Util.MissionGen.USLMissionDetails z="3971">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>jangala</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>11086</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>12.0</duration>
							<distance>3.42965</distance>
							<expiration>4.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3972">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>tahlan_lethia_p05_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>21499</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>65.0</duration>
							<distance>30.127272</distance>
							<expiration>3.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3973">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>nergal_obs</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>sindrian_diktat</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>12187</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>16.0</duration>
							<distance>6.253199</distance>
							<expiration>2.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3974">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>tartessus</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>luddic_church</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>11854</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>15.0</duration>
							<distance>5.396758</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3975">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>salamanca</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>diableavionics</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>11441</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>15.0</duration>
							<distance>4.3384905</distance>
							<expiration>11.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3976">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>fikenhild</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>persean</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>11950</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>19.0</duration>
							<distance>5.6449094</distance>
							<expiration>5.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3977">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>vayra_refugestationmarket</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>13314</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>23.0</duration>
							<distance>9.141664</distance>
							<expiration>5.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3978">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>clusterOrbital_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>xhanempire</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>17095</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>41.0</duration>
							<distance>18.833548</distance>
							<expiration>3.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3979">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>diableavionics_prison</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>diableavionics</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>16262</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>40.0</duration>
							<distance>16.701872</distance>
							<expiration>11.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3980">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>chibog_station</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>11995</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>18.0</duration>
							<distance>5.7589602</distance>
							<expiration>4.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3981">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>hesperus</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>luddic_church</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>11854</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>16.0</duration>
							<distance>5.396758</distance>
							<expiration>5.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3982">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>diableavionics_ressource</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>diableavionics</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>16262</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>38.0</duration>
							<distance>16.701872</distance>
							<expiration>6.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3983">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>cerbrus</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>persean</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>11473</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>12.0</duration>
							<distance>4.4212666</distance>
							<expiration>7.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
					</list>
				</e>
				<e>
					<st>$ST_PriorityParcelMissions</st>
					<list z="3984">
						<Util.MissionGen.USLMissionDetails z="3985">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>jangala</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>13644</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>6.0</duration>
							<distance>3.42965</distance>
							<expiration>2.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3986">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>market_ii_pulvis</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>interstellarimperium</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>16190</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>21.0</duration>
							<distance>8.730694</distance>
							<expiration>2.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3987">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>eventide</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>hegemony</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>15216</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>15.0</duration>
							<distance>6.702658</distance>
							<expiration>3.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3988">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>p_oka_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>unitedpamed</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>16816</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>23.0</duration>
							<distance>10.034565</distance>
							<expiration>2.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3989">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>ii_nova_capitalis</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>interstellarimperium</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>16190</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>20.0</duration>
							<distance>8.730694</distance>
							<expiration>6.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3990">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>tahlan_lethia_p05_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>independent</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>26460</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>62.0</duration>
							<distance>30.127272</distance>
							<expiration>4.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3991">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>cerbrus</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>persean</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>14121</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>8.0</duration>
							<distance>4.4212666</distance>
							<expiration>8.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3992">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>market_system_2525:planet_3</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>unitedpamed</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>23532</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>50.0</duration>
							<distance>24.026857</distance>
							<expiration>5.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3993">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>market_vic_planet_dismay</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>vic</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>15512</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>16.0</duration>
							<distance>7.3186407</distance>
							<expiration>5.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3994">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>laicaille_habitat</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>persean</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>14520</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>12.0</duration>
							<distance>5.2502384</distance>
							<expiration>4.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3995">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>clusterOrbital_market</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>xhanempire</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>21040</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>38.0</duration>
							<distance>18.833548</distance>
							<expiration>10.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3996">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>eis_yami</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>vic</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>15764</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>16.0</duration>
							<distance>7.8447437</distance>
							<expiration>9.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
						<Util.MissionGen.USLMissionDetails z="3997">
							<missionType>PARCEL</missionType>
							<sourceMarketID>sindria</sourceMarketID>
							<destinationMarketID>mirageIVmarket</destinationMarketID>
							<sourceFactionID>sindrian_diktat</sourceFactionID>
							<destinationFactionID>xhanempire</destinationFactionID>
							<commodityID>st_parcels</commodityID>
							<reward>15816</reward>
							<escrow>0</escrow>
							<quantity>500</quantity>
							<unitPrice>0</unitPrice>
							<duration>17.0</duration>
							<distance>7.95</distance>
							<expiration>2.0</expiration>
							<createTime>-55361054864000</createTime>
						</Util.MissionGen.USLMissionDetails>
					</list>
				</e>
				<e>
					<st>$nex_invasionFailStreak</st>
					<ip>1</ip>
				</e>
				<e>
					<st>$nex_invasionPointsLastTick</st>
					<fp>109.0</fp>
				</e>
				<e>
					<st>$patrol_ind_highcommand</st>
					<bp>true</bp>
				</e>
				<e>
					<st>$military_ind_highcommand</st>
					<bp>true</bp>
				</e>
				<e>
					<st>$patrol_ind_lionsguard</st>
					<bp>true</bp>
				</e>
				<e>
					<st>$military_ind_lionsguard</st>
					<bp>true</bp>
				</e>
			</d>
			<e z="3998">
				<MExp z="3999" k="$nex_fleetPoolPointsLastTick" t="2.7132998"/>
				<MExp z="4000" k="$nex_groundPoolPointsLastTick" t="2.7132998"/>
				<MExp z="4001" k="$nex_invasionPointsLastTick" t="2.6746998"/>
			</e>
			<r z="4002">
				<e>
					<st>$patrol</st>
					<MReq z="4003" k="$patrol">
						<r z="4004">
							<st>$patrol_ind_highcommand</st>
							<st>$patrol_ind_lionsguard</st>
						</r>
					</MReq>
				</e>
				<e>
					<st>$military</st>
					<MReq z="4005" k="$military">
						<r z="4006">
							<st>$military_ind_highcommand</st>
							<st>$military_ind_lionsguard</st>
						</r>
					</MReq>
				</e>
			</r>
			<rF z="4007">
				<e>
					<st>$patrol_ind_highcommand</st>
					<st>$patrol</st>
				</e>
				<e>
					<st>$military_ind_highcommand</st>
					<st>$military</st>
				</e>
				<e>
					<st>$patrol_ind_lionsguard</st>
					<st>$patrol</st>
				</e>
				<e>
					<st>$military_ind_lionsguard</st>
					<st>$military</st>
				</e>
			</rF>
		</memory>
		<stats z="4008">
			<dynamic z="4009">
				<stats z="4010"/>
				<mods z="4011">
					<e>
						<st>officer_prob</st>
						<SBonus z="4012" fB="0.8" m="1.0" pM="0.0" nR="true">
							<fBs z="4013" s="ind_population_0" v="0.1"/>
							<fBs z="4014" s="ind_population_1" v="0.2"/>
							<fBs z="4015" s="ind_megaport_0" v="0.2"/>
							<fBs z="4016" s="ind_highcommand_0" v="0.3"/>
						</SBonus>
					</e>
					<e>
						<st>nex_moraleDamageTaken</st>
						<SBonus z="4017" fB="0.0" m="0.9" pM="0.0" nR="true">
							<mBs z="4018" s="nex_tactical_drills_ex_GO_1" d="Tactical Drills EX" v="0.9"/>
						</SBonus>
					</e>
					<e>
						<st>ground_defenses_mod</st>
						<SBonus z="4019" fB="400.0" m="78.975" pM="0.0" nR="false">
							<fBs z="4020" s="ind_population" d="Base value for a size 7 colony" v="400.0"/>
							<mBs z="4021" s="DE_Lobsters_6596" d="Volturnian Lobster Brutes" v="3.0"/>
							<mBs z="4022" s="nex_tactical_drills_ex_GO_0" d="Tactical Drills EX" v="1.5"/>
							<mBs z="4023" s="ind_population" d="Stability" v="1.0"/>
							<mBs z="4024" s="ind_heavybatteries" d="Heavy batteries" v="3.0"/>
							<mBs z="4025" s="ind_highcommand" d="High command" v="1.3"/>
							<mBs z="4026" s="ind_starfortress" d="Star fortress - low tech" v="3.0"/>
							<mBs z="4027" s="ind_IndEvo_Artillery_missile" d="Missile artillery" v="1.5"/>
						</SBonus>
					</e>
					<e>
						<st>production_quality_mod</st>
						<SBonus z="4028" fB="0.5" m="1.0" pM="0.0" nR="false">
							<fBs z="4029" s="DE_Orbitalworks_6597" d="Salvaged Domain-Era Orbital Works" v="0.1"/>
							<fBs z="4030" s="nanoforge" d="Corrupted nanoforge" v="0.2"/>
							<fBs z="4031" s="ind_orbitalworks_1" d="Orbital works" v="0.2"/>
						</SBonus>
					</e>
					<e>
						<st>admin_prob</st>
						<SBonus z="4032" fB="0.25" m="1.0" pM="0.0" nR="true">
							<fBs z="4033" s="ind_population_0" v="0.05"/>
							<fBs z="4034" s="ind_population_1" v="0.2"/>
						</SBonus>
					</e>
					<e>
						<st>fleet_quality_mod</st>
						<SBonus z="4035" fB="0.5" m="1.0" pM="0.0" nR="false">
							<fBs z="4036" s="ind_population_0" d="Stability" v="0.25"/>
							<fBs z="4037" s="ind_population_1" d="Sindrian Diktat fleet doctrine" v="0.25"/>
						</SBonus>
					</e>
					<e>
						<st>officer_is_merc_prob</st>
						<SBonus z="4038" fB="0.25" m="1.0" pM="0.0" nR="true">
							<fBs z="4039" s="ind_population_0" v="0.25"/>
						</SBonus>
					</e>
					<e>
						<st>patrol_num_light_mod</st>
						<SBonus z="4040" fB="3.0" m="1.0" pM="0.0" nR="true">
							<fBs z="4041" s="ind_highcommand" v="3.0"/>
						</SBonus>
					</e>
					<e>
						<st>max_industries</st>
						<SBonus z="4042" fB="5.0" m="1.0" pM="0.0" nR="false">
							<fBs z="4043" s="ind_population" v="5.0"/>
						</SBonus>
					</e>
					<e>
						<st>patrol_num_heavy_mod</st>
						<SBonus z="4044" fB="3.0" m="1.0" pM="0.0" nR="true">
							<fBs z="4045" s="ind_highcommand" v="3.0"/>
						</SBonus>
					</e>
					<e>
						<st>patrol_num_medium_mod</st>
						<SBonus z="4046" fB="4.0" m="1.0" pM="0.0" nR="true">
							<fBs z="4047" s="ind_highcommand" v="4.0"/>
						</SBonus>
					</e>
					<e>
						<st>additional_officer_prob_mult</st>
						<SBonus z="4048" fB="0.1" m="1.0" pM="0.0" nR="true">
							<fBs z="4049" s="ind_population_0" v="0.1"/>
						</SBonus>
					</e>
					<e>
						<st>combat_fleet_size_mult</st>
						<SBonus z="4050" fB="2.5" m="1.953125" pM="0.0" nR="false">
							<fBs z="4051" s="ind_population_0" d="Colony size" v="1.5"/>
							<fBs z="4052" s="cryoarithmetic_engine" d="Cryoarithmetic engine" v="1.0"/>
							<mBs z="4053" s="ind_population_1" d="Sindrian Diktat fleet doctrine" v="1.25"/>
							<mBs z="4054" s="ind_population_2" d="Ship hulls &amp; weapons demand met" v="1.0"/>
							<mBs z="4055" s="ind_population_3" d="Stability" v="1.25"/>
							<mBs z="4056" s="ind_highcommand" d="Alpha core (High command)" v="1.25"/>
						</SBonus>
					</e>
				</mods>
			</dynamic>
		</stats>
		<isPlanetConditionMarketOnly>false</isPlanetConditionMarketOnly>
		<accessibilityMod z="4057" fB="1.35" m="1.0" pM="0.0" nR="false">
			<fBs z="4058" s="core_base" d="Proximity to other colonies" v="0.49"/>
			<fBs z="4059" s="core_hostile" d="Hostilities with other factions" v="-0.29"/>
			<fBs z="4060" s="industrial_planning_GO_0" d="Industrial Planning" v="0.14999999"/>
			<fBs z="4061" s="ind_population_1" d="Colony size" v="0.2"/>
			<fBs z="4062" s="ind_megaport_0" d="Megaport" v="0.8"/>
		</accessibilityMod>
		<incomeMult z="4063" b="1.0" m="1.0">
			<mMs z="4064" s="ind_population_3" d="Stability" v="1.0"/>
		</incomeMult>
		<upkeepMult z="4065" b="1.0" m="1.083">
			<mMs z="4066" s="upkeep_hazard_mod" d="Hazard rating" v="1.9"/>
			<mMs z="4067" s="ind_population_3ifi" d="Demand supplied in-faction (86%)" v="0.57"/>
		</upkeepMult>
		<useStockpilesForShortages>false</useStockpilesForShortages>
		<industries z="4068">
			<PopulationAndInfrastructure z="4069" id="population" bP="0.0" b="false" wD="false">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<dR z="4070" b="0.0" m="0.0"/>
				<sB z="4071" b="0.0" m="1.0">
					<fMs z="4072" s="ind_population_1" d="Administrator" v="1.0"/>
				</sB>
			</PopulationAndInfrastructure>
			<Spaceport z="4073" id="megaport" bP="0.0" b="false" wD="false">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<dR z="4074" b="0.0" m="0.0"/>
				<sB z="4075" b="0.0" m="1.0">
					<fMs z="4076" s="ind_megaport_1" d="Administrator" v="1.0"/>
				</sB>
			</Spaceport>
			<Refining z="4077" id="refining" bP="0.0" b="false" wD="false">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<dR z="4078" b="0.0" m="0.0"/>
				<sB z="4079" b="0.0" m="1.0">
					<fMs z="4080" s="ind_refining_1" d="Administrator" v="1.0"/>
				</sB>
			</Refining>
			<data.campaign.econ.industries.MS__heavyIndustryChecker z="4081" id="orbitalworks" bP="0.0" b="false" wD="false">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<dR z="4082" b="0.0" m="0.0"/>
				<sB z="4083" b="0.0" m="2.0">
					<fMs z="4084" s="ind_orbitalworks_1" d="Administrator" v="1.0"/>
					<fMs z="4085" s="corrupted_nanoforge" d="Corrupted nanoforge" v="1.0"/>
				</sB>
				<special z="4086" i="corrupted_nanoforge"/>
				<permaPollution>false</permaPollution>
				<addedPollution>false</addedPollution>
				<daysWithNanoforge>4068.4844</daysWithNanoforge>
			</data.campaign.econ.industries.MS__heavyIndustryChecker>
			<FuelProduction z="4087" id="fuelprod" bP="0.0" b="false" wD="false">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<improved>true</improved>
				<dR z="4088" b="0.0" m="0.0"/>
				<sB z="4089" b="0.0" m="5.0">
					<fMs z="4090" s="ind_fuelprod_3" d="Improvements" v="1.0"/>
					<fMs z="4091" s="ind_fuelprod_1" d="Administrator" v="1.0"/>
					<fMs z="4092" s="synchrotron" d="Synchrotron core" v="3.0"/>
				</sB>
				<special z="4093" i="synchrotron"/>
			</FuelProduction>
			<GroundDefenses z="4094" id="heavybatteries" bP="0.0" b="false" wD="false">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<dR z="4095" b="0.0" m="0.0"/>
				<sB z="4096" b="0.0" m="0.0">
					<fMs z="4097" s="ind_heavybatteries_1" d="Administrator" v="1.0"/>
				</sB>
			</GroundDefenses>
			<MilitaryBase z="4098" id="highcommand" bP="0.0" b="false" aCI="alpha_core" wD="false">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<dR z="4099" b="0.0" m="1.0">
					<fMs z="4100" s="ind_highcommand_0" d="Alpha core" v="1.0"/>
				</dR>
				<sB z="4101" b="0.0" m="1.0">
					<fMs z="4102" s="ind_highcommand_1" d="Administrator" v="1.0"/>
				</sB>
				<special z="4103" i="cryoarithmetic_engine"/>
				<tracker z="4104" i="9.8" a="18.199999" c="15.573236" e="13.242519" ie="false"/>
				<returningPatrolValue>0.0</returningPatrolValue>
			</MilitaryBase>
			<LionsGuardHQ z="4105" id="lionsguard" bP="0.0" b="false" wD="false">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<dR z="4106" b="0.0" m="0.0"/>
				<sB z="4107" b="0.0" m="1.0">
					<fMs z="4108" s="ind_lionsguard_1" d="Administrator" v="1.0"/>
				</sB>
				<tracker z="4109" i="9.8" a="18.199999" c="16.560108" e="4.590179" ie="false"/>
				<returningPatrolValue>0.0</returningPatrolValue>
			</LionsGuardHQ>
			<OrbitalStation z="4110" id="starfortress" bP="0.0" b="false" wD="false" uES="true">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<dR z="4111" b="0.0" m="0.0"/>
				<sB z="4112" b="0.0" m="0.0">
					<fMs z="4113" s="ind_starfortress_1" d="Administrator" v="1.0"/>
				</sB>
				<sF cl="Flt" z="4114" sS="450.0" sP="450.0" mO="false" f="90.0" n="Command &amp; Control" aM="true" nFIN="true" sM="true" dF="90.0">
					<loc z="4115">1171.3496|2582.7913</loc>
					<vel z="4116">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Null","f2":[255,210,200,255],"f4":"8c72","f5":true}</j0>
					<o ref="2762"/>
					<orbit cl="COrbt" z="4117" r="0.0" op="100.0" ca="0.0">
						<e cl="Flt" ref="4114"/>
						<f cl="CCEnt" z="4118" fL="STATIONS">
							<loc z="4119">1171.3496|2582.7913</loc>
							<vel z="4120">0.0|0.0</vel>
							<j0>{"f6":164.9779,"f0":"Command &amp; Control","f2":[255,210,200,255],"f3":"orbital_station_default","f4":"diktat_cnc"}</j0>
							<ow ref="2762"/>
							<orbit cl="COrbtPD" z="4121" r="300.0" op="50.0" ca="164.9779">
								<e cl="CCEnt" ref="4118"/>
								<f cl="Plnt" ref="2842"/>
							</orbit>
							<cL cl="Sstm" ref="2812"/>
							<ls cl="Plnt" ref="2809"/>
							<me z="4122">
								<d z="4123">
									<e>
										<st>$salvageSeed</st>
										<Lp>-426164296507136016</Lp>
									</e>
									<e>
										<st>$stationFleet</st>
										<st>enRef_8c72</st>
									</e>
								</d>
							</me>
							<market cl="Market" ref="2849"/>
							<sc z="4124"/>
							<cV z="4125" sn="graphics/illustrations/orbital.jpg" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
							<tags z="4126">
								<st>station</st>
							</tags>
							<j1>{"f0":80,"f1":80,"f2":50,"f3":-1,"f4":-1,"f5":"station_side02"}</j1>
							<la z="4127" enum-type="CaEnLa">STATIONS</la>
						</f>
					</orbit>
					<cL cl="Sstm" ref="2812"/>
					<ls cl="Plnt" ref="2809"/>
					<me z="4128">
						<d z="4129">
							<e>
								<st>$fleetType</st>
								<st>patrolSmall</st>
							</e>
							<e>
								<st>$salvageSeed</st>
								<Lp>125400205172371743</Lp>
							</e>
							<e>
								<st>$spawnFPMult</st>
								<fp>0.0</fp>
							</e>
							<e>
								<st>$stationMarket</st>
								<st>mRef_sindria</st>
							</e>
						</d>
					</me>
					<sc z="4130">
						<TrA z="4131" id="transponder" dF="0" tO="true" cL="0.0" iAC="true" l="1.0">
							<e cl="Flt" ref="4114"/>
						</TrA>
					</sc>
					<abilities cl="l-h-m" z="4132">
						<e>
							<st>transponder</st>
							<TrA ref="4131"/>
						</e>
					</abilities>
					<fD z="4133" nP="SDS" nSf="sindrian_diktat" nS="false" oSML="false">
						<m z="4134">
							<FMmbr z="4135" o="0" sid="station3_Standard" sN="Command &amp; Control" t="SHIP" iF="false" id="82dd09" sUN="false" civ="false" cCiv="false">
								<c z="4136" id="p_82ddef" pid="reckless" spr="graphics/portraits/portrait_diktat11.png" rnk="spaceLieutenant" pst="officer" wTCRC="0" cW="1.0" fid="sindrian_diktat" a="false" im="MEDIUM">
									<n z="4137" f="Ishtanu" l="Io" g="FEMALE"/>
									<m z="4138">
										<d z="4139">
											<e>
												<st>$voice</st>
												<st>official</st>
											</e>
										</d>
									</m>
									<stats z="4140" x2="0" xp="268000" bx="0" db="0" l="4" pt="0" sp="0">
										<s>{"missile_specialization":1,"ordnance_expert":2,"combat_endurance":1,"helmsmanship":1}</s>
									</stats>
								</c>
								<rT z="4141" cr="0.99695194" crPTM="0.0" sR="false" mo="false" lCR="true">
									<m ref="4135"/>
								</rT>
								<fD ref="4133"/>
							</FMmbr>
						</m>
						<cargo z="4142" uS="true" mC="0.0" sU="349.0" mF="0.0" mP="0.0" fT="false">
							<s z="4143">
								<CIStack z="4144" rS="false" s="349.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
									<d cl="st">IndEvo_parts</d>
									<c ref="4142"/>
								</CIStack>
							</s>
							<c z="4145">
								<value>0.0</value>
							</c>
							<cF ref="4133"/>
						</cargo>
						<c z="4146" id="p_8c73" pid="steady" spr="graphics/portraits/portrait_diktat12.png" rnk="spaceCommander" pst="fleetCommander" wTCRC="0" cW="1.0" fid="sindrian_diktat" a="true" im="MEDIUM">
							<n z="4147" f="Arise" l="Daugherty" g="MALE"/>
							<m z="4148">
								<d z="4149">
									<e>
										<st>$voice</st>
										<st>official</st>
									</e>
								</d>
							</m>
							<stats z="4150" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0">
								<fleet cl="Flt" ref="4114"/>
							</stats>
						</c>
						<f ref="4114"/>
					</fD>
					<fV z="4151">
						<fleet ref="4114"/>
						<shipViews z="4152">
							<delegate cl="CampaignFleetView" ref="4151"/>
							<views cl="l-h-m" z="4153">
								<e>
									<FMmbr ref="4135"/>
									<CampaignFleetMemberView z="4154" oF="0.0" tR="0.0" mTR="40.0" mS="6.0" sM="0.1" sSO="5.0" facing="90.0" jC="10" mJR="10.0" pAn="64.07507" oOv="false" uLi="false" eAM="1.0" wOff="0.0">
										<f ref="4114"/>
										<m ref="4135"/>
										<fa z="4155" b="1.0" i="1.0" o="1.5" s="IDLE" d="false" u="false"/>
										<oL z="4156">0.0|0.0</oL>
										<dO z="4157">0.0|0.0</dO>
										<mM z="4158" a="3.0" s="6.0" sC="false">
											<v z="4159">0.0|0.0</v>
											<l z="4160">0.0|0.0</l>
											<aV z="4161">0.0|0.0</aV>
											<hardSpeedLimit>-1.0</hardSpeedLimit>
										</mM>
										<eG z="4162" sM="0.1">
											<lM z="4163" b="1.0" m="1.0"/>
											<m ref="4135"/>
											<c z="4164">w</c>
											<cC ref="4164"/>
											<s z="4165"/>
											<cl z="4166"/>
											<aF z="4167" b="0.0" i="0.5" o="0.5" s="OUT" d="false" u="false"/>
											<fF z="4168" b="1.0" i="1.0" o="1.0" s="IDLE" d="false" u="false"/>
										</eG>
										<fMod z="4169" a="400.0" m="120.0" r="-120.0" f="90.0"/>
										<jClr ref="4164"/>
										<eC z="4170">
											<b ref="4164"/>
											<c ref="4164"/>
											<d cl="l-h-m" z="4171"/>
										</eC>
										<eWM z="4172" b="1.0" c="1.0">
											<d cl="l-h-m" z="4173"/>
										</eWM>
										<eHM z="4174" b="1.0" c="1.0">
											<d cl="l-h-m" z="4175"/>
										</eHM>
										<eGC z="4176">
											<b ref="4164"/>
											<c ref="4164"/>
											<d cl="l-h-m" z="4177"/>
										</eGC>
										<eGSM z="4178" b="1.0" c="1.0">
											<d cl="l-h-m" z="4179"/>
										</eGSM>
										<cC z="4180">
											<b ref="4164"/>
											<c ref="4164"/>
											<d cl="l-h-m" z="4181"/>
										</cC>
										<cWM z="4182" b="1.0" c="1.0">
											<d cl="l-h-m" z="4183"/>
										</cWM>
										<cDM z="4184" b="1.0" c="1.0">
											<d cl="l-h-m" z="4185"/>
										</cDM>
										<gC z="4186">
											<b z="4187">0,0,0,0</b>
											<c ref="4187"/>
											<d cl="l-h-m" z="4188"/>
										</gC>
										<wEC z="4189">
											<b z="4190">0,0,0,0</b>
											<c ref="4190"/>
											<d cl="l-h-m" z="4191"/>
										</wEC>
										<wEDX z="4192" b="0.0" c="0.0">
											<d cl="l-h-m" z="4193"/>
										</wEDX>
										<wEDY z="4194" b="0.0" c="0.0">
											<d cl="l-h-m" z="4195"/>
										</wEDY>
										<zero z="4196">0.0|0.0</zero>
									</CampaignFleetMemberView>
								</e>
							</views>
							<sortedViews z="4197">
								<comparator cl="com.fs.starfarer.campaign.util.CollectionView$1" z="4198">
									<outer-class ref="4152"/>
								</comparator>
								<CampaignFleetMemberView ref="4154"/>
							</sortedViews>
							<orphaned z="4199">
								<FMmbr ref="4135"/>
							</orphaned>
							<notified z="4200"/>
						</shipViews>
						<lightSource cl="Plnt" ref="2809"/>
						<lightColor z="4201">255,210,200,255</lightColor>
					</fV>
					<mM z="4202" a="1.0" s="2.0" sC="true">
						<v z="4203">0.0|0.0</v>
						<l z="4204">0.0|0.0</l>
						<aV z="4205">0.0|0.0</aV>
						<d cl="Flt" ref="4114"/>
						<hardSpeedLimit>-1.0</hardSpeedLimit>
					</mM>
					<fM z="4206" a="150.0" m="100.0" r="0.0" f="90.0"/>
					<s z="4207">
						<tempMod z="4208">
							<timeRemaining>0.0977</timeRemaining>
							<source>nav_buoy</source>
							<stat z="4209" fB="3.0" m="1.0" pM="0.0" nR="false">
								<fBs z="4210" s="nav_buoy" d="Nav buoy" v="3.0"/>
							</stat>
						</tempMod>
						<tempMod z="4211">
							<timeRemaining>0.0977</timeRemaining>
							<source>sensor_array</source>
							<stat z="4212" fB="400.0" m="1.0" pM="0.0" nR="false">
								<fBs z="4213" s="sensor_array" d="Makeshift sensor array" v="400.0"/>
							</stat>
						</tempMod>
						<dynamic z="4214">
							<stats z="4215"/>
							<mods z="4216"/>
						</dynamic>
						<fMBM ref="4209"/>
						<sRM ref="4212"/>
						<dRM z="4217" fB="11000.0" m="1.0" pM="0.0" nR="false">
							<fBs z="4218" s="transponder_ability_mod" d="Transponder on" v="1000.0"/>
							<fBs z="4219" s="gen" v="10000.0"/>
							<mBs z="4220" s="core_PhaseField" d="Phase ships in fleet" v="1.0"/>
						</dRM>
					</s>
					<lgst z="4221">
						<f ref="4114"/>
					</lgst>
					<nCP z="4222" b="0.0" i="0.1" o="0.1" s="IDLE" d="true" u="false"/>
					<dL z="4223">
						<OrbitalStation ref="4110"/>
					</dL>
					<inflater cl="DFInfl" z="4224">
						<p z="4225" s="-5030593246907508805" p="true" q="1.0" m="PRIORITY_THEN_ALL">
							<allWeapons>true</allWeapons>
							<factionId>sindrian_diktat</factionId>
						</p>
					</inflater>
					<hidden>true</hidden>
				</sF>
				<sE cl="CCEnt" ref="4118"/>
			</OrbitalStation>
			<indevo.industries.relay.industry.MilitaryRelay z="4226" id="IndEvo_IntArray" bP="0.0" b="false" wD="false">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<dR z="4227" b="0.0" m="0.0"/>
				<sB z="4228" b="0.0" m="0.0"/>
				<tracker z="4229" i="9.8" a="18.199999" c="18.112389" e="2.9851654" ie="false"/>
				<returningPatrolValue>0.0</returningPatrolValue>
				<bestFleetSize>4.8828125</bestFleetSize>
				<bestMarketId>sindria</bestMarketId>
				<bestAiCoreId>alpha_core</bestAiCoreId>
				<currentMultMod>0.35</currentMultMod>
				<currentAICoreBonus>1.0</currentAICoreBonus>
				<addedOrRemovedItem>false</addedOrRemovedItem>
			</indevo.industries.relay.industry.MilitaryRelay>
			<indevo.industries.RequisitionCenter z="4230" id="IndEvo_ReqCenter" bP="0.0" b="false" wD="false">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<dR z="4231" b="0.0" m="0.0"/>
				<sB z="4232" b="0.0" m="0.0">
					<fMs z="4233" s="ind_IndEvo_ReqCenter_1" d="Administrator" v="1.0"/>
				</sB>
			</indevo.industries.RequisitionCenter>
			<indevo.industries.artillery.industry.ArtilleryStation z="4234" id="IndEvo_Artillery_missile" bP="0.0" b="false" wD="false">
				<m cl="Market" ref="2849"/>
				<buildTime>1.0</buildTime>
				<dR z="4235" b="0.0" m="0.0"/>
				<sB z="4236" b="0.0" m="0.0">
					<fMs z="4237" s="ind_IndEvo_Artillery_missile_1" d="Administrator" v="1.0"/>
				</sB>
				<stationFleet cl="Flt" z="4238" sS="450.0" sP="450.0" mO="false" f="305.13892" n="Sindria Missile Artillery Station" aM="true" nFIN="true" sM="true" dF="90.0">
					<loc z="4239">1750.719|2426.8074</loc>
					<vel z="4240">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Null","f2":[255,210,200,255],"f4":"8c77","f5":true}</j0>
					<o ref="2762"/>
					<orbit cl="COrbt" z="4241" r="0.0" op="100.0" ca="0.0">
						<e cl="Flt" ref="4238"/>
						<f cl="CCEnt" z="4242" fL="STATIONS">
							<loc z="4243">1750.719|2426.8074</loc>
							<vel z="4244">0.0|0.0</vel>
							<j0>{"f6":305.13892,"f0":"Sindria Missile Artillery Station","f2":[255,210,200,255],"f3":"IndEvo_Artillery_missile","f4":"8c79"}</j0>
							<ow ref="2762"/>
							<orbit cl="CircularOrbitWithSpin" z="4245" r="300.0" op="50.0" ca="344.88513" cF="305.13892" sV="5.0">
								<e cl="CCEnt" ref="4242"/>
								<f cl="Plnt" ref="2842"/>
							</orbit>
							<cL cl="Sstm" ref="2812"/>
							<ls cl="Plnt" ref="2809"/>
							<me z="4246">
								<d z="4247">
									<e>
										<st>$ArtilleryStation</st>
										<bp>true</bp>
									</e>
									<e>
										<st>$salvageSeed</st>
										<Lp>-2685426468850290907</Lp>
									</e>
									<e>
										<st>$stationBaseFleet</st>
										<Flt ref="4238"/>
									</e>
								</d>
							</me>
							<market cl="Market" ref="2849"/>
							<sc z="4248">
								<indevo.industries.artillery.scripts.CampaignAttackScript z="4249">
									<targetMap z="4250">
										<e>
											<st>bc2adf</st>
											<IUtil z="4251" i="26.0" a="30.0" c="29.791838" e="4.722999" ie="false"/>
										</e>
									</targetMap>
									<blockedAreas z="4252"/>
									<stationFireInterval z="4253" i="2.0" a="3.0" c="2.4921" e="2.088333" ie="false"/>
									<forcedTargetMap z="4254"/>
									<terrain cl="CampaignTerrain" z="4255" type="IndEvo_artillery_range_terrain" radius="0.0">
										<loc z="4256">1750.719|2426.8074</loc>
										<vel z="4257">0.0|0.0</vel>
										<j0>{"f6":90,"f0":"Null","f2":[255,210,200,255],"f4":"47356"}</j0>
										<ow ref="13"/>
										<orbit cl="COrbt" z="4258" r="0.0" op="0.0" ca="0.0">
											<e cl="CampaignTerrain" ref="4255"/>
											<f cl="CCEnt" ref="4242"/>
										</orbit>
										<cL cl="Sstm" ref="2812"/>
										<ls cl="Plnt" ref="2809"/>
										<me z="4259">
											<d z="4260"/>
										</me>
										<sc z="4261"/>
										<tags z="4262">
											<st>terrain</st>
										</tags>
										<plugin cl="indevo.industries.artillery.terrain.ArtilleryTerrain" z="4263" tid="IndEvo_artillery_range_terrain" n="Unknown">
											<entity cl="CampaignTerrain" ref="4255"/>
											<params z="4264" bWIE="12000.0" mR="0.0" n="In artillery range">
												<e cl="CCEnt" ref="4242"/>
											</params>
										</plugin>
									</terrain>
									<range>12000.0</range>
									<terrainRange>12000.0</terrainRange>
									<disabled>false</disabled>
									<isDone>false</isDone>
									<entity cl="CCEnt" ref="4242"/>
									<type>missile</type>
									<devmodeInterval z="4265" i="5.0" a="5.0" c="5.0" e="1.2816668" ie="false"/>
								</indevo.industries.artillery.scripts.CampaignAttackScript>
							</sc>
							<activePerson z="4266" id="p_1e7062" pid="steady" spr="graphics/portraits/characters/concierge2.png" rnk="baseCommander" pst="baseCommander" wTCRC="0" cW="1.0" fid="USL" a="false" im="MEDIUM">
								<n z="4267" f="USL" l="Concierge" g="FEMALE"/>
								<m z="4268">
									<d z="4269">
										<e>
											<st>$id</st>
											<st>p_1e7062</st>
										</e>
										<e>
											<st>$tag:ST_TruckerConcierge</st>
											<bp>true</bp>
										</e>
										<e>
											<st>$relValue</st>
											<fp>0.0</fp>
										</e>
										<e>
											<st>$rel</st>
											<fp>0.0</fp>
										</e>
										<e>
											<st>$relName</st>
											<st>NEUTRAL</st>
										</e>
										<e>
											<st>$isPerson</st>
											<bp>true</bp>
										</e>
										<e>
											<st>$name</st>
											<st>USL Concierge</st>
										</e>
										<e>
											<st>$personName</st>
											<st>USL Concierge</st>
										</e>
										<e>
											<st>$isContact</st>
											<bp>false</bp>
										</e>
										<e>
											<st>$rankId</st>
											<st>baseCommander</st>
										</e>
										<e>
											<st>$postId</st>
											<st>baseCommander</st>
										</e>
										<e>
											<st>$rankAOrAn</st>
											<st>a</st>
										</e>
										<e>
											<st>$postAOrAn</st>
											<st>an</st>
										</e>
										<e>
											<st>$rank</st>
											<st>usl attendant</st>
										</e>
										<e>
											<st>$Rank</st>
											<st>USL Attendant</st>
										</e>
										<e>
											<st>$post</st>
											<st>usl attendant</st>
										</e>
										<e>
											<st>$Post</st>
											<st>USL Attendant</st>
										</e>
										<e>
											<st>$importance</st>
											<st>MEDIUM</st>
										</e>
										<e>
											<st>$importanceAtLeastHigh</st>
											<bp>false</bp>
										</e>
										<e>
											<st>$importanceAtMostLow</st>
											<bp>false</bp>
										</e>
										<e>
											<st>$level</st>
											<ip>1</ip>
										</e>
										<e>
											<st>$personality</st>
											<st>steady</st>
										</e>
									</d>
									<e z="4270">
										<MExp z="4271" k="$id" t="0.0"/>
										<MExp z="4272" k="$tag:ST_TruckerConcierge" t="0.0"/>
										<MExp z="4273" k="$relValue" t="0.0"/>
										<MExp z="4274" k="$rel" t="0.0"/>
										<MExp z="4275" k="$relName" t="0.0"/>
										<MExp z="4276" k="$isPerson" t="0.0"/>
										<MExp z="4277" k="$name" t="0.0"/>
										<MExp z="4278" k="$personName" t="0.0"/>
										<MExp z="4279" k="$isContact" t="0.0"/>
										<MExp z="4280" k="$rankId" t="0.0"/>
										<MExp z="4281" k="$postId" t="0.0"/>
										<MExp z="4282" k="$rankAOrAn" t="0.0"/>
										<MExp z="4283" k="$postAOrAn" t="0.0"/>
										<MExp z="4284" k="$rank" t="0.0"/>
										<MExp z="4285" k="$Rank" t="0.0"/>
										<MExp z="4286" k="$post" t="0.0"/>
										<MExp z="4287" k="$Post" t="0.0"/>
										<MExp z="4288" k="$importance" t="0.0"/>
										<MExp z="4289" k="$importanceAtLeastHigh" t="0.0"/>
										<MExp z="4290" k="$importanceAtMostLow" t="0.0"/>
										<MExp z="4291" k="$level" t="0.0"/>
										<MExp z="4292" k="$personality" t="0.0"/>
									</e>
								</m>
								<stats z="4293" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0">
									<s>{"crew_training":3,"best_of_the_best":3}</s>
									<dynamic z="4294">
										<stats z="4295"/>
										<mods z="4296">
											<e>
												<st>command_point_rate_flat</st>
												<SBonus z="4297" fB="0.0" m="1.0" pM="0.0" nR="true">
													<fBs z="4298" s="best_of_the_best_stats_3" v="100.0"/>
												</SBonus>
											</e>
											<e>
												<st>deployment_points_min_fraction_of_battle_size_bonus_mod</st>
												<SBonus z="4299" fB="0.0" m="1.0" pM="0.0" nR="true">
													<fBs z="4300" s="best_of_the_best_stats_2" v="0.1"/>
												</SBonus>
											</e>
										</mods>
									</dynamic>
								</stats>
								<tags z="4301">
									<st>ST_TruckerConcierge</st>
								</tags>
							</activePerson>
							<tags z="4302">
								<st>NO_ORBITAL_STATION</st>
								<st>station</st>
								<st>use_station_visual</st>
								<st>IndEvo_Artillery</st>
							</tags>
							<j1>{"f0":55,"f1":55,"f2":40,"f3":-1,"f4":-1,"f5":"IndEvo_ArtilleryStation"}</j1>
							<la z="4303" enum-type="CaEnLa">STATIONS</la>
							<p cl="indevo.industries.artillery.entities.ArtilleryStationEntityPlugin" z="4304">
								<e cl="CCEnt" ref="4242"/>
								<type>missile</type>
								<disrupted>false</disrupted>
							</p>
							<fleetForVisual ref="4238"/>
						</f>
					</orbit>
					<cL cl="Sstm" ref="2812"/>
					<ls cl="Plnt" ref="2809"/>
					<me z="4305">
						<d z="4306">
							<e>
								<st>$fleetType</st>
								<st>patrolSmall</st>
							</e>
							<e>
								<st>$salvageSeed</st>
								<Lp>-7895473191571463155</Lp>
							</e>
							<e>
								<st>$spawnFPMult</st>
								<fp>0.0</fp>
							</e>
							<e>
								<st>$stationMarket</st>
								<st>mRef_sindria</st>
							</e>
						</d>
					</me>
					<sc z="4307">
						<TrA z="4308" id="transponder" dF="0" tO="true" cL="0.0" iAC="true" l="1.0">
							<e cl="Flt" ref="4238"/>
						</TrA>
					</sc>
					<abilities cl="l-h-m" z="4309">
						<e>
							<st>transponder</st>
							<TrA ref="4308"/>
						</e>
					</abilities>
					<tags z="4310">
						<st>IndEvo_ArtilleryFleet</st>
					</tags>
					<alwaysUseSensorFaderBrightness>false</alwaysUseSensorFaderBrightness>
					<fD z="4311" nP="SDS" nSf="sindrian_diktat" nS="false" oSML="false">
						<m z="4312">
							<FMmbr z="4313" o="0" sid="IndEvo_artilleryStation_missile_variant" sN="Sindria Missile Artillery Station" t="SHIP" iF="false" id="822cd6" sUN="false" civ="false" cCiv="false">
								<status z="4314">
									<status z="4315">
										<ShipStatus z="4316" hF="1.0" gW="0" gH="0">
											<s ref="4314"/>
											<hullDamageTaken>0.0</hullDamageTaken>
											<armorDamageTaken>0.0</armorDamageTaken>
										</ShipStatus>
										<ShipStatus z="4317" hF="0.0" gW="0" gH="0" d="true" pD="true">
											<s ref="4314"/>
											<hullDamageTaken>0.0</hullDamageTaken>
											<armorDamageTaken>0.0</armorDamageTaken>
										</ShipStatus>
										<ShipStatus z="4318" hF="0.0" gW="0" gH="0" d="true" pD="true">
											<s ref="4314"/>
											<hullDamageTaken>0.0</hullDamageTaken>
											<armorDamageTaken>0.0</armorDamageTaken>
										</ShipStatus>
										<ShipStatus z="4319" hF="0.0" gW="0" gH="0" d="true" pD="true">
											<s ref="4314"/>
											<hullDamageTaken>0.0</hullDamageTaken>
											<armorDamageTaken>0.0</armorDamageTaken>
										</ShipStatus>
										<ShipStatus z="4320" hF="0.0" gW="0" gH="0" d="true" pD="true">
											<s ref="4314"/>
											<hullDamageTaken>0.0</hullDamageTaken>
											<armorDamageTaken>0.0</armorDamageTaken>
										</ShipStatus>
										<ShipStatus z="4321" hF="0.0" gW="0" gH="0" d="true" pD="true">
											<s ref="4314"/>
											<hullDamageTaken>0.0</hullDamageTaken>
											<armorDamageTaken>0.0</armorDamageTaken>
										</ShipStatus>
									</status>
									<member ref="4313"/>
								</status>
								<rT z="4322" cr="0.99695194" crPTM="0.0" sR="false" mo="false" lCR="true">
									<m ref="4313"/>
								</rT>
								<fD ref="4311"/>
							</FMmbr>
						</m>
						<cargo z="4323" uS="true" mC="0.0" sU="142.0" mF="0.0" mP="0.0" fT="false">
							<s z="4324">
								<CIStack z="4325" rS="false" s="142.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
									<d cl="st">IndEvo_parts</d>
									<c ref="4323"/>
								</CIStack>
							</s>
							<c z="4326">
								<value>0.0</value>
							</c>
							<cF ref="4311"/>
						</cargo>
						<c z="4327" id="p_8c78" pid="steady" spr="graphics/portraits/marvelousPersonasPortraits/mp_diktat_04.png" rnk="spaceCommander" pst="fleetCommander" wTCRC="0" cW="1.0" fid="sindrian_diktat" a="true" im="MEDIUM">
							<n z="4328" f="Adewale" l="Deimos" g="MALE"/>
							<m z="4329">
								<d z="4330">
									<e>
										<st>$voice</st>
										<st>soldier</st>
									</e>
								</d>
							</m>
							<stats z="4331" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0">
								<fleet cl="Flt" ref="4238"/>
							</stats>
						</c>
						<f ref="4238"/>
					</fD>
					<fV z="4332">
						<fleet ref="4238"/>
						<shipViews z="4333">
							<delegate cl="CampaignFleetView" ref="4332"/>
							<views cl="l-h-m" z="4334">
								<e>
									<FMmbr ref="4313"/>
									<CampaignFleetMemberView z="4335" oF="305.13892" tR="0.0" mTR="40.0" mS="6.0" sM="0.1" sSO="5.0" facing="305.13892" jC="10" mJR="10.0" pAn="245.45624" oOv="false" uLi="true" eAM="1.0" wOff="0.0">
										<f ref="4238"/>
										<m ref="4313"/>
										<fa z="4336" b="1.0" i="1.0" o="1.5" s="IDLE" d="false" u="false"/>
										<oL z="4337">0.0|0.0</oL>
										<dO z="4338">-0.0|-0.0</dO>
										<mM z="4339" a="3.0" s="6.0" sC="false">
											<v z="4340">0.0|0.0</v>
											<l z="4341">0.0|0.0</l>
											<aV z="4342">0.0|0.0</aV>
											<hardSpeedLimit>-1.0</hardSpeedLimit>
										</mM>
										<eG z="4343" sM="0.1">
											<lM z="4344" b="1.0" m="1.0"/>
											<m ref="4313"/>
											<c ref="4164"/>
											<cC ref="4164"/>
											<s z="4345"/>
											<cl z="4346"/>
											<aF z="4347" b="0.0" i="0.5" o="0.5" s="OUT" d="false" u="false"/>
											<fF z="4348" b="0.0" i="1.0" o="1.0" s="IDLE" d="false" u="false"/>
										</eG>
										<fMod z="4349" a="400.0" m="120.0" r="-4.1333256" f="305.12738"/>
										<jClr ref="4164"/>
										<eC z="4350">
											<b ref="4164"/>
											<c ref="4164"/>
											<d cl="l-h-m" z="4351"/>
										</eC>
										<eWM z="4352" b="1.0" c="1.0">
											<d cl="l-h-m" z="4353"/>
										</eWM>
										<eHM z="4354" b="1.0" c="1.0">
											<d cl="l-h-m" z="4355"/>
										</eHM>
										<eGC z="4356">
											<b ref="4164"/>
											<c ref="4164"/>
											<d cl="l-h-m" z="4357"/>
										</eGC>
										<eGSM z="4358" b="1.0" c="1.0">
											<d cl="l-h-m" z="4359"/>
										</eGSM>
										<cC z="4360">
											<b ref="4164"/>
											<c ref="4164"/>
											<d cl="l-h-m" z="4361"/>
										</cC>
										<cWM z="4362" b="1.0" c="1.0">
											<d cl="l-h-m" z="4363"/>
										</cWM>
										<cDM z="4364" b="1.0" c="1.0">
											<d cl="l-h-m" z="4365"/>
										</cDM>
										<gC z="4366">
											<b z="4367">0,0,0,0</b>
											<c ref="4367"/>
											<d cl="l-h-m" z="4368"/>
										</gC>
										<wEC z="4369">
											<b z="4370">0,0,0,0</b>
											<c ref="4370"/>
											<d cl="l-h-m" z="4371"/>
										</wEC>
										<wEDX z="4372" b="0.0" c="0.0">
											<d cl="l-h-m" z="4373"/>
										</wEDX>
										<wEDY z="4374" b="0.0" c="0.0">
											<d cl="l-h-m" z="4375"/>
										</wEDY>
										<zero z="4376">0.0|0.0</zero>
									</CampaignFleetMemberView>
								</e>
							</views>
							<sortedViews z="4377">
								<comparator cl="com.fs.starfarer.campaign.util.CollectionView$1" z="4378">
									<outer-class ref="4333"/>
								</comparator>
								<CampaignFleetMemberView ref="4335"/>
							</sortedViews>
							<orphaned z="4379">
								<FMmbr ref="4313"/>
							</orphaned>
							<notified z="4380"/>
						</shipViews>
						<lightSource cl="Plnt" ref="2809"/>
						<lightColor ref="4201"/>
					</fV>
					<mM z="4381" a="1.0" s="2.0" sC="true">
						<v z="4382">0.0|0.0</v>
						<l z="4383">1750.719|2426.8074</l>
						<aV z="4384">0.0|0.0</aV>
						<d cl="Flt" ref="4238"/>
						<hardSpeedLimit>-1.0</hardSpeedLimit>
					</mM>
					<fM z="4385" a="150.0" m="100.0" r="0.0" f="305.13892"/>
					<ai cl="MFAI" z="4386">
						<n cl="NMdl" z="4387" hD="false">
							<f ref="4238"/>
							<a z="4388">
								<items z="4389"/>
							</a>
							<doNotAvoid z="4390">
								<items z="4391"/>
							</doNotAvoid>
							<d z="4392">0.0|0.0</d>
							<c z="4393">0.0|0.0</c>
						</n>
						<a cl="AMdl" z="4394">
							<f ref="4238"/>
							<a z="4395"/>
						</a>
						<s cl="StrategicModule" z="4396">
							<f ref="4238"/>
							<ai cl="MFAI" ref="4386"/>
							<aT z="4397" i="0.5" a="1.5" c="1.3939058" e="0.0" ie="false"/>
							<dNA z="4398">
								<items z="4399"/>
							</dNA>
							<rSP z="4400">
								<items z="4401"/>
							</rSP>
						</s>
						<t cl="TacticalModule" z="4402" trD="0.0" taD="0.0" pD="0.0" pDy="0.0" bSP="0.0" fM="false" iF="false" iMC="false">
							<f ref="4238"/>
							<ai cl="MFAI" ref="4386"/>
							<tr z="4403" i="0.05" a="0.1" c="0.052821483" e="0.052821483" ie="false"/>
						</t>
						<f ref="4238"/>
						<abilityAI cl="l-h-m" z="4404"/>
					</ai>
					<s z="4405">
						<dynamic z="4406">
							<stats z="4407"/>
							<mods z="4408"/>
						</dynamic>
						<fMBM z="4409" fB="0.0" m="1.0" pM="0.0" nR="false"/>
						<dRM z="4410" fB="11000.0" m="1.0" pM="0.0" nR="false">
							<fBs z="4411" s="transponder_ability_mod" d="Transponder on" v="1000.0"/>
							<fBs z="4412" s="gen" v="10000.0"/>
							<mBs z="4413" s="core_PhaseField" d="Phase ships in fleet" v="1.0"/>
						</dRM>
					</s>
					<lgst z="4414">
						<f ref="4238"/>
					</lgst>
					<nCP z="4415" b="0.0" i="0.1" o="0.1" s="IDLE" d="true" u="false"/>
					<dL z="4416">
						<indevo.industries.artillery.industry.ArtilleryStation ref="4234"/>
					</dL>
					<inflater cl="DFInfl" z="4417">
						<p z="4418" s="-4527607463730600418" p="true" q="1.0" m="PRIORITY_THEN_ALL">
							<allWeapons>true</allWeapons>
							<factionId>sindrian_diktat</factionId>
						</p>
					</inflater>
					<hidden>true</hidden>
				</stationFleet>
				<stationEntity cl="CCEnt" ref="4242"/>
				<reminderInterval z="4419" i="60.0" a="60.0" c="60.0" e="15.792365" ie="false"/>
			</indevo.industries.artillery.industry.ArtilleryStation>
		</industries>
		<playerOwned>false</playerOwned>
		<hasSpaceport>true</hasSpaceport>
		<hasWaystation>false</hasWaystation>
		<population z="4420">
			<comp z="4421">
				<e>
					<st>sindrian_diktat</st>
					<fp>3578.1665</fp>
				</e>
				<e>
					<st>pirates</st>
					<fp>98.01712</fp>
				</e>
				<e>
					<st>poor</st>
					<fp>98.01712</fp>
				</e>
				<e>
					<st>independent</st>
					<fp>979.7551</fp>
				</e>
				<e>
					<st>luddic_path</st>
					<fp>46.043644</fp>
				</e>
			</comp>
			<weight z="4422" b="0.0" m="4800.0">
				<fMs z="4423" s="core_set" v="4800.0"/>
			</weight>
		</population>
		<incoming z="4424">
			<comp z="4425">
				<e>
					<st>pirates</st>
					<fp>1.6</fp>
				</e>
				<e>
					<st>poor</st>
					<fp>1.6</fp>
				</e>
				<e>
					<st>independent</st>
					<fp>16.0</fp>
				</e>
				<e>
					<st>luddic_path</st>
					<fp>0.8</fp>
				</e>
			</comp>
			<weight z="4426" b="0.0" m="0.0">
				<fMs z="4427" s="inc_access" d="Accessibility" v="13.0"/>
				<fMs z="4428" s="inc_hazard" d="Hazard rating (×3 based on colony size)" v="-54.0"/>
				<fMs z="4429" s="ind_megaport" d="Megaport" v="7.0"/>
				<mMs z="4430" s="nex_colonyManager_npcGrowth" d="NPC market" v="0.5"/>
			</weight>
		</incoming>
		<immigrationModifiers z="4431">
			<ColonyMngr ref="2414"/>
		</immigrationModifiers>
		<allowImport>true</allowImport>
		<allowExport>true</allowExport>
		<incentiveCredits>0.0</incentiveCredits>
		<constructionQueue z="4432">
			<items z="4433"/>
		</constructionQueue>
		<commDirectory z="4434">
			REDACTED BECAUSE OF HOW FUCKING BIG IT GETS
		</commDirectory>
		<people z="318290">
			<Person ref="318062"/>
			<Person ref="4481"/>
			<Person ref="4501"/>
			<Person ref="4437"/>
			<Person ref="317898"/>
			<Person ref="4460"/>
			<Person ref="4495"/>
			<Person ref="4453"/>
			<Person ref="4508"/>
			<Person ref="4467"/>
			<Person ref="4487"/>
			<Person ref="4474"/>
		</people>
		<admin ref="4437"/>
		<prevStability>10.0</prevStability>
		<daysInExistence>4068.4844</daysInExistence>
		<connectedEntities z="318291">
			<Plnt ref="2842"/>
			<CCEnt ref="4118"/>
			<CCEnt ref="4242"/>
		</connectedEntities>
		<conditions z="318292">
			<MCon z="318293" i="population_7" u="3d80" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318294" i="ore_abundant" u="3d81" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318295" i="rare_ore_moderate" u="3d82" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318296" i="very_hot" u="3d83" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318297" i="no_atmosphere" u="3d84" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318298" i="DE_Lobsters" u="6596" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318299" i="DE_Orbitalworks" u="6597" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318300" i="DE_Patrioticfervor" u="6598" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318301" i="IndEvo_ArtilleryStationCondition" u="665d" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318302" i="IndEvo_ressCond" u="6f5b" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318303" i="alcohol_resourceCondition" u="714c" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318304" i="IcDemmand" u="8840" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318305" i="watterSupplyMining" u="8841" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318306" i="AoDFoodDemand" u="899e" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318307" i="AodFood" u="899f" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318308" i="industrial_might" u="8aac" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318309" i="aotd_tech_hazard" u="18757" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318310" i="pather_cells" u="19c8d" s="true">
				<p cl="LuddicPathCells" z="318311">
					<m cl="Market" ref="2849"/>
					<c cl="MCon" ref="318310"/>
					<i z="318312" tt="-55659363978000" nC="true" s="true" sT="0.0" nIA="4" iD="0.0" sPI="0.0" iTi="1.9443989">
						<pLoc cl="Plnt" ref="2842"/>
						<m cl="Market" ref="2849"/>
						<iT z="318313" i="20.0" a="40.0" c="37.70321" e="37.70572" ie="true"/>
						<r z="318314" serialization="custom">
							<Random>
								<default>
									<s>21253932348242</s>
									<n>0.0</n>
									<h>false</h>
								</default>
							</Random>
						</r>
						<prevIncidentSucceeded>false</prevIncidentSucceeded>
					</i>
				</p>
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318315" i="nex_faction_condition" u="59403ab1-49d6-47d3-b438-7a9153e2cc97" s="true">
				<p cl="exerelin.campaign.econ.FactionConditionPlugin" z="318316">
					<m cl="Market" ref="2849"/>
					<c cl="MCon" ref="318315"/>
					<factionId>sindrian_diktat</factionId>
				</p>
				<m cl="Market" ref="2849"/>
			</MCon>
			<MCon z="318317" i="comm_relay" u="bb6b2c" s="true">
				<m cl="Market" ref="2849"/>
			</MCon>
		</conditions>
		<surveyLevel>FULL</surveyLevel>
		<forceNoConvertOnSave>false</forceNoConvertOnSave>
		<isFreePort>false</isFreePort>
		<tags z="318318">
			<st>IndEvo_Artillery</st>
		</tags>
	</market>
	<sc z="318319">
		<indevo.industries.artillery.scripts.ArtilleryStationScript ref="2848"/>
	</sc>
	<cV z="318320" sn="graphics/illustrations/sindria.jpg" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
	<tags z="318321">
		<st>planet</st>
		<st>not_random_mission_target</st>
	</tags>
	<angle>120.76114</angle>
	<cloudAngle>0.0</cloudAngle>
	<radius>150.0</radius>
	<type>rocky_metallic</type>
	<diff z="318322">
		<j>{"glowTexture":"graphics/planets/sindria_glow.png","useReverseLightForGlow":true}</j>
	</diff>
	<layers z="318323" enum-type="CaEnLa">PLANETS,ABOVE</layers>
</Plnt>
```