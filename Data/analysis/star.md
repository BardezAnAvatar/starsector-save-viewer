Star (Corvus)

Seems to be a PLNT type (lame)

<f cl="Plnt" z="104185">
	<tags z="107210">
		<st>star</st>	-- hey, it's a star!
	</tags>
	<cL cl="Sstm" z="104188"> ... </cL>	--which system it exists in
	<j0>{"f6":0,"f0":"Corvus","f2":[255,255,255,255],"f4":"corvus"}</j0>	-- Get the name out of JSON. fun.
</f>



Star XML:
```
<f cl="Plnt" z="104185">
	<loc z="104186">0.0|0.0</loc>
	<vel z="104187">0.0|0.0</vel>
	<j0>{"f6":0,"f0":"Corvus","f2":[255,255,255,255],"f4":"corvus"}</j0>
	<ow ref="93"/>
	<cL cl="Sstm" z="104188" dN="Corvus Star System" bTF="graphics/backgrounds/background2.jpg" hM="false" lPV="-55452545137000" ty="SINGLE" hSN="true" pg="false" bN="Corvus" mRIH="1066.25" eBP="true">
		<o z="104189">
			<lists z="104190"/>
			<maps z="104191"/>
			<classifier cl="FastIterationClassifier" z="104192">
				<cache z="104193"/>
			</classifier>
			<nextId>0</nextId>
			<forFastContains z="104194"/>
			<saved z="104195">
				<Plnt ref="104185"/>
				<CampaignTerrain z="104196" type="corona" radius="0.0">
					<loc z="104197">0.0|0.0</loc>
					<vel z="104198">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"28"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="104199" r="0.0" op="100.0" ca="0.0">
						<e cl="CampaignTerrain" ref="104196"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="104200">
						<d z="104201"/>
					</me>
					<sc z="104202"/>
					<tags z="104203">
						<st>terrain</st>
					</tags>
					<plugin cl="StarCoronaTerrainPlugin" z="104204" tid="corona" n="Corona">
						<entity cl="CampaignTerrain" ref="104196"/>
						<params cl="CoronaParams" defined-in="BaseRingTerrain" z="104205" bWIE="1275.0" mR="637.5" wBL="10.0" fP="1.0" crLM="3.0">
							<e cl="Plnt" ref="104185"/>
						</params>
						<renderer z="104206" a="23.844818">
							<d cl="StarCoronaTerrainPlugin" ref="104204"/>
						</renderer>
						<flareManager z="104207">
							<fT z="104208" i="0.5" a="1.5" c="1.3736253" e="1.3340001" ie="false"/>
							<f z="104209">
								<Flare z="104210" d="269.25983" a="30.360142" eLM="1.4700905" eLF="359.47885" sFM="0.05" c="ffffff96">
									<f z="104211" b="0.15005568" i="9.125126" o="3.1060858" s="OUT" d="true" u="false"/>
								</Flare>
							</f>
							<d cl="StarCoronaTerrainPlugin" ref="104204"/>
						</flareManager>
						<params ref="104205"/>
					</plugin>
				</CampaignTerrain>
				<Plnt z="104212">
					<loc z="104213">-378.755|2774.2646</loc>
					<vel z="104214">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Asharu","f2":[255,255,255,255],"f3":"planet_asharu","f4":"asharu"}</j0>
					<ow ref="163"/>
					<orbit cl="COrbt" z="104215" r="2800.0" op="100.0" ca="97.77423">
						<e cl="Plnt" ref="104212"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="104216">
						<d z="104217">
							<e>
								<st>$salvageSeed</st>
								<Lp>3808933271130389082</Lp>
							</e>
							<e>
								<st>$illustrated_entity_image</st>
								<ip>172</ip>
							</e>
						</d>
					</me>
					<market cl="Market" z="104218">
						<id>asharu</id>
						<name>Asharu</name>
						<commodities z="104219">
							<COMkt z="104220" c="supplies" sto="3608.1362" mS="0" iSL="true" mD="5" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104221" b="0.0" m="986.4577">
									<fMs z="104222" s="core" v="986.4577"/>
								</g>
								<d z="104223" dC="supplies">
									<d z="104224" b="0.0" m="2959.373">
										<fMs z="104225" s="core" v="2959.373"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104226" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="104227" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104228" b="0.0" m="5.0">
									<fMs z="104229" s="core_base" d="Desired import volume (in-faction)" v="5.0"/>
								</available>
								<tradeMod z="104230" b="0.0" m="0.0"/>
								<tradeModPlus z="104231" b="0.0" m="0.0"/>
								<tradeModMinus z="104232" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104233" c="fuel" sto="4538.775" mS="0" iSL="true" mD="3" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104234" b="0.0" m="1176.8326">
									<fMs z="104235" s="core" v="1176.8326"/>
								</g>
								<d z="104236" dC="fuel">
									<d z="104237" b="0.0" m="3530.498">
										<fMs z="104238" s="core" v="3530.498"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104239" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="104240" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104241" b="0.0" m="3.0">
									<fMs z="104242" s="core_base" d="Desired import volume (in-faction)" v="3.0"/>
								</available>
								<tradeMod z="104243" b="0.0" m="0.0"/>
								<tradeModPlus z="104244" b="0.0" m="0.0"/>
								<tradeModMinus z="104245" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104246" c="crew" sto="2865.648" mS="4" iSL="true" mD="4" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104247" b="0.0" m="558.1358">
									<fMs z="104248" s="core" v="558.1358"/>
								</g>
								<d z="104249" dC="crew">
									<d z="104250" b="0.0" m="1674.4075">
										<fMs z="104251" s="core" v="1674.4075"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104252" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="104253" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104254" b="0.0" m="4.0">
									<fMs z="104255" s="core_local" d="Local production" v="4.0"/>
								</available>
								<tradeMod z="104256" b="0.0" m="0.0"/>
								<tradeModPlus z="104257" b="0.0" m="0.0"/>
								<tradeModMinus z="104258" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104259" c="food" sto="16556.027" mS="3" iSL="true" mD="7" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104260" b="0.0" m="3674.084">
									<fMs z="104261" s="core" v="3674.084"/>
								</g>
								<d z="104262" dC="food">
									<d z="104263" b="0.0" m="11022.252">
										<fMs z="104264" s="core" v="11022.252"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104265" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="104266" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104267" b="0.0" m="7.0">
									<fMs z="104268" s="core_local" d="Local production" v="3.0"/>
									<fMs z="104269" s="core_base" d="Desired import volume (in-faction)" v="4.0"/>
								</available>
								<tradeMod z="104270" b="0.0" m="0.0"/>
								<tradeModPlus z="104271" b="0.0" m="0.0"/>
								<tradeModMinus z="104272" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104273" c="heavy_machinery" sto="859.28204" mS="0" iSL="true" mD="3" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104274" b="0.0" m="282.13297">
									<fMs z="104275" s="core" v="282.13297"/>
								</g>
								<d z="104276" dC="heavy_machinery">
									<d z="104277" b="0.0" m="846.3989">
										<fMs z="104278" s="core" v="846.3989"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104279" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="104280" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104281" b="0.0" m="3.0">
									<fMs z="104282" s="core_base" d="Desired import volume (in-faction)" v="3.0"/>
								</available>
								<tradeMod z="104283" b="0.0" m="0.0"/>
								<tradeModPlus z="104284" b="0.0" m="0.0"/>
								<tradeModMinus z="104285" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104286" c="domestic_goods" sto="4060.7966" mS="0" iSL="true" mD="4" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104287" b="0.0" m="1025.3644">
									<fMs z="104288" s="core" v="1025.3644"/>
								</g>
								<d z="104289" dC="domestic_goods">
									<d z="104290" b="0.0" m="3076.0933">
										<fMs z="104291" s="core" v="3076.0933"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104292" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="104293" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104294" b="0.0" m="4.0">
									<fMs z="104295" s="core_base" d="Desired import volume (in-faction)" v="4.0"/>
								</available>
								<tradeMod z="104296" b="0.0" m="0.0"/>
								<tradeModPlus z="104297" b="0.0" m="0.0"/>
								<tradeModMinus z="104298" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104299" c="organs" sto="417.797" mS="0" iSL="true" mD="2" iDL="false" eU="0.0">
								<m ref="104218"/>
								<g z="104300" b="0.0" m="149.96243">
									<fMs z="104301" s="core" v="149.96243"/>
								</g>
								<d z="104302" dC="organs">
									<d z="104303" b="0.0" m="449.8873">
										<fMs z="104304" s="core" v="449.8873"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104305" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="104306" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104307" b="0.0" m="2.0">
									<fMs z="104308" s="core_base" d="Desired smuggling volume (in-faction)" v="2.0"/>
								</available>
								<tradeMod z="104309" b="0.0" m="0.0"/>
								<tradeModPlus z="104310" b="0.0" m="0.0"/>
								<tradeModMinus z="104311" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104312" c="drugs" sto="1547.258" mS="1" iSL="false" mD="3" iDL="false" eU="0.0">
								<m ref="104218"/>
								<g z="104313" b="0.0" m="366.88586">
									<fMs z="104314" s="core" v="366.88586"/>
								</g>
								<d z="104315" dC="drugs">
									<d z="104316" b="0.0" m="1100.6576">
										<fMs z="104317" s="core" v="1100.6576"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104318" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="104319" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104320" b="0.0" m="3.0">
									<fMs z="104321" s="core_local" d="Local production" v="1.0"/>
									<fMs z="104322" s="core_base" d="Desired smuggling volume (in-faction)" v="2.0"/>
								</available>
								<tradeMod z="104323" b="0.0" m="0.0"/>
								<tradeModPlus z="104324" b="0.0" m="0.0"/>
								<tradeModMinus z="104325" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104326" c="luxury_goods" sto="1025.8738" mS="0" iSL="true" mD="2" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104327" b="0.0" m="311.71683">
									<fMs z="104328" s="core" v="311.71683"/>
								</g>
								<d z="104329" dC="luxury_goods">
									<d z="104330" b="0.0" m="935.1505">
										<fMs z="104331" s="core" v="935.1505"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104332" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="104333" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104334" b="0.0" m="2.0">
									<fMs z="104335" s="core_base" d="Desired import volume (in-faction)" v="2.0"/>
								</available>
								<tradeMod z="104336" b="0.0" m="0.0"/>
								<tradeModPlus z="104337" b="0.0" m="0.0"/>
								<tradeModMinus z="104338" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104339" c="ships" sto="616.74567" mS="0" iSL="true" mD="3" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104340" b="0.0" m="196.88304">
									<fMs z="104341" s="core" v="196.88304"/>
								</g>
								<d z="104342" dC="ships">
									<d z="104343" b="0.0" m="590.6491">
										<fMs z="104344" s="core" v="590.6491"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104345" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="104346" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104347" b="0.0" m="3.0">
									<fMs z="104348" s="core_base" d="Desired import volume (in-faction)" v="3.0"/>
								</available>
								<tradeMod z="104349" b="0.0" m="0.0"/>
								<tradeModPlus z="104350" b="0.0" m="0.0"/>
								<tradeModMinus z="104351" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104352" c="water" sto="35761.934" mS="0" iSL="true" mD="7" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104353" b="0.0" m="9109.149">
									<fMs z="104354" s="core" v="9109.149"/>
								</g>
								<d z="104355" dC="water">
									<d z="104356" b="0.0" m="27327.45">
										<fMs z="104357" s="core" v="27327.45"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104358" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="104359" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104360" b="0.0" m="7.0">
									<fMs z="104361" s="core_base" d="Desired import volume (in-faction)" v="7.0"/>
								</available>
								<tradeMod z="104362" b="0.0" m="0.0"/>
								<tradeModPlus z="104363" b="0.0" m="0.0"/>
								<tradeModMinus z="104364" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104365" c="biotics" sto="468.64767" mS="3" iSL="true" mD="3" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104366" b="0.0" m="120.14416">
									<fMs z="104367" s="core" v="120.14416"/>
								</g>
								<d z="104368" dC="biotics">
									<d z="104369" b="0.0" m="360.43246">
										<fMs z="104370" s="core" v="360.43246"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104371" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="104372" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104373" b="0.0" m="3.0">
									<fMs z="104374" s="core_local" d="Local production" v="3.0"/>
								</available>
								<tradeMod z="104375" b="0.0" m="0.0"/>
								<tradeModPlus z="104376" b="0.0" m="0.0"/>
								<tradeModMinus z="104377" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104378" c="recitificates" sto="3749.845" mS="6" iSL="true" mD="4" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104379" b="0.0" m="826.2306">
									<fMs z="104380" s="core" v="826.2306"/>
								</g>
								<d z="104381" dC="recitificates">
									<d z="104382" b="0.0" m="2478.692">
										<fMs z="104383" s="core" v="2478.692"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104384" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="104385" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104386" b="0.0" m="6.0">
									<fMs z="104387" s="core_local" d="Local production" v="6.0"/>
								</available>
								<tradeMod z="104388" b="0.0" m="0.0"/>
								<tradeModPlus z="104389" b="0.0" m="0.0"/>
								<tradeModMinus z="104390" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104391" c="ms_hdbatteries" sto="1207.861" mS="7" iSL="true" mD="0" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104392" b="0.0" m="220.98285">
									<fMs z="104393" s="core" v="220.98285"/>
								</g>
								<d z="104394" dC="ms_hdbatteries">
									<d z="104395" b="0.0" m="662.94855">
										<fMs z="104396" s="core" v="662.94855"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104397" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="104398" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104399" b="0.0" m="7.0">
									<fMs z="104400" s="core_local" d="Local production" v="7.0"/>
								</available>
								<tradeMod z="104401" b="0.0" m="0.0"/>
								<tradeModPlus z="104402" b="0.0" m="0.0"/>
								<tradeModMinus z="104403" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104404" c="alcoholism_freedom_c" sto="1946.5939" mS="0" iSL="true" mD="3" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104405" b="0.0" m="532.55945">
									<fMs z="104406" s="core" v="532.55945"/>
								</g>
								<d z="104407" dC="alcoholism_freedom_c">
									<d z="104408" b="0.0" m="1597.6783">
										<fMs z="104409" s="core" v="1597.6783"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104410" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="104411" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104412" b="0.0" m="3.0">
									<fMs z="104413" s="core_base" d="Desired import volume (in-faction)" v="3.0"/>
								</available>
								<tradeMod z="104414" b="0.0" m="0.0"/>
								<tradeModPlus z="104415" b="0.0" m="0.0"/>
								<tradeModMinus z="104416" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104417" c="alcoholism_tea_c" sto="5183.808" mS="5" iSL="true" mD="0" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104418" b="0.0" m="679.6272">
									<fMs z="104419" s="core" v="679.6272"/>
								</g>
								<d z="104420" dC="alcoholism_tea_c">
									<d z="104421" b="0.0" m="2038.8816">
										<fMs z="104422" s="core" v="2038.8816"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104423" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="104424" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104425" b="0.0" m="5.0">
									<fMs z="104426" s="core_local" d="Local production" v="5.0"/>
								</available>
								<tradeMod z="104427" b="0.0" m="0.0"/>
								<tradeModPlus z="104428" b="0.0" m="0.0"/>
								<tradeModMinus z="104429" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104430" c="marines" sto="490.76233" mS="0" iSL="true" mD="5" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104431" b="0.0" m="175.80125">
									<fMs z="104432" s="core" v="175.80125"/>
								</g>
								<d z="104433" dC="marines">
									<d z="104434" b="0.0" m="527.40375">
										<fMs z="104435" s="core" v="527.40375"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104436" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="104437" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104438" b="0.0" m="5.0">
									<fMs z="104439" s="core_base" d="Desired import volume (in-faction)" v="5.0"/>
								</available>
								<tradeMod z="104440" b="0.0" m="0.0"/>
								<tradeModPlus z="104441" b="0.0" m="0.0"/>
								<tradeModMinus z="104442" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104443" c="hand_weapons" sto="578.18134" mS="0" iSL="true" mD="3" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104444" b="0.0" m="208.36942">
									<fMs z="104445" s="core" v="208.36942"/>
								</g>
								<d z="104446" dC="hand_weapons">
									<d z="104447" b="0.0" m="625.1083">
										<fMs z="104448" s="core" v="625.1083"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104449" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="104450" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104451" b="0.0" m="3.0">
									<fMs z="104452" s="core_base" d="Desired import volume (in-faction)" v="3.0"/>
								</available>
								<tradeMod z="104453" b="0.0" m="0.0"/>
								<tradeModPlus z="104454" b="0.0" m="0.0"/>
								<tradeModMinus z="104455" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104456" c="sotf_planetkiller" sto="0.0" mS="0" iSL="true" mD="3" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104457" b="0.0" m="208.36942">
									<fMs z="104458" s="core" v="208.36942"/>
								</g>
								<d ref="104446"/>
								<pDM z="104459" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="104460" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104461" b="0.0" m="0.0"/>
								<tradeMod z="104462" b="0.0" m="0.0"/>
								<tradeModPlus z="104463" b="0.0" m="0.0"/>
								<tradeModMinus z="104464" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="104465" c="alcoholism_water_c" sto="729.33527" mS="0" iSL="true" mD="1" iDL="true" eU="0.0">
								<m ref="104218"/>
								<g z="104466" b="0.0" m="226.23947">
									<fMs z="104467" s="core" v="226.23947"/>
								</g>
								<d z="104468" dC="alcoholism_water_c">
									<d z="104469" b="0.0" m="678.7184">
										<fMs z="104470" s="core" v="678.7184"/>
									</d>
									<m ref="104218"/>
								</d>
								<pDM z="104471" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="104472" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="104473" b="0.0" m="1.0">
									<fMs z="104474" s="core_base" d="Desired import volume (in-faction)" v="1.0"/>
								</available>
								<tradeMod z="104475" b="0.0" m="0.0"/>
								<tradeModPlus z="104476" b="0.0" m="0.0"/>
								<tradeModMinus z="104477" b="0.0" m="0.0"/>
							</COMkt>
						</commodities>
						<demandData z="104478">
							<demand z="104479" dC="polymer">
								<d z="104480" b="0.0" m="529.26874">
									<fMs z="104481" s="core" v="529.26874"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand z="104482" dC="rare_ore">
								<d z="104483" b="0.0" m="530.00836">
									<fMs z="104484" s="core" v="530.00836"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand z="104485" dC="electronics">
								<d z="104486" b="0.0" m="289.44684">
									<fMs z="104487" s="core" v="289.44684"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104468"/>
							<demand ref="104420"/>
							<demand ref="104289"/>
							<demand ref="104236"/>
							<demand z="104488" dC="alcoholism_blood_c">
								<d z="104489" b="0.0" m="514.2817">
									<fMs z="104490" s="core" v="514.2817"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104394"/>
							<demand z="104491" dC="metals">
								<d z="104492" b="0.0" m="1656.2095">
									<fMs z="104493" s="core" v="1656.2095"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104368"/>
							<demand ref="104249"/>
							<demand ref="104446"/>
							<demand z="104494" dC="vic_booze_c">
								<d z="104495" b="0.0" m="297.9776">
									<fMs z="104496" s="core" v="297.9776"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104223"/>
							<demand z="104497" dC="purified_rare_ore">
								<d z="104498" b="0.0" m="544.54877">
									<fMs z="104499" s="core" v="544.54877"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104329"/>
							<demand z="104500" dC="organics">
								<d z="104501" b="0.0" m="1321.7762">
									<fMs z="104502" s="core" v="1321.7762"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand z="104503" dC="vic_genetech">
								<d z="104504" b="0.0" m="253.87488">
									<fMs z="104505" s="core" v="253.87488"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104276"/>
							<demand z="104506" dC="alcoholism_stout_c">
								<d z="104507" b="0.0" m="527.9413">
									<fMs z="104508" s="core" v="527.9413"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand z="104509" dC="alcoholism_sunshine_c">
								<d z="104510" b="0.0" m="517.2582">
									<fMs z="104511" s="core" v="517.2582"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand z="104512" dC="IndEvo_parts">
								<d z="104513" b="0.0" m="366.38806">
									<fMs z="104514" s="core" v="366.38806"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand z="104515" dC="alcoholism_absynth_c">
								<d z="104516" b="0.0" m="550.4618">
									<fMs z="104517" s="core" v="550.4618"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104302"/>
							<demand z="104518" dC="alcoholism_king_c">
								<d z="104519" b="0.0" m="544.4202">
									<fMs z="104520" s="core" v="544.4202"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand z="104521" dC="ore">
								<d z="104522" b="0.0" m="3769.063">
									<fMs z="104523" s="core" v="3769.063"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104315"/>
							<demand z="104524" dC="alcoholism_tears_c">
								<d z="104525" b="0.0" m="542.71">
									<fMs z="104526" s="core" v="542.71"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104407"/>
							<demand z="104527" dC="alcoholism_fuel_c">
								<d z="104528" b="0.0" m="520.08875">
									<fMs z="104529" s="core" v="520.08875"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104355"/>
							<demand z="104530" dC="compound">
								<d z="104531" b="0.0" m="516.32965">
									<fMs z="104532" s="core" v="516.32965"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104262"/>
							<demand z="104533" dC="purified_ore">
								<d z="104534" b="0.0" m="529.82886">
									<fMs z="104535" s="core" v="529.82886"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand ref="104342"/>
							<demand ref="104433"/>
							<demand ref="104381"/>
							<demand z="104536" dC="domain_artifacts">
								<d z="104537" b="0.0" m="301.21432">
									<fMs z="104538" s="core" v="301.21432"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand z="104539" dC="rare_metals">
								<d z="104540" b="0.0" m="296.9098">
									<fMs z="104541" s="core" v="296.9098"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand z="104542" dC="refined_metal">
								<d z="104543" b="0.0" m="506.4273">
									<fMs z="104544" s="core" v="506.4273"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand z="104545" dC="purified_rare_metal">
								<d z="104546" b="0.0" m="529.0608">
									<fMs z="104547" s="core" v="529.0608"/>
								</d>
								<m ref="104218"/>
							</demand>
							<demand z="104548" dC="volatiles">
								<d z="104549" b="0.0" m="298.6797">
									<fMs z="104550" s="core" v="298.6797"/>
								</d>
								<m ref="104218"/>
							</demand>
							<market ref="104218"/>
						</demandData>
						<size>5</size>
						<location z="104551">400.0|-9400.0</location>
						<demandPriceMod z="104552" fB="0.0" m="1.0" pM="0.0" nR="false"/>
						<supplyPriceMod z="104553" fB="0.0" m="1.0" pM="0.0" nR="false"/>
						<tariff z="104554" b="0.0" m="0.13285714">
							<fMs z="104555" s="default_tariff" v="0.3"/>
							<mMs z="104556" s="nexerelinMult" v="0.6"/>
						</tariff>
						<factionId>independent</factionId>
						<power z="104557" b="0.0" m="9.0">
							<fMs z="104558" s="_ind_population_3_ms" d="Base value" v="5.0"/>
							<fMs z="104559" s="ind_population_0" d="Domestic goods demand met" v="1.0"/>
							<fMs z="104560" s="ind_population_1" d="Luxury goods demand met" v="1.0"/>
							<fMs z="104561" s="ind_grounddefenses" d="Ground defenses" v="1.0"/>
							<fMs z="104562" s="ind_orbitalstation_mid" d="Orbital station - midline" v="1.0"/>
						</power>
						<hazard z="104563" b="0.0" m="0.9">
							<fMs z="104564" s="haz_base" d="Base value" v="1.0"/>
							<fMs z="104565" s="hot_3dce" d="Hot" v="0.25"/>
							<fMs z="104566" s="habitable_3dd2" d="Habitable" v="-0.25"/>
							<fMs z="104567" s="tech_hazmmat" d="Hazmat Working Equipment" v="-0.1"/>
						</hazard>
						<primaryEntity cl="Plnt" ref="104212"/>
						<submarkets z="104568">
							<Submarket z="104569" s="open_market">
								<m ref="104218"/>
								<p cl="NexOpnMkt" z="104570" mSWUI="30.0" msSWU="3.2598014" sLCU="0.0">
									<m cl="Market" ref="104218"/>
									<s cl="Submarket" ref="104569"/>
									<c cl="CargoData" z="104571" uS="true" mC="1000.0" sU="9518.0" mF="500.0" mP="750.0" fT="false">
										<s z="104572">
											<CIStack z="104573" rS="false" s="353.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">supplies</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104574" rS="false" s="424.0" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">fuel</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104575" rS="false" s="754.0" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">crew</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104576" rS="false" s="47.0" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">marines</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104577" rS="false" s="84.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">heavy_machinery</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104578" rS="false" s="94.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">luxury_goods</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104579" rS="false" s="56.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">hand_weapons</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104580" rS="false" s="377.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">domestic_goods</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104581" rS="false" s="183.0" mS="1000000.0" cSPU="0.5" t="RESOURCES">
												<d cl="st">alcoholism_freedom_c</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104582" rS="false" s="943.0" mS="1000000.0" cSPU="0.5" t="RESOURCES">
												<d cl="st">alcoholism_tea_c</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104583" rS="false" s="66.0" mS="1000000.0" cSPU="0.5" t="RESOURCES">
												<d cl="st">alcoholism_water_c</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104584" rS="false" s="264.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">ms_hdbatteries</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104585" rS="false" s="3018.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">food</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104586" rS="false" s="3301.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">water</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104587" rS="false" s="113.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">biotics</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104588" rS="false" s="1131.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">recitificates</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104589" rS="true" s="1.0" mS="1000000.0" cSPU="8.0" t="WEAPONS">
												<d cl="st">hammerrack</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104590" rS="true" s="1.0" mS="1000000.0" cSPU="8.0" t="WEAPONS">
												<d cl="st">hellbore</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104591" rS="true" s="7.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">miningblaster</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104592" rS="true" s="4.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">shredder</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104593" rS="true" s="7.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">filgap_david</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104594" rS="true" s="7.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">harpoon_single</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104595" rS="true" s="6.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">ii_particlegun</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104596" rS="true" s="5.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">maiden</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104597" rS="true" s="3.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">hammer</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104598" rS="true" s="1.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">sabot_single</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104599" rS="true" s="3.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
												<d cl="st">broadsword_wing</d>
												<c ref="104571"/>
											</CIStack>
											<CIStack z="104600" rS="true" s="10.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
												<d cl="st">talon_wing</d>
												<c ref="104571"/>
											</CIStack>
										</s>
										<c z="104601">
											<value>0.0</value>
										</c>
										<mS z="104602" nP="ISS" nSf="independent" nS="false" oSML="false">
											<m z="104603">
												<FMmbr z="104604" o="0" sid="condor_Hull" sN="ISS Quantum Break" t="SHIP" iF="false" id="71d2b2" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104605" hId="condor_default_D" v="0" c="0" hVId="condor_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104606"/>
														<sM z="104607"/>
														<wng z="104608"/>
														<wG z="104609"/>
														<hM z="104610">
															<st>glitched_sensors</st>
															<st>erratic_injector</st>
															<st>degraded_life_support</st>
															<st>faulty_grid</st>
															<st>damaged_mounts</st>
														</hM>
														<pM z="104611">
															<st>glitched_sensors</st>
															<st>erratic_injector</st>
															<st>degraded_life_support</st>
															<st>faulty_grid</st>
															<st>damaged_mounts</st>
														</pM>
														<sMods z="104612"/>
														<sModdedBuiltIns z="104613"/>
														<suM z="104614"/>
													</savedVariant>
													<rT z="104615" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104604"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
												<FMmbr z="104616" o="0" sid="tahlan_Bento_Hull" sN="ISS The Planet of Errors" t="SHIP" iF="false" id="71d2c6" sUN="false" civ="false" cCiv="false">
													<rT z="104617" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104616"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
												<FMmbr z="104618" o="0" sid="valhalla_Hull" sN="ISS Body Snatchers" t="SHIP" iF="false" id="71d2c8" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104619" hId="valhalla_default_D" v="0" c="0" hVId="valhalla_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104620"/>
														<sM z="104621"/>
														<wng z="104622"/>
														<wG z="104623"/>
														<hM z="104624">
															<st>blockade</st>
															<st>shielded_holds</st>
															<st>increased_maintenance</st>
														</hM>
														<pM z="104625">
															<st>increased_maintenance</st>
														</pM>
														<sMods z="104626"/>
														<sModdedBuiltIns z="104627"/>
														<suM z="104628"/>
													</savedVariant>
													<rT z="104629" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104618"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
												<FMmbr z="104630" o="0" sid="uw_scythe_Hull" sN="ISS Tethra" t="SHIP" iF="false" id="71d2b4" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104631" hId="uw_scythe_default_D" v="0" c="0" hVId="uw_scythe_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104632"/>
														<sM z="104633"/>
														<wng z="104634"/>
														<wG z="104635"/>
														<hM z="104636">
															<st>phasefield</st>
															<st>delicate</st>
															<st>erratic_injector</st>
															<st>glitched_sensors</st>
															<st>degraded_engines</st>
															<st>unstable_coils</st>
															<st>damaged_mounts</st>
														</hM>
														<pM z="104637">
															<st>erratic_injector</st>
															<st>glitched_sensors</st>
															<st>degraded_engines</st>
															<st>unstable_coils</st>
															<st>damaged_mounts</st>
														</pM>
														<sMods z="104638"/>
														<sModdedBuiltIns z="104639"/>
														<suM z="104640"/>
													</savedVariant>
													<rT z="104641" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104630"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
												<FMmbr z="104642" o="0" sid="supportships_maunder_Hull" sN="ISS Velasco" t="SHIP" iF="false" id="71d2b6" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104643" hId="supportships_maunder_default_D" v="0" c="0" hVId="supportships_maunder_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104644"/>
														<sM z="104645"/>
														<wng z="104646"/>
														<wG z="104647"/>
														<hM z="104648">
															<st>comp_hull</st>
															<st>erratic_injector</st>
															<st>faulty_auto</st>
															<st>glitched_sensors</st>
															<st>degraded_engines</st>
														</hM>
														<pM z="104649">
															<st>comp_hull</st>
															<st>erratic_injector</st>
															<st>faulty_auto</st>
															<st>glitched_sensors</st>
															<st>degraded_engines</st>
														</pM>
														<sMods z="104650"/>
														<sModdedBuiltIns z="104651"/>
														<suM z="104652"/>
													</savedVariant>
													<rT z="104653" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104642"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
												<FMmbr z="104654" o="0" sid="mercury_Hull" sN="ISS Stars, Like Dust" t="SHIP" iF="false" id="71d292" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104655" hId="mercury_default_D" v="0" c="0" hVId="mercury_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104656"/>
														<sM z="104657"/>
														<wng z="104658"/>
														<wG z="104659"/>
														<hM z="104660">
															<st>civgrade</st>
															<st>erratic_injector</st>
															<st>degraded_drive_field</st>
														</hM>
														<pM z="104661">
															<st>erratic_injector</st>
															<st>degraded_drive_field</st>
														</pM>
														<sMods z="104662"/>
														<sModdedBuiltIns z="104663"/>
														<suM z="104664"/>
													</savedVariant>
													<rT z="104665" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104654"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
												<FMmbr z="104666" o="0" sid="mercury_Hull" sN="ISS Provence" t="SHIP" iF="false" id="71d294" sUN="false" civ="false" cCiv="false">
													<rT z="104667" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104666"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
												<FMmbr z="104668" o="0" sid="mercury_Hull" sN="ISS Ambivalent World" t="SHIP" iF="false" id="71d296" sUN="false" civ="false" cCiv="false">
													<rT z="104669" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104668"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
												<FMmbr z="104670" o="0" sid="mudskipper_Hull" sN="ISS Pyrrha" t="SHIP" iF="false" id="71d298" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104671" hId="mudskipper_default_D" v="0" c="0" hVId="mudskipper_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104672"/>
														<sM z="104673"/>
														<wng z="104674"/>
														<wG z="104675"/>
														<hM z="104676">
															<st>civgrade</st>
															<st>degraded_drive_field</st>
															<st>increased_maintenance</st>
														</hM>
														<pM z="104677">
															<st>degraded_drive_field</st>
															<st>increased_maintenance</st>
														</pM>
														<sMods z="104678"/>
														<sModdedBuiltIns z="104679"/>
														<suM z="104680"/>
													</savedVariant>
													<rT z="104681" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104670"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
												<FMmbr z="104682" o="0" sid="mudskipper_Hull" sN="ISS Myrtilus" t="SHIP" iF="false" id="71d29a" sUN="false" civ="false" cCiv="false">
													<rT z="104683" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104682"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
												<FMmbr z="104684" o="0" sid="dram_Hull" sN="ISS Emerald Sea" t="SHIP" iF="false" id="71d2ca" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104685" hId="dram_default_D" v="0" c="0" hVId="dram_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104686"/>
														<sM z="104687"/>
														<wng z="104688"/>
														<wG z="104689"/>
														<hM z="104690">
															<st>civgrade</st>
															<st>increased_maintenance</st>
															<st>comp_storage</st>
														</hM>
														<pM z="104691">
															<st>increased_maintenance</st>
															<st>comp_storage</st>
														</pM>
														<sMods z="104692"/>
														<sModdedBuiltIns z="104693"/>
														<suM z="104694"/>
													</savedVariant>
													<rT z="104695" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104684"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
												<FMmbr z="104696" o="0" sid="ox_Hull" sN="ISS Bright Future" t="SHIP" iF="false" id="71d29c" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104697" hId="ox_default_D" v="0" c="0" hVId="ox_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104698"/>
														<sM z="104699"/>
														<wng z="104700"/>
														<wG z="104701"/>
														<hM z="104702">
															<st>drive_field_stabilizer</st>
															<st>high_maintenance</st>
															<st>civgrade</st>
															<st>degraded_drive_field</st>
															<st>comp_storage</st>
														</hM>
														<pM z="104703">
															<st>degraded_drive_field</st>
															<st>comp_storage</st>
														</pM>
														<sMods z="104704"/>
														<sModdedBuiltIns z="104705"/>
														<suM z="104706"/>
													</savedVariant>
													<rT z="104707" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104696"/>
													</rT>
													<fD ref="104602"/>
												</FMmbr>
											</m>
										</mS>
									</c>
									<iGR z="104708" serialization="custom">
										<Random>
											<default>
												<s>92603438730409</s>
												<n>0.0</n>
												<h>false</h>
											</default>
										</Random>
									</iGR>
								</p>
								<f ref="163"/>
							</Submarket>
							<Submarket z="104709" s="black_market">
								<m ref="104218"/>
								<p cl="NexBlackMkt" z="104710" mSWUI="30.0" msSWU="3.2598014" sLCU="0.0">
									<m cl="Market" ref="104218"/>
									<s cl="Submarket" ref="104709"/>
									<c cl="CargoData" z="104711" uS="true" mC="1000.0" sU="3680.5" mF="500.0" mP="750.0" fT="false">
										<s z="104712">
											<CIStack z="104713" rS="false" s="130.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">supplies</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104714" rS="false" s="156.0" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">fuel</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104715" rS="false" s="278.0" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">crew</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104716" rS="false" s="17.0" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">marines</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104717" rS="false" s="31.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">heavy_machinery</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104718" rS="false" s="34.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">luxury_goods</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104719" rS="false" s="20.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">hand_weapons</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104720" rS="false" s="83.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">drugs</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104721" rS="false" s="13.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">organs</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104722" rS="false" s="139.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">domestic_goods</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104723" rS="false" s="67.0" mS="1000000.0" cSPU="0.5" t="RESOURCES">
												<d cl="st">alcoholism_freedom_c</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104724" rS="false" s="348.0" mS="1000000.0" cSPU="0.5" t="RESOURCES">
												<d cl="st">alcoholism_tea_c</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104725" rS="false" s="24.0" mS="1000000.0" cSPU="0.5" t="RESOURCES">
												<d cl="st">alcoholism_water_c</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104726" rS="false" s="97.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">ms_hdbatteries</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104727" rS="false" s="1115.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">food</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104728" rS="false" s="1220.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">water</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104729" rS="false" s="41.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">biotics</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104730" rS="false" s="418.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">recitificates</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104731" rS="true" s="1.0" mS="1000000.0" cSPU="8.0" t="WEAPONS">
												<d cl="st">filgap_scorpius</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104732" rS="true" s="5.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">arbalest</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104733" rS="true" s="4.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">pulselaser</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104734" rS="true" s="3.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">tahlan_atrapos</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104735" rS="true" s="1.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">heavymauler</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104736" rS="true" s="7.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">tahlan_hekaton_rack</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104737" rS="true" s="6.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">sabot_single</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104738" rS="true" s="5.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">lrpdlaser</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104739" rS="true" s="4.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">lightac</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104740" rS="true" s="2.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">lightneedler</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104741" rS="true" s="2.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">swarmer</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104742" rS="true" s="1.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
												<d cl="st">longbow_wing</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104743" rS="true" s="1.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
												<d cl="st">mining_drone_wing</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104744" rS="true" s="3.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
												<d cl="st">piranha_wing</d>
												<c ref="104711"/>
											</CIStack>
											<CIStack z="104745" rS="true" s="3.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
												<d cl="st">uw_razor_wing</d>
												<c ref="104711"/>
											</CIStack>
										</s>
										<c z="104746">
											<value>0.0</value>
										</c>
										<mS z="104747" nP="" nSf="pirates" nS="false" oSML="false">
											<m z="104748">
												<FMmbr z="104749" o="0" sid="eradicator_pirates_Hull" sN="Ashtaru the Terrible" t="SHIP" iF="false" id="71d318" sUN="false" civ="false" cCiv="false">
													<rT z="104750" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104749"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104751" o="0" sid="BSC_Starliner_MK2_Hull" sN="Long Fuse" t="SHIP" iF="false" id="71d31a" sUN="false" civ="false" cCiv="false">
													<rT z="104752" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104751"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104753" o="0" sid="BSC_Roamer_Hull" sN="Final Victim" t="SHIP" iF="false" id="71d31c" sUN="false" civ="false" cCiv="false">
													<rT z="104754" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104753"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104755" o="0" sid="fasces_Hull" sN="Keyboard Rich" t="SHIP" iF="false" id="71d2de" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104756" hId="fasces_default_D" v="0" c="0" hVId="fasces_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104757"/>
														<sM z="104758"/>
														<wng z="104759"/>
														<wG z="104760"/>
														<hM z="104761">
															<st>comp_structure</st>
														</hM>
														<pM z="104762">
															<st>comp_structure</st>
														</pM>
														<sMods z="104763"/>
														<sModdedBuiltIns z="104764"/>
														<suM z="104765"/>
													</savedVariant>
													<rT z="104766" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104755"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104767" o="0" sid="supportships_lammergeier_Hull" sN="Screaming in the Night" t="SHIP" iF="false" id="71d2e0" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104768" hId="supportships_lammergeier_default_D" v="0" c="0" hVId="supportships_lammergeier_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104769"/>
														<sM z="104770"/>
														<wng z="104771"/>
														<wG z="104772"/>
														<hM z="104773">
															<st>supportships_vent_shields</st>
															<st>degraded_engines</st>
														</hM>
														<pM z="104774">
															<st>degraded_engines</st>
														</pM>
														<sMods z="104775"/>
														<sModdedBuiltIns z="104776"/>
														<suM z="104777"/>
													</savedVariant>
													<rT z="104778" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104767"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104779" o="0" sid="BSC_Buffalo_Mk3_Hull" sN="Keresh" t="SHIP" iF="false" id="71d31e" sUN="false" civ="false" cCiv="false">
													<rT z="104780" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104779"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104781" o="0" sid="supportships_nebulae_Hull" sN="Under Wine-bright Seas" t="SHIP" iF="false" id="71d320" sUN="false" civ="false" cCiv="false">
													<rT z="104782" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104781"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104783" o="0" sid="missp_buffalomkiii_Hull" sN="Not to Mention Camels" t="SHIP" iF="false" id="71d322" sUN="false" civ="false" cCiv="false">
													<rT z="104784" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104783"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104785" o="0" sid="afflictor_d_pirates_Hull" sN="The Jovian Horde" t="SHIP" iF="false" id="71d324" sUN="false" civ="false" cCiv="false">
													<rT z="104786" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104785"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104787" o="0" sid="uw_scythe_Hull" sN="Daughter of Sheba" t="SHIP" iF="false" id="71d326" sUN="false" civ="false" cCiv="false">
													<rT z="104788" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104787"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104789" o="0" sid="supportships_maunder_Hull" sN="Man-jewels for Xothar" t="SHIP" iF="false" id="71d2e2" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104790" hId="supportships_maunder_default_D" v="0" c="0" hVId="supportships_maunder_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104791"/>
														<sM z="104792"/>
														<wng z="104793"/>
														<wG z="104794"/>
														<hM z="104795">
															<st>faulty_auto</st>
															<st>degraded_life_support</st>
														</hM>
														<pM z="104796">
															<st>faulty_auto</st>
															<st>degraded_life_support</st>
														</pM>
														<sMods z="104797"/>
														<sModdedBuiltIns z="104798"/>
														<suM z="104799"/>
													</savedVariant>
													<rT z="104800" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104789"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104801" o="0" sid="centurion_Hull" sN="Star Crossing" t="SHIP" iF="false" id="71d33e" sUN="false" civ="false" cCiv="false">
													<rT z="104802" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104801"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104803" o="0" sid="strix_Hull" sN="Another Word for World" t="SHIP" iF="false" id="71d2e4" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104804" hId="strix_default_D" v="0" c="0" hVId="strix_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104805">
															<e>
																<st>WS0003</st>
																<st>heavyburst</st>
															</e>
															<e>
																<st>WS0002</st>
																<st>heavyburst</st>
															</e>
														</wpn>
														<sM z="104806"/>
														<wng z="104807"/>
														<wG z="104808"/>
														<hM z="104809">
															<st>fluxshunt</st>
															<st>pointdefenseai</st>
															<st>faulty_auto</st>
														</hM>
														<pM z="104810">
															<st>faulty_auto</st>
														</pM>
														<sMods z="104811"/>
														<sModdedBuiltIns z="104812"/>
														<suM z="104813"/>
													</savedVariant>
													<rT z="104814" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104803"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104815" o="0" sid="cerberus_d_pirates_Hull" sN="Flotsam and Jetsam" t="SHIP" iF="false" id="71d328" sUN="false" civ="false" cCiv="false">
													<rT z="104816" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104815"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104817" o="0" sid="shepherd_Hull" sN="Lord of the Silent Death" t="SHIP" iF="false" id="71d2e6" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104818" hId="shepherd_default_D" v="0" c="0" hVId="shepherd_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104819"/>
														<sM z="104820"/>
														<wng z="104821">
															<st>borer_wing</st>
														</wng>
														<wG z="104822"/>
														<hM z="104823">
															<st>civgrade</st>
															<st>surveying_equipment</st>
															<st>repair_gantry</st>
															<st>glitched_sensors</st>
														</hM>
														<pM z="104824">
															<st>glitched_sensors</st>
														</pM>
														<sMods z="104825"/>
														<sModdedBuiltIns z="104826"/>
														<suM z="104827"/>
													</savedVariant>
													<rT z="104828" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104817"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104829" o="0" sid="BSC_Covetor_P_Hull" sN="The Sea Terror" t="SHIP" iF="false" id="71d32a" sUN="false" civ="false" cCiv="false">
													<rT z="104830" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104829"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104831" o="0" sid="kite_Hull" sN="Lenticular Galaxy" t="SHIP" iF="false" id="71d2e8" sUN="false" civ="false" cCiv="false">
													<savedVariant z="104832" hId="kite_default_D" v="0" c="0" hVId="kite_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="104833"/>
														<sM z="104834"/>
														<wng z="104835"/>
														<wG z="104836"/>
														<hM z="104837">
															<st>civgrade</st>
															<st>fragile_subsystems</st>
														</hM>
														<pM z="104838">
															<st>fragile_subsystems</st>
														</pM>
														<sMods z="104839"/>
														<sModdedBuiltIns z="104840"/>
														<suM z="104841"/>
													</savedVariant>
													<rT z="104842" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104831"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104843" o="0" sid="kite_Hull" sN="Jorogumo" t="SHIP" iF="false" id="71d340" sUN="false" civ="false" cCiv="false">
													<rT z="104844" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104843"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104845" o="0" sid="BSC_Tramp_Hull" sN="The Sorcerer of Kambara" t="SHIP" iF="false" id="71d32c" sUN="false" civ="false" cCiv="false">
													<rT z="104846" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104845"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
												<FMmbr z="104847" o="0" sid="BSC_Tramp_Hull" sN="Hangman's Chain" t="SHIP" iF="false" id="71d32e" sUN="false" civ="false" cCiv="false">
													<rT z="104848" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="104847"/>
													</rT>
													<fD ref="104747"/>
												</FMmbr>
											</m>
										</mS>
									</c>
									<iGR z="104849" serialization="custom">
										<Random>
											<default>
												<s>135450013083280</s>
												<n>0.0</n>
												<h>false</h>
											</default>
										</Random>
									</iGR>
								</p>
								<f ref="1899"/>
							</Submarket>
							<Submarket z="104850" s="storage">
								<m ref="104218"/>
								<p cl="NexStoreSubmkt" z="104851" mSWUI="30.0" msSWU="2525.8877" sLCU="2525.8877" paid="false">
									<m cl="Market" ref="104218"/>
									<s cl="Submarket" ref="104850"/>
									<c cl="CargoData" z="104852" uS="true" mC="1000.0" sU="50.0" mF="500.0" mP="750.0" fT="false">
										<s z="104853"/>
										<c z="104854">
											<value>0.0</value>
										</c>
										<mS z="104855" nP="ISS" nSf="player" nS="false" oSML="false">
											<m z="104856"/>
										</mS>
									</c>
									<iGR z="104857" serialization="custom">
										<Random>
											<default>
												<s>171689835115780</s>
												<n>0.0</n>
												<h>false</h>
											</default>
										</Random>
									</iGR>
								</p>
								<f ref="1031"/>
							</Submarket>
						</submarkets>
						<memory cl="Memory" z="104858">
							<d z="104859">
								<e>
									<st>$ruinsExplored</st>
									<bp>true</bp>
								</e>
								<e>
									<st>$startingFactionId</st>
									<st>independent</st>
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
									<st>$BreweriesHaveBeenPlaced</st>
									<bp>true</bp>
								</e>
								<e>
									<st>$nex_fleetPoolPointsLastTick</st>
									<fp>0.13875</fp>
								</e>
								<e>
									<st>$nex_groundPoolPointsLastTick</st>
									<fp>0.17205001</fp>
								</e>
								<e>
									<st>$visitedBefore</st>
									<bp>true</bp>
								</e>
								<e>
									<st>$mmm_mbm_random</st>
									<Random z="104860" serialization="custom">
										<Random>
											<default>
												<s>106886794339341</s>
												<n>0.0</n>
												<h>false</h>
											</default>
										</Random>
									</Random>
								</e>
								<e>
									<st>$mmm_mbm_data</st>
									<map z="104861">
										<e>
											<st>dsp</st>
											<Lp-array z="104862">
												<Lp>0</Lp>
												<Lp>-55611572058534</Lp>
												<Lp>-8514737872147775562</Lp>
											</Lp-array>
										</e>
										<e>
											<st>DiktatLobsterBarEvent</st>
											<Lp-array z="104863">
												<Lp>0</Lp>
												<Lp>-55612070211170</Lp>
												<Lp>-593699991046205185</Lp>
											</Lp-array>
										</e>
										<e>
											<st>LuddicCraftBarEvent</st>
											<Lp-array z="104864">
												<Lp>0</Lp>
												<Lp>-55613212509254</Lp>
												<Lp>8538090093379421643</Lp>
											</Lp-array>
										</e>
										<e>
											<st>seco</st>
											<Lp-array z="104865">
												<Lp>1</Lp>
												<Lp>-55611507564063</Lp>
												<Lp>3590868382535020196</Lp>
											</Lp-array>
										</e>
										<e>
											<st>proCom</st>
											<Lp-array z="104866">
												<Lp>0</Lp>
												<Lp>-55612136163087</Lp>
												<Lp>5653020256610983729</Lp>
											</Lp-array>
										</e>
										<e>
											<st>tabo</st>
											<Lp-array z="104867">
												<Lp>0</Lp>
												<Lp>-55612432852613</Lp>
												<Lp>3259272620962977774</Lp>
											</Lp-array>
										</e>
										<e>
											<st>HistorianBarEvent</st>
											<Lp-array z="104868">
												<Lp>1</Lp>
												<Lp>-55612822893849</Lp>
												<Lp>-2657401401131364684</Lp>
											</Lp-array>
										</e>
										<e>
											<st>mcb</st>
											<Lp-array z="104869">
												<Lp>2</Lp>
												<Lp>-55613624523915</Lp>
												<Lp>3217011951184273404</Lp>
											</Lp-array>
										</e>
										<e>
											<st>nex_msb</st>
											<Lp-array z="104870">
												<Lp>0</Lp>
												<Lp>-55611514309779</Lp>
												<Lp>-4694606349879744909</Lp>
											</Lp-array>
										</e>
										<e>
											<st>hijack</st>
											<Lp-array z="104871">
												<Lp>1</Lp>
												<Lp>-55611742123268</Lp>
												<Lp>-575405200794892352</Lp>
											</Lp-array>
										</e>
										<e>
											<st>ddro</st>
											<Lp-array z="104872">
												<Lp>1</Lp>
												<Lp>-55611886441432</Lp>
												<Lp>4857228693548801145</Lp>
											</Lp-array>
										</e>
										<e>
											<st>LuddicFarmerBarEvent</st>
											<Lp-array z="104873">
												<Lp>0</Lp>
												<Lp>-55612141712721</Lp>
												<Lp>-3888411368166787616</Lp>
											</Lp-array>
										</e>
										<e>
											<st>ucb</st>
											<Lp-array z="104874">
												<Lp>2</Lp>
												<Lp>-55613628248197</Lp>
												<Lp>3613179271159901649</Lp>
											</Lp-array>
										</e>
										<e>
											<st>cpc</st>
											<Lp-array z="104875">
												<Lp>2</Lp>
												<Lp>-55613333131556</Lp>
												<Lp>4768207335335527975</Lp>
											</Lp-array>
										</e>
										<e>
											<st>CorruptPLClerkSuppliesBarEvent</st>
											<Lp-array z="104876">
												<Lp>0</Lp>
												<Lp>-55612798040302</Lp>
												<Lp>-6489396204891282908</Lp>
											</Lp-array>
										</e>
										<e>
											<st>smug</st>
											<Lp-array z="104877">
												<Lp>0</Lp>
												<Lp>-55613147827412</Lp>
												<Lp>839006660849008708</Lp>
											</Lp-array>
										</e>
										<e>
											<st>extr</st>
											<Lp-array z="104878">
												<Lp>1</Lp>
												<Lp>-55611670712684</Lp>
												<Lp>1222242655715924065</Lp>
											</Lp-array>
										</e>
										<e>
											<st>cpm</st>
											<Lp-array z="104879">
												<Lp>2</Lp>
												<Lp>-55613534118080</Lp>
												<Lp>-7167380746155490057</Lp>
											</Lp-array>
										</e>
										<e>
											<st>dhi</st>
											<Lp-array z="104880">
												<Lp>0</Lp>
												<Lp>-55612259940388</Lp>
												<Lp>4442317977574997818</Lp>
											</Lp-array>
										</e>
										<e>
											<st>ssat</st>
											<Lp-array z="104881">
												<Lp>1</Lp>
												<Lp>-55611709365003</Lp>
												<Lp>-2930790949754818991</Lp>
											</Lp-array>
										</e>
										<e>
											<st>DeliveryBarEvent</st>
											<Lp-array z="104882">
												<Lp>0</Lp>
												<Lp>-55612685748384</Lp>
												<Lp>-5070284210700801388</Lp>
											</Lp-array>
										</e>
										<e>
											<st>QuartermasterCargoSwapBarEvent</st>
											<Lp-array z="104883">
												<Lp>0</Lp>
												<Lp>-55612391955787</Lp>
												<Lp>-978508537172749350</Lp>
											</Lp-array>
										</e>
										<e>
											<st>MercsOnTheRunBarEvent</st>
											<Lp-array z="104884">
												<Lp>2</Lp>
												<Lp>-55611539621949</Lp>
												<Lp>1393685389559346883</Lp>
											</Lp-array>
										</e>
										<e>
											<st>lpt</st>
											<Lp-array z="104885">
												<Lp>0</Lp>
												<Lp>-55611747384840</Lp>
												<Lp>861763574679052265</Lp>
											</Lp-array>
										</e>
										<e>
											<st>ttscmtwo</st>
											<Lp-array z="104886">
												<Lp>0</Lp>
												<Lp>-55611946943580</Lp>
												<Lp>-6769619700329452200</Lp>
											</Lp-array>
										</e>
										<e>
											<st>cheapCom</st>
											<Lp-array z="104887">
												<Lp>0</Lp>
												<Lp>-55611804250624</Lp>
												<Lp>5955082815151960495</Lp>
											</Lp-array>
										</e>
										<e>
											<st>nex_bShip</st>
											<Lp-array z="104888">
												<Lp>0</Lp>
												<Lp>-55613114496650</Lp>
												<Lp>-4129606406316419501</Lp>
											</Lp-array>
										</e>
										<e>
											<st>dcom</st>
											<Lp-array z="104889">
												<Lp>1</Lp>
												<Lp>-55611809761695</Lp>
												<Lp>2857568888119906500</Lp>
											</Lp-array>
										</e>
										<e>
											<st>sShip</st>
											<Lp-array z="104890">
												<Lp>0</Lp>
												<Lp>-55612029666017</Lp>
												<Lp>905248102276725794</Lp>
											</Lp-array>
										</e>
										<e>
											<st>jabr</st>
											<Lp-array z="104891">
												<Lp>2</Lp>
												<Lp>-55613643989738</Lp>
												<Lp>5601587541500252077</Lp>
											</Lp-array>
										</e>
										<e>
											<st>TriTachLoanBarEvent</st>
											<Lp-array z="104892">
												<Lp>0</Lp>
												<Lp>-55612879242506</Lp>
												<Lp>3131259588708972188</Lp>
											</Lp-array>
										</e>
										<e>
											<st>hmdf</st>
											<Lp-array z="104893">
												<Lp>2</Lp>
												<Lp>-55613310667372</Lp>
												<Lp>5914231760247015789</Lp>
											</Lp-array>
										</e>
										<e>
											<st>sitm</st>
											<Lp-array z="104894">
												<Lp>0</Lp>
												<Lp>-55612290240406</Lp>
												<Lp>1929392644318168347</Lp>
											</Lp-array>
										</e>
										<e>
											<st>locrlf</st>
											<Lp-array z="104895">
												<Lp>0</Lp>
												<Lp>-55612637767353</Lp>
												<Lp>2878897677450651801</Lp>
											</Lp-array>
										</e>
										<e>
											<st>TriTachMajorLoanBarEvent</st>
											<Lp-array z="104896">
												<Lp>0</Lp>
												<Lp>-55611925642518</Lp>
												<Lp>6781224877138073298</Lp>
											</Lp-array>
										</e>
										<e>
											<st>psb</st>
											<Lp-array z="104897">
												<Lp>1</Lp>
												<Lp>-55611861480274</Lp>
												<Lp>-7041557872535981819</Lp>
											</Lp-array>
										</e>
										<e>
											<st>nex_dcom</st>
											<Lp-array z="104898">
												<Lp>0</Lp>
												<Lp>-55611506269435</Lp>
												<Lp>-3868335896590225596</Lp>
											</Lp-array>
										</e>
									</map>
								</e>
								<e>
									<st>$mmm_mbm_last_added</st>
									<Lp>-55614958874000</Lp>
								</e>
								<e>
									<st>$ST_SmallFreightMissions</st>
									<list z="104899">
										<Util.MissionGen.USLMissionDetails z="104900">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>agreus</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>KoC</destinationFactionID>
											<commodityID>biotics</commodityID>
											<reward>13534</reward>
											<escrow>0</escrow>
											<quantity>440</quantity>
											<unitPrice>0</unitPrice>
											<duration>10.0</duration>
											<distance>1.9144189</distance>
											<expiration>4.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104901">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>chicomoztoc</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>hegemony</destinationFactionID>
											<commodityID>biotics</commodityID>
											<reward>5534</reward>
											<escrow>0</escrow>
											<quantity>149</quantity>
											<unitPrice>0</unitPrice>
											<duration>21.0</duration>
											<distance>2.9436371</distance>
											<expiration>9.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104902">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>bythinia</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>luddic_church</destinationFactionID>
											<commodityID>biotics</commodityID>
											<reward>9054</reward>
											<escrow>0</escrow>
											<quantity>234</quantity>
											<unitPrice>0</unitPrice>
											<duration>34.0</duration>
											<distance>7.775161</distance>
											<expiration>8.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104903">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>ii_cydonia</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>tritachyon</destinationFactionID>
											<commodityID>food</commodityID>
											<reward>7118</reward>
											<escrow>0</escrow>
											<quantity>489</quantity>
											<unitPrice>0</unitPrice>
											<duration>31.0</duration>
											<distance>7.0007143</distance>
											<expiration>9.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104904">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>eventide</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>hegemony</destinationFactionID>
											<commodityID>alcoholism_tea_c</commodityID>
											<reward>8861</reward>
											<escrow>0</escrow>
											<quantity>222</quantity>
											<unitPrice>0</unitPrice>
											<duration>18.0</duration>
											<distance>3.2742367</distance>
											<expiration>6.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
									</list>
								</e>
								<e>
									<st>$ST_MediumFreightMissions</st>
									<list z="104905">
										<Util.MissionGen.USLMissionDetails z="104906">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>diableavionics_eclipse</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>diableavionics</destinationFactionID>
											<commodityID>biotics</commodityID>
											<reward>31917</reward>
											<escrow>0</escrow>
											<quantity>1040</quantity>
											<unitPrice>0</unitPrice>
											<duration>35.0</duration>
											<distance>9.824967</distance>
											<expiration>6.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104907">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>theramin</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>shadow_industry</destinationFactionID>
											<commodityID>ms_hdbatteries</commodityID>
											<reward>12154</reward>
											<escrow>0</escrow>
											<quantity>758</quantity>
											<unitPrice>0</unitPrice>
											<duration>30.0</duration>
											<distance>7.940403</distance>
											<expiration>9.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104908">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>orbitalThree_market</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>xhanempire</destinationFactionID>
											<commodityID>recitificates</commodityID>
											<reward>88644</reward>
											<escrow>0</escrow>
											<quantity>1999</quantity>
											<unitPrice>0</unitPrice>
											<duration>77.0</duration>
											<distance>22.193016</distance>
											<expiration>9.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104909">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>ii_cydonia</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>tritachyon</destinationFactionID>
											<commodityID>food</commodityID>
											<reward>14603</reward>
											<escrow>0</escrow>
											<quantity>1133</quantity>
											<unitPrice>0</unitPrice>
											<duration>35.0</duration>
											<distance>7.0007143</distance>
											<expiration>4.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104910">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>vic_planet_maria_market</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>independent</destinationFactionID>
											<commodityID>biotics</commodityID>
											<reward>48770</reward>
											<escrow>0</escrow>
											<quantity>1683</quantity>
											<unitPrice>0</unitPrice>
											<duration>29.0</duration>
											<distance>6.4878736</distance>
											<expiration>2.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
									</list>
								</e>
								<e>
									<st>$ST_LargeFreightMissions</st>
									<list z="104911">
										<Util.MissionGen.USLMissionDetails z="104912">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>Apocrita</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>apocrita_association</destinationFactionID>
											<commodityID>alcoholism_tea_c</commodityID>
											<reward>168607</reward>
											<escrow>0</escrow>
											<quantity>5491</quantity>
											<unitPrice>0</unitPrice>
											<duration>33.0</duration>
											<distance>9.507892</distance>
											<expiration>5.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104913">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>clusterOrbital_market</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>xhanempire</destinationFactionID>
											<commodityID>recitificates</commodityID>
											<reward>118488</reward>
											<escrow>0</escrow>
											<quantity>3006</quantity>
											<unitPrice>0</unitPrice>
											<duration>80.0</duration>
											<distance>22.193016</distance>
											<expiration>4.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104914">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>ii_cydonia</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>tritachyon</destinationFactionID>
											<commodityID>food</commodityID>
											<reward>45267</reward>
											<escrow>0</escrow>
											<quantity>3951</quantity>
											<unitPrice>0</unitPrice>
											<duration>33.0</duration>
											<distance>7.0007143</distance>
											<expiration>9.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104915">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>ii_nova_capitalis</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>interstellarimperium</destinationFactionID>
											<commodityID>alcoholism_tea_c</commodityID>
											<reward>132044</reward>
											<escrow>0</escrow>
											<quantity>4119</quantity>
											<unitPrice>0</unitPrice>
											<duration>49.0</duration>
											<distance>12.126932</distance>
											<expiration>3.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104916">
											<missionType>FREIGHT</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>olinadu</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>persean</destinationFactionID>
											<commodityID>biotics</commodityID>
											<reward>56736</reward>
											<escrow>0</escrow>
											<quantity>2200</quantity>
											<unitPrice>0</unitPrice>
											<duration>27.0</duration>
											<distance>6.555151</distance>
											<expiration>6.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
									</list>
								</e>
								<e>
									<st>$ST_StandardParcelMissions</st>
									<list z="104917">
										<Util.MissionGen.USLMissionDetails z="104918">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>Zorrah</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>Bhilai</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>9221</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>13.0</duration>
											<distance>2.9436371</distance>
											<expiration>2.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104919">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>Apocrita</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>apocrita_association</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>11387</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>30.0</duration>
											<distance>9.507892</distance>
											<expiration>8.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104920">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>ii_aleria</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>hegemony</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>10560</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>22.0</duration>
											<distance>7.0007143</distance>
											<expiration>11.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104921">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>diableavionics_prison</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>diableavionics</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>13024</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>38.0</duration>
											<distance>14.468241</distance>
											<expiration>6.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104922">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>mazalot</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>persean</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>10446</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>22.0</duration>
											<distance>6.6567636</distance>
											<expiration>10.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
									</list>
								</e>
								<e>
									<st>$ST_ExpeditedParcelMissions</st>
									<list z="104923">
										<Util.MissionGen.USLMissionDetails z="104924">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>diableavionics_shadow</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>diableavionics</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>11748</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>15.0</duration>
											<distance>5.1264024</distance>
											<expiration>2.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104925">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>clusterOrbital_market</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>xhanempire</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>18404</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>48.0</duration>
											<distance>22.193016</distance>
											<expiration>4.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104926">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>orbitalOne_market</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>xhanempire</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>18404</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>50.0</duration>
											<distance>22.193016</distance>
											<expiration>8.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104927">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>ii_aleria</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>hegemony</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>12480</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>22.0</duration>
											<distance>7.0007143</distance>
											<expiration>5.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104928">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>aisoyim_market</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>persean</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>13769</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>28.0</duration>
											<distance>10.309461</distance>
											<expiration>9.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
									</list>
								</e>
								<e>
									<st>$ST_PriorityParcelMissions</st>
									<list z="104929">
										<Util.MissionGen.USLMissionDetails z="104930">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>drakon_market</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>sindrian_diktat</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>13644</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>7.0</duration>
											<distance>3.42965</distance>
											<expiration>5.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104931">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>orbitalThree_market</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>xhanempire</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>22651</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>48.0</duration>
											<distance>22.193016</distance>
											<expiration>8.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104932">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>ii_aleria</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>hegemony</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>15360</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>16.0</duration>
											<distance>7.0007143</distance>
											<expiration>3.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104933">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>vayra_refugestationmarket</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>kadur_remnant</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>14969</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>16.0</duration>
											<distance>6.189709</distance>
											<expiration>8.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
										<Util.MissionGen.USLMissionDetails z="104934">
											<missionType>PARCEL</missionType>
											<sourceMarketID>asharu</sourceMarketID>
											<destinationMarketID>jnana</destinationMarketID>
											<sourceFactionID>independent</sourceFactionID>
											<destinationFactionID>shadow_industry</destinationFactionID>
											<commodityID>st_parcels</commodityID>
											<reward>14406</reward>
											<escrow>0</escrow>
											<quantity>500</quantity>
											<unitPrice>0</unitPrice>
											<duration>12.0</duration>
											<distance>5.0159745</distance>
											<expiration>5.0</expiration>
											<createTime>-55614955103000</createTime>
										</Util.MissionGen.USLMissionDetails>
									</list>
								</e>
								<e>
									<st>$nex_invasionPointsLastTick</st>
									<fp>10.175</fp>
								</e>
							</d>
							<e z="104935">
								<MExp z="104936" k="$nex_fleetPoolPointsLastTick" t="2.53307"/>
								<MExp z="104937" k="$nex_groundPoolPointsLastTick" t="2.53307"/>
								<MExp z="104938" k="$nex_invasionPointsLastTick" t="2.4476705"/>
							</e>
						</memory>
						<stats z="104939">
							<dynamic z="104940">
								<stats z="104941"/>
								<mods z="104942">
									<e>
										<st>officer_prob</st>
										<SBonus z="104943" fB="0.3" m="1.0" pM="0.0" nR="true">
											<fBs z="104944" s="ind_population_0" v="0.1"/>
											<fBs z="104945" s="ind_population_1" v="0.1"/>
											<fBs z="104946" s="ind_spaceport_0" v="0.1"/>
										</SBonus>
									</e>
									<e>
										<st>ground_defenses_mod</st>
										<SBonus z="104947" fB="200.0" m="2.7749999" pM="0.0" nR="true">
											<fBs z="104948" s="ind_population" d="Base value for a size 5 colony" v="200.0"/>
											<mBs z="104949" s="ind_population" d="Stability" v="0.92499995"/>
											<mBs z="104950" s="ind_grounddefenses" d="Ground defenses" v="2.0"/>
											<mBs z="104951" s="ind_orbitalstation_mid" d="Orbital station - midline" v="1.5"/>
										</SBonus>
									</e>
									<e>
										<st>admin_prob</st>
										<SBonus z="104952" fB="0.15" m="1.0" pM="0.0" nR="true">
											<fBs z="104953" s="ind_population_0" v="0.05"/>
											<fBs z="104954" s="ind_population_1" v="0.1"/>
										</SBonus>
									</e>
									<e>
										<st>fleet_quality_mod</st>
										<SBonus z="104955" fB="0.325" m="1.0" pM="0.0" nR="false">
											<fBs z="104956" s="ind_population_0" d="Stability" v="0.2"/>
											<fBs z="104957" s="ind_population_1" d=" fleet doctrine" v="0.125"/>
										</SBonus>
									</e>
									<e>
										<st>officer_is_merc_prob</st>
										<SBonus z="104958" fB="0.25" m="1.0" pM="0.0" nR="true">
											<fBs z="104959" s="ind_population_0" v="0.25"/>
										</SBonus>
									</e>
									<e>
										<st>max_industries</st>
										<SBonus z="104960" fB="3.0" m="1.0" pM="0.0" nR="false">
											<fBs z="104961" s="ind_population" v="3.0"/>
										</SBonus>
									</e>
									<e>
										<st>additional_officer_prob_mult</st>
										<SBonus z="104962" fB="0.1" m="1.0" pM="0.0" nR="true">
											<fBs z="104963" s="ind_population_0" v="0.1"/>
										</SBonus>
									</e>
									<e>
										<st>combat_fleet_size_mult</st>
										<SBonus z="104964" fB="1.0" m="1.5" pM="0.0" nR="true">
											<fBs z="104965" s="ind_population_0" d="Colony size" v="1.0"/>
											<mBs z="104966" s="ind_population_1" d=" fleet doctrine" v="1.25"/>
											<mBs z="104967" s="ind_population_2" d="Ship hulls &amp; weapons demand met" v="1.0"/>
											<mBs z="104968" s="ind_population_3" d="Stability" v="1.2"/>
										</SBonus>
									</e>
								</mods>
							</dynamic>
						</stats>
						<isPlanetConditionMarketOnly>false</isPlanetConditionMarketOnly>
						<accessibilityMod z="104969" fB="0.91999996" m="1.0" pM="0.0" nR="false">
							<fBs z="104970" s="core_base" d="Proximity to other colonies" v="0.43"/>
							<fBs z="104971" s="core_hostile" d="Hostilities with other factions" v="-0.11"/>
							<fBs z="104972" s="ind_population_1" d="Colony size" v="0.1"/>
							<fBs z="104973" s="ind_spaceport_0" d="Spaceport" v="0.5"/>
						</accessibilityMod>
						<incomeMult z="104974" b="1.0" m="1.0">
							<mMs z="104975" s="ind_population_3" d="Stability" v="1.0"/>
						</incomeMult>
						<upkeepMult z="104976" b="1.0" m="0.45">
							<mMs z="104977" s="upkeep_hazard_mod" d="Hazard rating" v="0.9"/>
							<mMs z="104978" s="ind_population_3ifi" d="All demand supplied in-faction" v="0.5"/>
						</upkeepMult>
						<useStockpilesForShortages>false</useStockpilesForShortages>
						<industries z="104979">
							<PopulationAndInfrastructure z="104980" id="population" bP="0.0" b="false" wD="false">
								<m cl="Market" ref="104218"/>
								<buildTime>1.0</buildTime>
								<dR z="104981" b="0.0" m="0.0"/>
								<sB z="104982" b="0.0" m="0.0"/>
							</PopulationAndInfrastructure>
							<Spaceport z="104983" id="spaceport" bP="0.0" b="false" wD="false">
								<m cl="Market" ref="104218"/>
								<buildTime>1.0</buildTime>
								<dR z="104984" b="0.0" m="0.0"/>
								<sB z="104985" b="0.0" m="0.0"/>
							</Spaceport>
							<data.campaign.econ.industries.MS__supersolar z="104986" id="ms_supersolar" bP="0.0" b="false" wD="false">
								<m cl="Market" ref="104218"/>
								<buildTime>1.0</buildTime>
								<dR z="104987" b="0.0" m="0.0"/>
								<sB z="104988" b="0.0" m="0.0"/>
							</data.campaign.econ.industries.MS__supersolar>
							<data.kaysaar.aotd.vok.campaign.econ.industry.SubsidizedFarming z="104989" id="subfarming" bP="0.0" b="false" wD="false">
								<m cl="Market" ref="104218"/>
								<buildTime>1.0</buildTime>
								<dR z="104990" b="0.0" m="0.0"/>
								<sB z="104991" b="0.0" m="0.0"/>
							</data.kaysaar.aotd.vok.campaign.econ.industry.SubsidizedFarming>
							<com.fs.starfarer.api.alcoholism.industry.Brewery z="104992" id="alcohol_brewery" bP="0.0" b="false" wD="false">
								<m cl="Market" ref="104218"/>
								<buildTime>1.0</buildTime>
								<dR z="104993" b="0.0" m="0.0"/>
								<sB z="104994" b="0.0" m="0.0"/>
								<special z="104995" i="alcoholism_tea_item"/>
							</com.fs.starfarer.api.alcoholism.industry.Brewery>
							<GroundDefenses z="104996" id="grounddefenses" bP="0.0" b="false" wD="false">
								<m cl="Market" ref="104218"/>
								<buildTime>1.0</buildTime>
								<dR z="104997" b="0.0" m="0.0"/>
								<sB z="104998" b="0.0" m="0.0"/>
							</GroundDefenses>
							<OrbitalStation z="104999" id="orbitalstation_mid" bP="0.0" b="false" wD="false" uES="false">
								<m cl="Market" ref="104218"/>
								<buildTime>1.0</buildTime>
								<dR z="105000" b="0.0" m="0.0"/>
								<sB z="105001" b="0.0" m="0.0"/>
								<sF cl="Flt" z="105002" sS="450.0" sP="450.0" mO="false" f="255.12036" n="Asharu Station" aM="true" nFIN="true" sM="true" dF="90.0">
									<loc z="105003">-248.2623|2504.132</loc>
									<vel z="105004">0.0|0.0</vel>
									<j0>{"f6":0,"f0":"Null","f2":[255,255,255,255],"f4":"65f736","f5":true}</j0>
									<o ref="163"/>
									<orbit cl="COrbt" z="105005" r="0.0" op="100.0" ca="0.0">
										<e cl="Flt" ref="105002"/>
										<f cl="CCEnt" z="105006" fL="STATIONS">
											<loc z="105007">-248.2623|2504.132</loc>
											<vel z="105008">0.0|0.0</vel>
											<j0>{"f6":307.73035,"f0":"Asharu Station","f2":[255,255,255,255],"f3":"orbital_station_default","f4":"65f738"}</j0>
											<ow ref="163"/>
											<orbit cl="CircularOrbitWithSpin" z="105009" r="300.0" op="30.0" ca="295.78375" cF="307.73035" sV="5.0">
												<e cl="CCEnt" ref="105006"/>
												<f cl="Plnt" ref="104212"/>
											</orbit>
											<cL cl="Sstm" ref="104188"/>
											<ls cl="Plnt" ref="104185"/>
											<me z="105010">
												<d z="105011">
													<e>
														<st>$stationFleet</st>
														<st>enRef_65f736</st>
													</e>
												</d>
											</me>
											<market cl="Market" ref="104218"/>
											<sc z="105012"/>
											<tags z="105013">
												<st>station</st>
											</tags>
											<j1>{"f0":64,"f1":64,"f2":55,"f3":-1,"f4":-1,"f5":"station_built_from_industry"}</j1>
											<la z="105014" enum-type="CaEnLa">STATIONS</la>
											<fleetForVisual ref="105002"/>
										</f>
									</orbit>
									<cL cl="Sstm" ref="104188"/>
									<ls cl="Plnt" ref="104185"/>
									<me z="105015">
										<d z="105016">
											<e>
												<st>$fleetType</st>
												<st>patrolSmall</st>
											</e>
											<e>
												<st>$salvageSeed</st>
												<Lp>-9211438497457133279</Lp>
											</e>
											<e>
												<st>$spawnFPMult</st>
												<fp>0.0</fp>
											</e>
											<e>
												<st>$stationMarket</st>
												<st>mRef_asharu</st>
											</e>
										</d>
									</me>
									<sc z="105017">
										<TrA z="105018" id="transponder" dF="0" tO="true" cL="0.0" iAC="true" l="1.0">
											<e cl="Flt" ref="105002"/>
										</TrA>
									</sc>
									<abilities cl="l-h-m" z="105019">
										<e>
											<st>transponder</st>
											<TrA ref="105018"/>
										</e>
									</abilities>
									<alwaysUseSensorFaderBrightness>false</alwaysUseSensorFaderBrightness>
									<fD z="105020" nP="ISS" nSf="independent" nS="false" oSML="false">
										<m z="105021">
											<FMmbr z="105022" o="0" sid="station1_midline_Standard" sN="Asharu Station" t="SHIP" iF="false" id="690b45" sUN="false" civ="false" cCiv="false">
												<rT z="105023" cr="0.8547" crPTM="0.0" sR="false" mo="false" lCR="true">
													<m ref="105022"/>
												</rT>
												<fD ref="105020"/>
											</FMmbr>
										</m>
										<cargo z="105024" uS="true" mC="0.0" sU="71.0" mF="0.0" mP="0.0" fT="false">
											<s z="105025">
												<CIStack z="105026" rS="false" s="71.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
													<d cl="st">IndEvo_parts</d>
													<c ref="105024"/>
												</CIStack>
											</s>
											<c z="105027">
												<value>0.0</value>
											</c>
											<cF ref="105020"/>
										</cargo>
										<c z="105028" id="p_65f737" pid="steady" spr="graphics/portraits/portrait14.png" rnk="spaceCommander" pst="fleetCommander" wTCRC="0" cW="1.0" fid="independent" a="true" im="MEDIUM">
											<n z="105029" f="Wednesday" l="Eulalia" g="FEMALE"/>
											<m z="105030">
												<d z="105031">
													<e>
														<st>$voice</st>
														<st>soldier</st>
													</e>
												</d>
											</m>
											<stats z="105032" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0">
												<fleet cl="Flt" ref="105002"/>
											</stats>
										</c>
										<f ref="105002"/>
									</fD>
									<mM z="105033" a="1.0" s="2.0" sC="true">
										<v z="105034">0.0|0.0</v>
										<l z="105035">-1861.72|2222.2024</l>
										<aV z="105036">0.0|0.0</aV>
										<d cl="Flt" ref="105002"/>
										<hardSpeedLimit>-1.0</hardSpeedLimit>
									</mM>
									<fM z="105037" a="150.0" m="100.0" r="0.0" f="255.12036"/>
									<s z="105038">
										<dynamic z="105039">
											<stats z="105040"/>
											<mods z="105041"/>
										</dynamic>
										<fMBM z="105042" fB="0.0" m="1.0" pM="0.0" nR="false"/>
										<dRM z="105043" fB="11000.0" m="1.0" pM="0.0" nR="false">
											<fBs z="105044" s="transponder_ability_mod" d="Transponder on" v="1000.0"/>
											<fBs z="105045" s="gen" v="10000.0"/>
											<mBs z="105046" s="core_PhaseField" d="Phase ships in fleet" v="1.0"/>
										</dRM>
									</s>
									<lgst z="105047">
										<f ref="105002"/>
									</lgst>
									<nCP z="105048" b="0.0" i="0.1" o="0.1" s="IDLE" d="true" u="true"/>
									<dL z="105049">
										<OrbitalStation ref="104999"/>
									</dL>
									<inflater cl="DFInfl" z="105050">
										<p z="105051" s="-2977702094769953935" p="true" q="0.725" m="PRIORITY_THEN_ALL">
											<allWeapons>true</allWeapons>
											<factionId>independent</factionId>
										</p>
									</inflater>
									<hidden>true</hidden>
								</sF>
								<sE cl="CCEnt" ref="105006"/>
							</OrbitalStation>
							<Farming z="105052" id="farming" bP="0.0" b="false" wD="false">
								<m cl="Market" ref="104218"/>
								<buildTime>1.0</buildTime>
								<dR z="105053" b="0.0" m="0.0"/>
								<sB z="105054" b="0.0" m="0.0"/>
							</Farming>
						</industries>
						<playerOwned>false</playerOwned>
						<hasSpaceport>true</hasSpaceport>
						<hasWaystation>false</hasWaystation>
						<population z="105055">
							<comp z="105056">
								<e>
									<st>independent</st>
									<fp>976.2123</fp>
								</e>
								<e>
									<st>pirates</st>
									<fp>49.061523</fp>
								</e>
								<e>
									<st>poor</st>
									<fp>49.061523</fp>
								</e>
								<e>
									<st>luddic_church</st>
									<fp>220.01192</fp>
								</e>
							</comp>
							<weight z="105057" b="0.0" m="1294.3473">
								<fMs z="105058" s="core_set" v="1294.3473"/>
							</weight>
						</population>
						<incoming z="105059">
							<comp z="105060">
								<e>
									<st>pirates</st>
									<fp>1.038168</fp>
								</e>
								<e>
									<st>poor</st>
									<fp>1.038168</fp>
								</e>
								<e>
									<st>independent</st>
									<fp>10.38168</fp>
								</e>
								<e>
									<st>luddic_church</st>
									<fp>4.5419846</fp>
								</e>
							</comp>
							<weight z="105061" b="0.0" m="8.5">
								<fMs z="105062" s="inc_access" d="Accessibility" v="9.0"/>
								<fMs z="105063" s="inc_insys" d="Larger non-hostile colony in same system" v="2.0"/>
								<fMs z="105064" s="habitable_3dd2" d="Habitable" v="4.0"/>
								<fMs z="105065" s="ind_spaceport" d="Spaceport" v="2.0"/>
								<mMs z="105066" s="nex_colonyManager_npcGrowth" d="NPC market" v="0.5"/>
							</weight>
						</incoming>
						<immigrationModifiers z="105067">
							<ColonyMngr ref="2145"/>
							<ResourceDepositsMC z="105068">
								<m cl="Market" ref="104218"/>
								<c cl="MCon" z="105069" i="farmland_poor" u="3dd0" s="true">
									<m cl="Market" ref="104218"/>
								</c>
							</ResourceDepositsMC>
						</immigrationModifiers>
						<allowImport>true</allowImport>
						<allowExport>true</allowExport>
						<incentiveCredits>0.0</incentiveCredits>
						<constructionQueue z="105070">
							<items z="105071"/>
						</constructionQueue>
						<commDirectory z="105072">
							<entries z="105073">
								<CommDirectoryEntry z="105074">
									<id>61c8</id>
									<type>PERSON</type>
									<entryData cl="Person" z="105075" id="p_61c7" pid="steady" spr="graphics/portraits/portrait25.png" rnk="spaceCommander" pst="portmaster" wTCRC="0" cW="1.0" fid="independent" a="true" im="LOW">
										<n z="105076" f="Third" l="Adamos" g="MALE"/>
										<m z="105077">
											<d z="105078">
												<e>
													<st>$voice</st>
													<st>spacer</st>
												</e>
											</d>
										</m>
										<stats z="105079" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0"/>
										<market cl="Market" ref="104218"/>
										<tags z="105080">
											<st>trade</st>
										</tags>
										<voiceOverride>true</voiceOverride>
									</entryData>
									<hidden>false</hidden>
								</CommDirectoryEntry>
								<CommDirectoryEntry z="105081">
									<id>61ca</id>
									<type>PERSON</type>
									<entryData cl="Person" z="105082" id="p_61c9" pid="steady" spr="graphics/portraits/marvelousPersonasPortraits/mp_independent_04.png" rnk="spaceCommander" pst="supplyOfficer" wTCRC="0" cW="1.0" fid="independent" a="true" im="MEDIUM">
										<n z="105083" f="Zarine" l="Orinoco" g="FEMALE"/>
										<m z="105084">
											<d z="105085">
												<e>
													<st>$voice</st>
													<st>soldier</st>
												</e>
											</d>
										</m>
										<stats z="105086" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0"/>
										<market cl="Market" ref="104218"/>
										<tags z="105087">
											<st>trade</st>
											<st>military</st>
										</tags>
										<voiceOverride>true</voiceOverride>
									</entryData>
									<hidden>false</hidden>
								</CommDirectoryEntry>
								<CommDirectoryEntry z="105088">
									<id>61cc</id>
									<type>PERSON</type>
									<entryData cl="Person" z="105089" id="p_61cb" pid="steady" spr="graphics/portraits/portrait48.png" rnk="citizen" pst="administrator" wTCRC="0" cW="1.0" fid="independent" a="true" im="MEDIUM">
										<n z="105090" f="Ao" l="Kyugu" g="MALE"/>
										<m z="105091">
											<d z="105092">
												<e>
													<st>$voice</st>
													<st>business</st>
												</e>
											</d>
										</m>
										<stats z="105093" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0"/>
										<market cl="Market" ref="104218"/>
										<tags z="105094">
											<st>trade</st>
										</tags>
										<voiceOverride>true</voiceOverride>
									</entryData>
									<hidden>false</hidden>
								</CommDirectoryEntry>
								<CommDirectoryEntry z="105095">
									<id>6454</id>
									<type>PERSON</type>
									<entryData cl="Person" z="105096" id="robed_man" pid="steady" spr="graphics/portraits/characters/robed_man.png" rnk="citizen" pst="hermit" wTCRC="0" cW="1.0" fid="independent" a="false" im="MEDIUM">
										<n z="105097" f="Old" l="Man" g="MALE"/>
										<m z="105098">
											<d z="105099">
												<e>
													<st>$voice</st>
													<st>soldier</st>
												</e>
												<e>
													<st>$beginMission_seedExtra</st>
													<st>1940403214364445301</st>
												</e>
											</d>
										</m>
										<stats z="105100" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0">
											<s>{"best_of_the_best":1,"officer_training":1}</s>
											<dynamic z="105101">
												<stats z="105102"/>
												<mods z="105103">
													<e>
														<st>officer_max_level_mod</st>
														<SBonus z="105104" fB="0.0" m="1.0" pM="0.0" nR="true">
															<fBs z="105105" s="officer_training_stats_1" v="1.0"/>
														</SBonus>
													</e>
													<e>
														<st>command_point_rate_flat</st>
														<SBonus z="105106" fB="0.0" m="1.0" pM="0.0" nR="true">
															<fBs z="105107" s="best_of_the_best_stats_3" v="100.0"/>
														</SBonus>
													</e>
													<e>
														<st>officer_max_elite_skills_mod</st>
														<SBonus z="105108" fB="0.0" m="1.0" pM="0.0" nR="true">
															<fBs z="105109" s="officer_training_stats_2" v="1.0"/>
														</SBonus>
													</e>
													<e>
														<st>deployment_points_min_fraction_of_battle_size_bonus_mod</st>
														<SBonus z="105110" fB="0.0" m="1.0" pM="0.0" nR="true">
															<fBs z="105111" s="best_of_the_best_stats_2" v="0.1"/>
														</SBonus>
													</e>
												</mods>
											</dynamic>
										</stats>
										<tags z="105112">
											<st>military</st>
										</tags>
										<voiceOverride>true</voiceOverride>
									</entryData>
									<hidden>true</hidden>
								</CommDirectoryEntry>
							</entries>
						</commDirectory>
						<people z="105113">
							<Person z="105114" id="p_45c77" pid="steady" spr="graphics/portraits/marvelousPersonasPortraits/mp_pirate_01.png" rnk="citizen" pst="agent" wTCRC="0" cW="1.0" fid="pirates" a="true" im="HIGH">
								<n z="105115" f="Kora" l="Common" g="FEMALE"/>
								<m z="105116">
									<d z="105117">
										<e>
											<st>$voice</st>
											<st>villain</st>
										</e>
										<e>
											<st>$missionId</st>
											<st>ssat</st>
										</e>
									</d>
								</m>
								<stats z="105118" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0"/>
								<rTP z="105119" r="-0.02">
									<target z="105120">
										<type>PLAYER</type>
									</target>
								</rTP>
								<market cl="Market" ref="104218"/>
								<tags z="105121">
									<st>underworld</st>
								</tags>
								<voiceOverride>true</voiceOverride>
							</Person>
							<Person ref="105075"/>
							<Person ref="105082"/>
							<Person ref="105089"/>
						</people>
						<admin ref="105089"/>
						<prevStability>9.0</prevStability>
						<daysInExistence>2494.7976</daysInExistence>
						<connectedEntities z="105122">
							<Plnt ref="104212"/>
							<CCEnt ref="105006"/>
						</connectedEntities>
						<conditions z="105123">
							<MCon z="105124" i="hot" u="3dce" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105125" i="ore_moderate" u="3dcf" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon ref="105069"/>
							<MCon z="105126" i="ruins_scattered" u="3dd1" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105127" i="habitable" u="3dd2" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105128" i="AodReci" u="6f02" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105129" i="IndEvo_ressCond" u="6f67" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105130" i="alcohol_resourceCondition" u="7158" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105131" i="IcDemmand" u="8858" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105132" i="watterSupplyMining" u="8859" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105133" i="AoDFoodDemand" u="89b6" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105134" i="industrial_might" u="8ab8" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105135" i="aotd_tech_hazard" u="18762" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105136" i="nex_faction_condition" u="f2aa78d8-5ab6-4145-8f79-08f17fa75770" s="true">
								<p cl="exerelin.campaign.econ.FactionConditionPlugin" z="105137">
									<m cl="Market" ref="104218"/>
									<c cl="MCon" ref="105136"/>
									<factionId>independent</factionId>
								</p>
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105138" i="comm_relay" u="65e114" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
							<MCon z="105139" i="population_5" u="65e95a" s="true">
								<m cl="Market" ref="104218"/>
							</MCon>
						</conditions>
						<surveyLevel>FULL</surveyLevel>
						<forceNoConvertOnSave>false</forceNoConvertOnSave>
						<isFreePort>false</isFreePort>
					</market>
					<sc z="105140"/>
					<cV z="105141" sn="graphics/illustrated_entities/images/172.png" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
					<tags z="105142">
						<st>$illustrated_entity_image</st>
						<st>planet</st>
					</tags>
					<angle>236.90607</angle>
					<cloudAngle>186.75366</cloudAngle>
					<radius>150.0</radius>
					<type>desert</type>
					<diff z="105143">
						<j>{"glowTexture":"graphics/planets/asharu_sparse_glow.png","useReverseLightForGlow":true}</j>
					</diff>
					<layers z="105144" enum-type="CaEnLa">PLANETS,ABOVE</layers>
				</Plnt>
				<CCEnt z="105145" fL="STATIONS">
					<loc z="105146">-2592.002|1059.0214</loc>
					<vel z="105147">0.0|0.0</vel>
					<j0>{"f6":157.77643,"f0":"Makeshift Sensor Array","f2":[255,255,255,255],"f3":"sensor_array_makeshift","f4":"29"}</j0>
					<ow ref="873"/>
					<orbit cl="COrbtPD" z="105148" r="2800.0" op="100.0" ca="157.77643">
						<e cl="CCEnt" ref="105145"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="105149">
						<d z="105150"/>
					</me>
					<sc z="105151"/>
					<cV z="105152" sn="graphics/illustrations/sensor_array_makeshift.jpg" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
					<tags z="105153">
						<st>sensor_array</st>
						<st>neutrino_high</st>
						<st>makeshift</st>
						<st>objective</st>
					</tags>
					<j1>{"f0":86,"f1":86,"f2":75,"f3":-1,"f4":-1,"f5":"sensor_array_makeshift"}</j1>
					<la z="105154" enum-type="CaEnLa">STATIONS</la>
					<p cl="NexSensArr" z="105155">
						<e cl="CCEnt" ref="105145"/>
					</p>
				</CCEnt>
				<CCEnt z="105156" fL="STATIONS">
					<loc z="105157">-263.41815|3051.2075</loc>
					<vel z="105158">0.0|0.0</vel>
					<j0>{"f6":67.390015,"f0":"Abandoned Terraforming Platform","f2":[255,255,255,255],"f3":"asharu_platform","f4":"corvus_abandoned_station"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbtPD" z="105159" r="300.0" op="30.0" ca="67.390015">
						<e cl="CCEnt" ref="105156"/>
						<f cl="Plnt" ref="104212"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="105160">
						<d z="105161">
							<e>
								<st>$abandonedStation</st>
								<bp>true</bp>
							</e>
							<e>
								<st>$inspectedShips</st>
								<st>true</st>
							</e>
						</d>
					</me>
					<market cl="Market" z="105162">
						<id>corvus_abandoned_station_market</id>
						<name>Abandoned Terraforming Platform</name>
						<commodities z="105163"/>
						<demandData z="105164">
							<market ref="105162"/>
						</demandData>
						<size>0</size>
						<location z="105165">400.0|-9400.0</location>
						<economy ref="551"/>
						<demandPriceMod z="105166" fB="0.0" m="1.0" pM="0.0" nR="false"/>
						<supplyPriceMod z="105167" fB="0.0" m="1.0" pM="0.0" nR="false"/>
						<tariff z="105168" b="0.0" m="0.0"/>
						<factionId>neutral</factionId>
						<power z="105169" b="0.0" m="0.0"/>
						<hazard z="105170" b="0.0" m="1.0">
							<fMs z="105171" s="haz_base" d="Base value" v="1.0"/>
						</hazard>
						<primaryEntity cl="CCEnt" ref="105156"/>
						<submarkets z="105172">
							<Submarket z="105173" s="storage">
								<m ref="105162"/>
								<p cl="NexStoreSubmkt" z="105174" mSWUI="30.0" msSWU="31.0" sLCU="31.0" paid="true">
									<m cl="Market" ref="105162"/>
									<s cl="Submarket" ref="105173"/>
									<c cl="CargoData" z="105175" uS="true" mC="1000.0" sU="50.0" mF="500.0" mP="750.0" fT="false">
										<s z="105176"/>
										<c z="105177">
											<value>0.0</value>
										</c>
										<mS z="105178" nP="ISS" nSf="player" nS="true" oSML="false">
											<m z="105179">
												<FMmbr z="105180" o="1" sid="diableavionics_maelstrom_beamer" sN="DSF Wolf" t="SHIP" iF="true" id="29c31b" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105181" hId="diableavionics_maelstrom_default_D" v="0" c="0" hVId="diableavionics_maelstrom_beamer" vDN="Beamer" s="REFIT" mAAW="false" gV="true">
														<wpn z="105182">
															<e>
																<st>WS0012</st>
																<st>diableavionics_ibis</st>
															</e>
															<e>
																<st>WS0002</st>
																<st>diableavionics_microarray</st>
															</e>
															<e>
																<st>WS0024</st>
																<st>diableavionics_artassault</st>
															</e>
															<e>
																<st>WS0016</st>
																<st>diableavionics_micromissile</st>
															</e>
															<e>
																<st>WS0015</st>
																<st>diableavionics_micromissile</st>
															</e>
														</wpn>
														<sM z="105183"/>
														<wng z="105184">
															<st/>
															<st>diableavionics_strife_wing</st>
														</wng>
														<wG z="105185">
															<WGSpec z="105186" t="LINKED" a="false">
																<s z="105187">
																	<st>WS0002</st>
																</s>
															</WGSpec>
															<WGSpec z="105188" t="ALTERNATING" a="false">
																<s z="105189">
																	<st>WS0016</st>
																	<st>WS0015</st>
																</s>
															</WGSpec>
															<WGSpec z="105190" t="LINKED" a="true">
																<s z="105191">
																	<st>WS0024</st>
																</s>
															</WGSpec>
															<WGSpec z="105192" t="LINKED" a="true">
																<s z="105193">
																	<st>WS0012</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105194">
															<st>diableavionics_mountBI</st>
															<st>targetingunit</st>
															<st>stabilizedshieldemitter</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_famous</st>
															<st>comp_armor</st>
															<st>faulty_auto</st>
															<st>fragile_subsystems</st>
														</hM>
														<pM z="105195">
															<st>targetingunit</st>
															<st>stabilizedshieldemitter</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_famous</st>
															<st>comp_armor</st>
															<st>faulty_auto</st>
															<st>fragile_subsystems</st>
														</pM>
														<sMods z="105196">
															<st>targetingunit</st>
															<st>stabilizedshieldemitter</st>
														</sMods>
														<sModdedBuiltIns z="105197"/>
														<suM z="105198"/>
														<tags z="105199">
															<st>retain_smods_on_recovery</st>
															<st>ship_recoverable</st>
														</tags>
													</savedVariant>
													<status z="105200">
														<status z="105201">
															<ShipStatus z="105202" hF="0.37312484" gW="11" gH="22">
																<aCF z="105203">
																	<f-a z="105204">1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105205">1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105206">1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105207">1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105208">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105209">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105210">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105211">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.54871285</f-a>
																	<f-a z="105212">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105213">1.0|1.0|1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105214">1.0|1.0|1.0|1.0|1.0|1.0|1.0|0.0|0.0|0.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																</aCF>
																<s ref="105200"/>
																<hullDamageTaken>0.0</hullDamageTaken>
																<armorDamageTaken>0.0</armorDamageTaken>
															</ShipStatus>
														</status>
														<member ref="105180"/>
													</status>
													<rT z="105215" cr="0.0011134217" crPTM="0.0" sR="false" mo="false" lCR="false">
														<m ref="105180"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105216" o="0" sid="34998f_1" sN="TTDS Mem-Zero" t="SHIP" iF="false" id="349999" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105217" hId="brilliant_default_D" v="35" c="5" hVId="34998f_1" vDN="Standard" s="REFIT" mAAW="false" gV="false">
														<wpn z="105218">
															<e>
																<st>WS 006</st>
																<st>shredder</st>
															</e>
															<e>
																<st>WS 002</st>
																<st>flicker_pdl</st>
															</e>
														</wpn>
														<sM z="105219"/>
														<wng z="105220"/>
														<wG z="105221">
															<WGSpec z="105222" t="LINKED" a="false">
																<s z="105223">
																	<st>WS 006</st>
																</s>
															</WGSpec>
															<WGSpec z="105224" t="LINKED" a="true">
																<s z="105225">
																	<st>WS 002</st>
																	<st>WS 003</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105226">
															<st>automated</st>
															<st>armoredweapons</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
															<st>erratic_injector</st>
														</hM>
														<pM z="105227">
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
															<st>erratic_injector</st>
														</pM>
														<sMods z="105228"/>
														<sModdedBuiltIns z="105229"/>
														<suM z="105230"/>
													</savedVariant>
													<rT z="105231" cr="0.0" crPTM="0.0" sR="false" mo="false" lCR="false">
														<m ref="105216"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105232" o="0" sid="34998f_2" sN="TTDS Impossible World" t="SHIP" iF="false" id="34999b" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105233" hId="brilliant_default_D" v="35" c="12" hVId="34998f_2" vDN="Standard" s="REFIT" mAAW="false" gV="false">
														<wpn z="105234">
															<e>
																<st>WS 006</st>
																<st>hveldriver</st>
															</e>
															<e>
																<st>WS 005</st>
																<st>hveldriver</st>
															</e>
															<e>
																<st>WS 002</st>
																<st>flicker_pdl</st>
															</e>
														</wpn>
														<sM z="105235"/>
														<wng z="105236"/>
														<wG z="105237">
															<WGSpec z="105238" t="LINKED" a="false">
																<s z="105239">
																	<st>WS 006</st>
																	<st>WS 005</st>
																</s>
															</WGSpec>
															<WGSpec z="105240" t="LINKED" a="true">
																<s z="105241">
																	<st>WS 002</st>
																	<st>WS 003</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105242">
															<st>automated</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_wellknown</st>
															<st>comp_hull</st>
															<st>degraded_shields</st>
														</hM>
														<pM z="105243">
															<st>progsmod_xptracker</st>
															<st>sun_sl_wellknown</st>
															<st>comp_hull</st>
															<st>degraded_shields</st>
														</pM>
														<sMods z="105244"/>
														<sModdedBuiltIns z="105245"/>
														<suM z="105246"/>
													</savedVariant>
													<rT z="105247" cr="0.0" crPTM="0.0" sR="false" mo="false" lCR="false">
														<m ref="105232"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105248" o="0" sid="370bbc_2" sN="DSS Ayin-Baron" t="SHIP" iF="false" id="370bca" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105249" hId="rampart_default_D" v="9" c="0" hVId="370bbc_2" vDN="Standard" s="REFIT" mAAW="false" gV="false">
														<wpn z="105250">
															<e>
																<st>WS 004</st>
																<st>arbalest</st>
															</e>
														</wpn>
														<sM z="105251"/>
														<wng z="105252"/>
														<wG z="105253">
															<WGSpec z="105254" t="LINKED" a="true">
																<s z="105255">
																	<st>WS 004</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105256">
															<st>automated</st>
															<st>rugged</st>
															<st>armoredweapons</st>
															<st>insulatedengine</st>
															<st>dedicated_targeting_core</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>faulty_grid</st>
															<st>fragile_subsystems</st>
														</hM>
														<pM z="105257">
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>faulty_grid</st>
															<st>fragile_subsystems</st>
														</pM>
														<sMods z="105258"/>
														<sModdedBuiltIns z="105259"/>
														<suM z="105260"/>
													</savedVariant>
													<rT z="105261" cr="0.0" crPTM="0.0" sR="false" mo="false" lCR="false">
														<m ref="105248"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105262" o="0" sid="370bbc_1" sN="DSS Ayin-Prince" t="SHIP" iF="false" id="370bc8" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105263" hId="rampart_default_D" v="0" c="0" hVId="370bbc_1" vDN="Standard" s="REFIT" mAAW="false" gV="false">
														<wpn z="105264">
															<e>
																<st>WS 003</st>
																<st>wpnxt_heavyrailgun</st>
															</e>
															<e>
																<st>WS 000</st>
																<st>devastator</st>
															</e>
														</wpn>
														<sM z="105265"/>
														<wng z="105266"/>
														<wG z="105267">
															<WGSpec z="105268" t="LINKED" a="true">
																<s z="105269">
																	<st>WS 003</st>
																</s>
															</WGSpec>
															<WGSpec z="105270" t="LINKED" a="true">
																<s z="105271">
																	<st>WS 000</st>
																	<st>WS 001</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105272">
															<st>automated</st>
															<st>rugged</st>
															<st>armoredweapons</st>
															<st>insulatedengine</st>
															<st>dedicated_targeting_core</st>
															<st>fluxbreakers</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_wellknown</st>
															<st>comp_hull</st>
															<st>glitched_sensors</st>
														</hM>
														<pM z="105273">
															<st>progsmod_xptracker</st>
															<st>sun_sl_wellknown</st>
															<st>comp_hull</st>
															<st>glitched_sensors</st>
														</pM>
														<sMods z="105274"/>
														<sModdedBuiltIns z="105275"/>
														<suM z="105276"/>
													</savedVariant>
													<rT z="105277" cr="0.0" crPTM="0.0" sR="false" mo="false" lCR="false">
														<m ref="105262"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105278" o="0" sid="3f1230_5" sN="Daunty Jack" t="SHIP" iF="false" id="3f1238" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105279" hId="BSC_Hammerhead_MK2_default_D" v="13" c="16" hVId="3f1230_5" vDN="Raider" s="REFIT" mAAW="false" gV="false">
														<wpn z="105280">
															<e>
																<st>WS0006</st>
																<st>filgap_scattergun</st>
															</e>
														</wpn>
														<sM z="105281"/>
														<wng z="105282"/>
														<wG z="105283">
															<WGSpec z="105284" t="LINKED" a="true">
																<s z="105285">
																	<st>WS0007</st>
																	<st>WS0006</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105286">
															<st>unstable_injector</st>
															<st>missleracks</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>degraded_life_support</st>
															<st>degraded_engines</st>
															<st>degraded_shields</st>
															<st>comp_structure</st>
														</hM>
														<pM z="105287">
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>degraded_life_support</st>
															<st>degraded_engines</st>
															<st>degraded_shields</st>
															<st>comp_structure</st>
														</pM>
														<sMods z="105288"/>
														<sModdedBuiltIns z="105289"/>
														<suM z="105290"/>
														<tags z="105291">
															<st>variant_always_retain_smods_on_salvage</st>
														</tags>
													</savedVariant>
													<rT z="105292" cr="0.79999995" crPTM="0.0" sR="false" mo="false" lCR="false">
														<m ref="105278"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105293" o="0" sid="370bbc_3" sN="DSS Phi-Bo" t="SHIP" iF="false" id="370bc2" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105294" hId="sotf_keeper" v="3" c="0" hVId="370bbc_3" vDN="Close Support" s="REFIT" mAAW="false" gV="false">
														<wpn z="105295">
															<e>
																<st>WS 004</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 002</st>
																<st>vulcan</st>
															</e>
														</wpn>
														<sM z="105296"/>
														<wng z="105297">
															<st/>
															<st>sotf_brattice_wing</st>
														</wng>
														<wG z="105298">
															<WGSpec z="105299" t="LINKED" a="true">
																<s z="105300">
																	<st>WS 004</st>
																	<st>WS 002</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105301">
															<st>automated</st>
															<st>rugged</st>
															<st>missleracks</st>
															<st>reinforcedhull</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_wellknown</st>
														</hM>
														<pM z="105302">
															<st>progsmod_xptracker</st>
															<st>sun_sl_wellknown</st>
														</pM>
														<sMods z="105303"/>
														<sModdedBuiltIns z="105304"/>
														<suM z="105305"/>
													</savedVariant>
													<rT z="105306" cr="0.0" crPTM="0.0" sR="false" mo="false" lCR="false">
														<m ref="105293"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105307" o="0" sid="377ce5_0" sN="DSS Resh-Zi" t="SHIP" iF="false" id="377cf3" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105308" hId="berserker_default_D" v="20" c="5" hVId="377ce5_0" vDN="Assault" s="REFIT" mAAW="false" gV="false">
														<wpn z="105309">
															<e>
																<st>WS 008</st>
																<st>lightag</st>
															</e>
															<e>
																<st>WS 007</st>
																<st>shredder</st>
															</e>
															<e>
																<st>WS 001</st>
																<st>lightag</st>
															</e>
														</wpn>
														<sM z="105310"/>
														<wng z="105311"/>
														<wG z="105312">
															<WGSpec z="105313" t="LINKED" a="false">
																<s z="105314">
																	<st>WS 007</st>
																	<st>WS 005</st>
																	<st>WS 003</st>
																</s>
															</WGSpec>
															<WGSpec z="105315" t="LINKED" a="false">
																<s z="105316">
																	<st>WS 008</st>
																	<st>WS 001</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105317">
															<st>automated</st>
															<st>rugged</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_wellknown</st>
															<st>erratic_injector</st>
															<st>faulty_grid</st>
															<st>comp_structure</st>
														</hM>
														<pM z="105318">
															<st>progsmod_xptracker</st>
															<st>sun_sl_wellknown</st>
															<st>erratic_injector</st>
															<st>faulty_grid</st>
															<st>comp_structure</st>
														</pM>
														<sMods z="105319"/>
														<sModdedBuiltIns z="105320"/>
														<suM z="105321"/>
													</savedVariant>
													<rT z="105322" cr="0.0" crPTM="0.0" sR="false" mo="false" lCR="false">
														<m ref="105307"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105323" o="0" sid="wpnxt_invictus_Cache" sN="ISS Xolotl" t="SHIP" iF="false" id="41a18b" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105324" hId="invictus_default_D" v="50" c="18" hVId="wpnxt_invictus_Cache" vDN="Elite" s="REFIT" mAAW="false" gV="false">
														<wpn z="105325">
															<e>
																<st>WS 008</st>
																<st>devastator</st>
															</e>
															<e>
																<st>WS 006</st>
																<st>devastator</st>
															</e>
															<e>
																<st>WS 026</st>
																<st>devastator</st>
															</e>
															<e>
																<st>WS 024</st>
																<st>lidardish</st>
															</e>
															<e>
																<st>WS 025</st>
																<st>lidardish</st>
															</e>
															<e>
																<st>WS 022</st>
																<st>lidardish</st>
															</e>
															<e>
																<st>WS 023</st>
																<st>lidardish</st>
															</e>
														</wpn>
														<sM z="105326"/>
														<wng z="105327"/>
														<wG z="105328">
															<WGSpec z="105329" t="LINKED" a="true">
																<s z="105330">
																	<st>WS 008</st>
																	<st>WS 006</st>
																	<st>WS 026</st>
																	<st>WS 005</st>
																	<st>WS 003</st>
																	<st>WS 000</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105331">
															<st>hbi</st>
															<st>ablative_armor</st>
															<st>distributed_fire_control</st>
															<st>vast_hangar</st>
															<st>armoredweapons</st>
															<st>reinforcedhull</st>
															<st>auxiliarythrusters</st>
															<st>fluxbreakers</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>degraded_engines</st>
															<st>degraded_life_support</st>
															<st>faulty_auto</st>
														</hM>
														<pM z="105332">
															<st>fluxbreakers</st>
															<st>reinforcedhull</st>
															<st>auxiliarythrusters</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>degraded_engines</st>
															<st>degraded_life_support</st>
															<st>faulty_auto</st>
														</pM>
														<sMods z="105333">
															<st>fluxbreakers</st>
															<st>reinforcedhull</st>
															<st>auxiliarythrusters</st>
														</sMods>
														<sModdedBuiltIns z="105334"/>
														<suM z="105335"/>
														<tags z="105336">
															<st>no_autofit</st>
															<st>variant_always_retain_smods_on_salvage</st>
															<st>retain_smods_on_recovery</st>
														</tags>
													</savedVariant>
													<status z="105337">
														<status z="105338">
															<ShipStatus z="105339" hF="0.40114787" gW="18" gH="19">
																<aCF z="105340">
																	<f-a z="105341">1.0|1.0|1.0|1.0|1.0|1.0|1.0|0.96115035|0.94493896|0.94493896|0.9837886|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105342">1.0|1.0|1.0|1.0|0.98903733|0.9297192|0.8044559|0.5722159|0.4971444|0.43413892|0.55115116|0.5499487|0.34970483|0.15121928|0.30664894|0.6725225|0.9809875|1.0|1.0</f-a>
																	<f-a z="105343">1.0|1.0|0.9916412|0.96931386|0.8557282|0.7106203|0.40650305|0.09586035|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.1282187|1.0|1.0</f-a>
																	<f-a z="105344">1.0|0.9916412|0.9506755|0.88023764|0.6297729|0.50112134|0.20664199|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105345">1.0|0.970399|0.8995863|0.69961613|0.44578153|0.34217033|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105346">1.0|0.9453586|0.85512656|0.6652952|0.4707802|0.47261688|0.32537082|0.20791376|0.33260134|0.281794|0.26013264|0.102178924|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105347">1.0|0.93468463|0.84154975|0.69502294|0.5192043|0.5963626|0.5497313|0.59825313|0.7384978|0.7431853|0.6411873|0.5361362|0.5346422|0.39199498|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105348">1.0|0.9418251|0.8185922|0.81257415|0.68277115|0.8025659|0.86553836|0.8694756|0.8728431|0.78334266|0.7764408|0.54535824|0.63355|0.5056251|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105349">1.0|0.92360306|0.7969181|0.79151154|0.7908538|0.91719854|0.9988287|0.999264|0.91013277|0.74963367|0.7496539|0.6163134|0.7755039|0.6496273|0.0|0.0|0.0|0.38884306|1.0</f-a>
																	<f-a z="105350">1.0|0.91755396|0.7905067|0.7854878|0.7853116|0.90750676|0.9947985|0.9998267|0.8396968|0.67946935|0.563569|0.563569|0.7233121|0.8326586|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105351">1.0|0.9109401|0.77941304|0.76942027|0.724463|0.8486591|0.9475355|0.9333614|0.77588665|0.50039876|0.44875345|0.44875345|0.6088833|0.6096834|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105352">1.0|0.9306881|0.8021232|0.73464715|0.63831675|0.75192964|0.7775881|0.817103|0.7961977|0.52537745|0.3242524|0.30173275|0.34267202|0.5031738|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105353">1.0|0.9495963|0.8564446|0.7400744|0.6275381|0.59509796|0.46047273|0.3923981|0.42992663|0.09183644|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105354">1.0|0.97031194|0.9022412|0.7773504|0.5642134|0.36548552|0.076304786|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105355">1.0|0.9938263|0.9514363|0.8713266|0.66084456|0.4414013|0.1926892|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105356">1.0|1.0|0.9938263|0.9675754|0.8045317|0.5662414|0.30656004|0.07778349|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.76915926|1.0</f-a>
																	<f-a z="105357">1.0|1.0|1.0|1.0|0.9864512|0.88585097|0.7446455|0.6292044|0.56774473|0.5586065|0.4578887|0.34980822|0.17667225|0.08237686|0.31794396|0.6414242|0.965426|1.0|1.0</f-a>
																	<f-a z="105358">1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																</aCF>
																<s ref="105337"/>
																<hullDamageTaken>0.0</hullDamageTaken>
																<armorDamageTaken>0.0</armorDamageTaken>
															</ShipStatus>
														</status>
														<member ref="105323"/>
													</status>
													<rT z="105359" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105323"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105360" o="0" sid="wpnxt_retribution_Cache" sN="ISS Hladgunnr" t="SHIP" iF="false" id="41a191" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105361" hId="retribution_default_D" v="50" c="29" hVId="wpnxt_retribution_Cache" vDN="Experimental" s="REFIT" mAAW="false" gV="false">
														<wpn z="105362">
															<e>
																<st>WS 019</st>
																<st>pusherplate_lt</st>
															</e>
															<e>
																<st>WS 009</st>
																<st>wpnxt_minispiker</st>
															</e>
															<e>
																<st>WS 015</st>
																<st>wpnxt_lightrailburst</st>
															</e>
															<e>
																<st>WS 005</st>
																<st>flak</st>
															</e>
															<e>
																<st>WS 016</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 010</st>
																<st>wpnxt_minispiker</st>
															</e>
														</wpn>
														<sM z="105363"/>
														<wng z="105364"/>
														<wG z="105365">
															<WGSpec z="105366" t="LINKED" a="true">
																<s z="105367">
																	<st>WS 004</st>
																	<st>WS 015</st>
																	<st>WS 013</st>
																	<st>WS 003</st>
																	<st>WS 014</st>
																</s>
															</WGSpec>
															<WGSpec z="105368" t="LINKED" a="true">
																<s z="105369">
																	<st>WS 008</st>
																	<st>WS 009</st>
																	<st>WS 007</st>
																	<st>WS 020</st>
																	<st>WS 010</st>
																	<st>WS 021</st>
																</s>
															</WGSpec>
															<WGSpec z="105370" t="LINKED" a="true">
																<s z="105371">
																	<st>WS 006</st>
																	<st>WS 017</st>
																	<st>WS 005</st>
																	<st>WS 016</st>
																	<st>WS 011</st>
																	<st>WS 012</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105372">
															<st>distributed_fire_control</st>
															<st>ballistic_rangefinder</st>
															<st>armoredweapons</st>
															<st>heavyarmor</st>
															<st>hardenedshieldemitter</st>
															<st>fluxbreakers</st>
															<st>extendedshieldemitter</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
															<st>degraded_life_support</st>
															<st>fragile_subsystems</st>
															<st>faulty_grid</st>
														</hM>
														<pM z="105373">
															<st>heavyarmor</st>
															<st>ballistic_rangefinder</st>
															<st>armoredweapons</st>
															<st>extendedshieldemitter</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
															<st>degraded_life_support</st>
															<st>fragile_subsystems</st>
															<st>faulty_grid</st>
														</pM>
														<sMods z="105374">
															<st>ballistic_rangefinder</st>
															<st>armoredweapons</st>
															<st>extendedshieldemitter</st>
														</sMods>
														<sModdedBuiltIns z="105375"/>
														<suM z="105376"/>
														<tags z="105377">
															<st>always_recoverable</st>
															<st>no_autofit</st>
															<st>variant_always_retain_smods_on_salvage</st>
															<st>retain_smods_on_recovery</st>
														</tags>
													</savedVariant>
													<status z="105378">
														<status z="105379">
															<ShipStatus z="105380" hF="0.36784458" gW="12" gH="16">
																<aCF z="105381">
																	<f-a z="105382">1.0|1.0|1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|1.0</f-a>
																	<f-a z="105383">1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105384">1.0|1.0|1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|1.0</f-a>
																	<f-a z="105385">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105386">1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|1.0</f-a>
																	<f-a z="105387">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105388">1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|1.0</f-a>
																	<f-a z="105389">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.9991022</f-a>
																	<f-a z="105390">1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0</f-a>
																	<f-a z="105391">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|0.0|0.0|0.0|0.0|0.0</f-a>
																	<f-a z="105392">1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|1.0|0.0|0.5|0.0|0.5|0.0</f-a>
																	<f-a z="105393">1.0|1.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0</f-a>
																</aCF>
																<s ref="105378"/>
																<hullDamageTaken>0.0</hullDamageTaken>
																<armorDamageTaken>0.0</armorDamageTaken>
															</ShipStatus>
														</status>
														<member ref="105360"/>
													</status>
													<rT z="105394" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105360"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105395" o="0" sid="wpnxt_retribution_Cache" sN="ISS Amnesia Moon" t="SHIP" iF="false" id="41a18e" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105396" hId="retribution_default_D" v="50" c="29" hVId="wpnxt_retribution_Cache" vDN="Experimental" s="REFIT" mAAW="false" gV="false">
														<wpn z="105397">
															<e>
																<st>WS 019</st>
																<st>pusherplate_lt</st>
															</e>
															<e>
																<st>WS 009</st>
																<st>wpnxt_minispiker</st>
															</e>
															<e>
																<st>WS 004</st>
																<st>heavyneedler</st>
															</e>
															<e>
																<st>WS 003</st>
																<st>heavyneedler</st>
															</e>
															<e>
																<st>WS 011</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 020</st>
																<st>wpnxt_minispiker</st>
															</e>
														</wpn>
														<sM z="105398"/>
														<wng z="105399"/>
														<wG z="105400">
															<WGSpec z="105401" t="LINKED" a="true">
																<s z="105402">
																	<st>WS 004</st>
																	<st>WS 015</st>
																	<st>WS 013</st>
																	<st>WS 003</st>
																	<st>WS 014</st>
																</s>
															</WGSpec>
															<WGSpec z="105403" t="LINKED" a="true">
																<s z="105404">
																	<st>WS 008</st>
																	<st>WS 009</st>
																	<st>WS 007</st>
																	<st>WS 020</st>
																	<st>WS 010</st>
																	<st>WS 021</st>
																</s>
															</WGSpec>
															<WGSpec z="105405" t="LINKED" a="true">
																<s z="105406">
																	<st>WS 006</st>
																	<st>WS 017</st>
																	<st>WS 005</st>
																	<st>WS 016</st>
																	<st>WS 011</st>
																	<st>WS 012</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105407">
															<st>distributed_fire_control</st>
															<st>ballistic_rangefinder</st>
															<st>armoredweapons</st>
															<st>heavyarmor</st>
															<st>hardenedshieldemitter</st>
															<st>fluxbreakers</st>
															<st>extendedshieldemitter</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
															<st>glitched_sensors</st>
															<st>increased_maintenance</st>
														</hM>
														<pM z="105408">
															<st>heavyarmor</st>
															<st>ballistic_rangefinder</st>
															<st>armoredweapons</st>
															<st>extendedshieldemitter</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
															<st>glitched_sensors</st>
															<st>increased_maintenance</st>
														</pM>
														<sMods z="105409">
															<st>ballistic_rangefinder</st>
															<st>armoredweapons</st>
															<st>extendedshieldemitter</st>
														</sMods>
														<sModdedBuiltIns z="105410"/>
														<suM z="105411"/>
														<tags z="105412">
															<st>always_recoverable</st>
															<st>no_autofit</st>
															<st>variant_always_retain_smods_on_salvage</st>
															<st>retain_smods_on_recovery</st>
														</tags>
													</savedVariant>
													<status z="105413">
														<status z="105414">
															<ShipStatus z="105415" hF="0.35399276" gW="12" gH="16">
																<aCF z="105416">
																	<f-a z="105417">1.0|1.0|0.5|0.0|0.5|0.0|0.5|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105418">1.0|1.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105419">1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|1.0|0.0|0.5|0.0|1.0|1.0</f-a>
																	<f-a z="105420">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105421">1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|1.0|1.0</f-a>
																	<f-a z="105422">1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105423">0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.565657|1.0</f-a>
																	<f-a z="105424">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105425">0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105426">0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105427">0.5|0.0|0.5|0.0|0.5|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105428">1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																</aCF>
																<s ref="105413"/>
																<hullDamageTaken>0.0</hullDamageTaken>
																<armorDamageTaken>0.0</armorDamageTaken>
															</ShipStatus>
														</status>
														<member ref="105395"/>
													</status>
													<rT z="105429" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105395"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105430" o="0" sid="wpnxt_eradicator_Cache" sN="ISS Retake for Romance" t="SHIP" iF="false" id="41a19d" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105431" hId="eradicator_default_D" v="30" c="12" hVId="wpnxt_eradicator_Cache" vDN="Elite" s="REFIT" mAAW="false" gV="false">
														<wpn z="105432">
															<e>
																<st>WS 014</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 001</st>
																<st>gorgon</st>
															</e>
															<e>
																<st>WS 010</st>
																<st>wpnxt_fragcannon</st>
															</e>
														</wpn>
														<sM z="105433"/>
														<wng z="105434"/>
														<wG z="105435">
															<WGSpec z="105436" t="LINKED" a="false">
																<s z="105437">
																	<st>WS 004</st>
																	<st>WS 002</st>
																	<st>WS 003</st>
																	<st>WS 000</st>
																	<st>WS 001</st>
																</s>
															</WGSpec>
															<WGSpec z="105438" t="LINKED" a="true">
																<s z="105439">
																	<st>WS 011</st>
																	<st>WS 010</st>
																</s>
															</WGSpec>
															<WGSpec z="105440" t="LINKED" a="true">
																<s z="105441">
																	<st>WS 008</st>
																	<st>WS 013</st>
																	<st>WS 014</st>
																	<st>WS 012</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105442">
															<st>targetingunit</st>
															<st>missleracks</st>
															<st>magazines</st>
															<st>fluxdistributor</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
															<st>degraded_life_support</st>
															<st>degraded_shields</st>
														</hM>
														<pM z="105443">
															<st>targetingunit</st>
															<st>missleracks</st>
															<st>magazines</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
															<st>degraded_life_support</st>
															<st>degraded_shields</st>
														</pM>
														<sMods z="105444">
															<st>targetingunit</st>
															<st>missleracks</st>
															<st>magazines</st>
														</sMods>
														<sModdedBuiltIns z="105445"/>
														<suM z="105446"/>
														<tags z="105447">
															<st>no_autofit</st>
															<st>variant_always_retain_smods_on_salvage</st>
															<st>retain_smods_on_recovery</st>
														</tags>
													</savedVariant>
													<status z="105448">
														<status z="105449">
															<ShipStatus z="105450" hF="0.41939703" gW="12" gH="15">
																<aCF z="105451">
																	<f-a z="105452">1.0|1.0|1.0|1.0|0.5|0.0|0.5|0.0|0.5|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105453">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105454">1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105455">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105456">1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.006605223|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105457">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105458">1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105459">1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105460">1.0|1.0|1.0|1.0|0.5|0.0|0.5|0.0|0.5|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105461">1.0|1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105462">1.0|1.0|1.0|1.0|1.0|0.0|0.5|0.0|0.5|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105463">1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																</aCF>
																<s ref="105448"/>
																<hullDamageTaken>0.0</hullDamageTaken>
																<armorDamageTaken>0.0</armorDamageTaken>
															</ShipStatus>
														</status>
														<member ref="105430"/>
													</status>
													<rT z="105464" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105430"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105465" o="0" sid="wpnxt_eradicator_Cache" sN="ISS Garshasp" t="SHIP" iF="false" id="41a194" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105466" hId="eradicator_default_D" v="30" c="12" hVId="wpnxt_eradicator_Cache" vDN="Elite" s="REFIT" mAAW="false" gV="false">
														<wpn z="105467">
															<e>
																<st>WS 008</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 004</st>
																<st>gorgon</st>
															</e>
															<e>
																<st>WS 003</st>
																<st>gorgon</st>
															</e>
															<e>
																<st>WS 012</st>
																<st>vulcan</st>
															</e>
														</wpn>
														<sM z="105468"/>
														<wng z="105469"/>
														<wG z="105470">
															<WGSpec z="105471" t="LINKED" a="false">
																<s z="105472">
																	<st>WS 004</st>
																	<st>WS 002</st>
																	<st>WS 003</st>
																	<st>WS 000</st>
																	<st>WS 001</st>
																</s>
															</WGSpec>
															<WGSpec z="105473" t="LINKED" a="true">
																<s z="105474">
																	<st>WS 008</st>
																	<st>WS 013</st>
																	<st>WS 014</st>
																	<st>WS 012</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105475">
															<st>targetingunit</st>
															<st>missleracks</st>
															<st>magazines</st>
															<st>fluxdistributor</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>glitched_sensors</st>
															<st>comp_hull</st>
														</hM>
														<pM z="105476">
															<st>targetingunit</st>
															<st>missleracks</st>
															<st>magazines</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>glitched_sensors</st>
															<st>comp_hull</st>
														</pM>
														<sMods z="105477">
															<st>targetingunit</st>
															<st>missleracks</st>
															<st>magazines</st>
														</sMods>
														<sModdedBuiltIns z="105478"/>
														<suM z="105479"/>
														<tags z="105480">
															<st>no_autofit</st>
															<st>variant_always_retain_smods_on_salvage</st>
															<st>retain_smods_on_recovery</st>
														</tags>
													</savedVariant>
													<status z="105481">
														<status z="105482">
															<ShipStatus z="105483" hF="0.37394708" gW="12" gH="15">
																<aCF z="105484">
																	<f-a z="105485">1.0|1.0|1.0|1.0|0.9993435|0.0|0.0|0.0|0.99992263|0.99992263|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105486">1.0|0.98987085|0.986544|0.9442655|0.0|0.0|0.0|0.0|0.0|0.0|0.9592592|0.96109885|1.0|1.0|1.0</f-a>
																	<f-a z="105487">0.98987085|0.9709424|0.91587764|0.873599|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0</f-a>
																	<f-a z="105488">0.98439837|0.9553544|0.90028954|0.8580109|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.91979754|1.0|1.0</f-a>
																	<f-a z="105489">0.98439837|0.9553544|0.90028954|0.8586674|0.8736125|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105490">0.9945275|0.9688104|0.93456614|0.89294404|0.9085457|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105491">1.0|0.95383275|0.9109564|0.89893657|0.9159512|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105492">0.980107|0.9274532|0.8826728|0.8629791|0.858143|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105493">0.980107|0.9274532|0.88251823|0.8597153|0.8548793|0.83347064|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105494">0.980107|0.94825506|0.90332013|0.8805172|0.87651294|0.85510427|0.0|0.0|0.0|0.0|0.0|0.0|0.27778465|1.0|1.0</f-a>
																	<f-a z="105495">1.0|0.980107|0.96799356|0.95270985|0.9619746|0.90485173|0.8426892|0.0|0.0|0.0|0.8971755|0.9975049|1.0|1.0|1.0</f-a>
																	<f-a z="105496">1.0|1.0|1.0|0.9998454|0.99673617|0.99673617|0.9410783|0.9298116|0.9273165|0.9831289|0.9975049|1.0|1.0|1.0|1.0</f-a>
																</aCF>
																<s ref="105481"/>
																<hullDamageTaken>0.0</hullDamageTaken>
																<armorDamageTaken>0.0</armorDamageTaken>
															</ShipStatus>
														</status>
														<member ref="105465"/>
													</status>
													<rT z="105497" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105465"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105498" o="0" sid="wpnxt_lasher_Cache" sN="ISS Karsasp" t="SHIP" iF="false" id="41a1a6" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105499" hId="lasher_default_D" v="10" c="8" hVId="wpnxt_lasher_Cache" vDN="Elite" s="REFIT" mAAW="false" gV="false">
														<wpn z="105500">
															<e>
																<st>WS 002</st>
																<st>lightneedler</st>
															</e>
														</wpn>
														<sM z="105501"/>
														<wng z="105502"/>
														<wG z="105503">
															<WGSpec z="105504" t="LINKED" a="true">
																<s z="105505">
																	<st>WS 002</st>
																	<st>WS 003</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105506">
															<st>ballistic_rangefinder</st>
															<st>unstable_injector</st>
															<st>missleracks</st>
															<st>fluxdistributor</st>
															<st>hardenedshieldemitter</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
															<st>faulty_auto</st>
															<st>glitched_sensors</st>
														</hM>
														<pM z="105507">
															<st>fluxdistributor</st>
															<st>unstable_injector</st>
															<st>missleracks</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
															<st>faulty_auto</st>
															<st>glitched_sensors</st>
														</pM>
														<sMods z="105508">
															<st>fluxdistributor</st>
															<st>unstable_injector</st>
															<st>missleracks</st>
														</sMods>
														<sModdedBuiltIns z="105509"/>
														<suM z="105510"/>
														<tags z="105511">
															<st>no_autofit</st>
															<st>variant_always_retain_smods_on_salvage</st>
															<st>retain_smods_on_recovery</st>
														</tags>
													</savedVariant>
													<status z="105512">
														<status z="105513">
															<ShipStatus z="105514" hF="0.43360388" gW="10" gH="12">
																<aCF z="105515">
																	<f-a z="105516">1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105517">1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105518">1.0|1.0|1.0|0.0|0.5|0.0|0.5|0.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105519">1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105520">1.0|1.0|1.0|0.0|0.5|0.0|0.5|0.0|0.5|0.0|1.0|1.0</f-a>
																	<f-a z="105521">1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105522">1.0|1.0|1.0|1.0|1.0|1.0|1.0|0.0|0.5|0.0|1.0|1.0</f-a>
																	<f-a z="105523">1.0|1.0|1.0|1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.26139355|1.0</f-a>
																	<f-a z="105524">1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105525">1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																</aCF>
																<s ref="105512"/>
																<hullDamageTaken>0.0</hullDamageTaken>
																<armorDamageTaken>0.0</armorDamageTaken>
															</ShipStatus>
														</status>
														<member ref="105498"/>
													</status>
													<rT z="105526" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105498"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105527" o="0" sid="hermes_d_Hull" sN="ISS Inferior Conjunction" t="SHIP" iF="false" id="2b" sUN="false" civ="false" cCiv="false">
													<rT z="105528" cr="0.0" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="105527"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105529" o="0" sid="7013bb_5" sN="ISS No Strings Attached" t="SHIP" iF="false" id="7013e3" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105530" hId="revenant_default_D" v="0" c="12" hVId="7013bb_5" vDN="Elite" s="REFIT" mAAW="false" gV="false">
														<wpn z="105531"/>
														<sM z="105532"/>
														<wng z="105533"/>
														<wG z="105534"/>
														<hM z="105535">
															<st>phasefield</st>
															<st>delicate</st>
															<st>efficiency_overhaul</st>
															<st>augmentedengines</st>
															<st>comp_structure</st>
															<st>comp_storage</st>
															<st>erratic_injector</st>
															<st>degraded_drive_field</st>
															<st>rat_controller</st>
														</hM>
														<pM z="105536">
															<st>comp_structure</st>
															<st>comp_storage</st>
															<st>erratic_injector</st>
															<st>degraded_drive_field</st>
														</pM>
														<sMods z="105537"/>
														<sModdedBuiltIns z="105538"/>
														<suM z="105539"/>
														<tags z="105540">
															<st>variant_always_retain_smods_on_salvage</st>
														</tags>
													</savedVariant>
													<crew z="105541">24.0|0.0</crew>
													<status z="105542">
														<status z="105543">
															<ShipStatus z="105544" hF="0.58366555" gW="14" gH="15">
																<aCF z="105545">
																	<f-a z="105546">1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105547">1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105548">1.0|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105549">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105550">1.0|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105551">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105552">0.5|0.0|0.5|0.0|0.5|0.0|1.0|1.0|0.5|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105553">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105554">0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105555">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105556">0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.5|0.0|0.9931184|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105557">1.0|1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105558">1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|0.5|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105559">1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|0.0|1.0|1.0|1.0|1.0</f-a>
																</aCF>
																<s ref="105542"/>
																<hullDamageTaken>0.0</hullDamageTaken>
																<armorDamageTaken>0.0</armorDamageTaken>
															</ShipStatus>
														</status>
														<member ref="105529"/>
													</status>
													<rT z="105560" cr="0.3445225" crPTM="0.0" sR="false" mo="false" lCR="false">
														<m ref="105529"/>
														<recentEvents z="105561">
															<CREvent z="105562">
																<crAmount>-0.05</crAmount>
																<text>Emergency burn</text>
																<elapsed>1.7363646</elapsed>
															</CREvent>
															<CREvent z="105563">
																<crAmount>-1.0</crAmount>
																<text>disabled in combat</text>
																<elapsed>0.8827998</elapsed>
															</CREvent>
														</recentEvents>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105564" o="0" sid="7013bb_2" sN="ISS Borvo" t="SHIP" iF="false" id="7013d5" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105565" hId="tahlan_throne_default_D" v="24" c="2" hVId="7013bb_2" vDN="Gunship" s="REFIT" mAAW="false" gV="false">
														<wpn z="105566">
															<e>
																<st>WS0001</st>
																<st>eis_dualrailgun</st>
															</e>
															<e>
																<st>WS0011</st>
																<st>eis_dualrailgun</st>
															</e>
															<e>
																<st>WS0009</st>
																<st>flicker_pdl</st>
															</e>
															<e>
																<st>WS0005</st>
																<st>flicker_pdl</st>
															</e>
															<e>
																<st>WS0007</st>
																<st>flicker_pdl</st>
															</e>
														</wpn>
														<sM z="105567"/>
														<wng z="105568"/>
														<wG z="105569">
															<WGSpec z="105570" t="LINKED" a="true">
																<s z="105571">
																	<st>WS0001</st>
																	<st>WS0012</st>
																	<st>WS0011</st>
																	<st>WS0002</st>
																</s>
															</WGSpec>
															<WGSpec z="105572" t="LINKED" a="true">
																<s z="105573">
																	<st>WS0010</st>
																	<st>WS0009</st>
																	<st>WS0008</st>
																	<st>WS0005</st>
																	<st>WS0007</st>
																	<st>WS0006</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105574">
															<st>targetingunit</st>
															<st>fluxdistributor</st>
															<st>faulty_auto</st>
															<st>rat_controller</st>
														</hM>
														<pM z="105575">
															<st>faulty_auto</st>
														</pM>
														<sMods z="105576"/>
														<sModdedBuiltIns z="105577"/>
														<suM z="105578"/>
														<tags z="105579">
															<st>variant_always_retain_smods_on_salvage</st>
														</tags>
													</savedVariant>
													<crew z="105580">240.0|0.0</crew>
													<status z="105581">
														<status z="105582">
															<ShipStatus z="105583" hF="0.4999767" gW="12" gH="14">
																<aCF z="105584">
																	<f-a z="105585">1.0|1.0|1.0|1.0|1.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105586">1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105587">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105588">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105589">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105590">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105591">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105592">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.891051|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105593">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105594">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105595">1.0|1.0|1.0|0.0|0.0|0.0|0.16606219|0.0|0.0|0.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105596">1.0|1.0|1.0|1.0|1.0|1.0|0.9966009|0.9966009|0.9966009|1.0|1.0|1.0|1.0|1.0</f-a>
																</aCF>
																<s ref="105581"/>
																<hullDamageTaken>0.0</hullDamageTaken>
																<armorDamageTaken>0.0</armorDamageTaken>
															</ShipStatus>
														</status>
														<member ref="105564"/>
													</status>
													<rT z="105597" cr="0.4205744" crPTM="0.0" sR="false" mo="false" lCR="false">
														<m ref="105564"/>
														<recentEvents z="105598">
															<CREvent z="105599">
																<crAmount>-0.03</crAmount>
																<text>Emergency burn</text>
																<elapsed>1.7363646</elapsed>
															</CREvent>
															<CREvent z="105600">
																<crAmount>-1.0</crAmount>
																<text>disabled in combat</text>
																<elapsed>0.8827998</elapsed>
															</CREvent>
														</recentEvents>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105601" o="1" sid="geist_Standard" sN="ISS Riga" t="SHIP" iF="false" id="708f16" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105602" hId="geist_default_D" v="0" c="0" hVId="geist_Standard" vDN="Standard" s="REFIT" mAAW="false" gV="true">
														<wpn z="105603">
															<e>
																<st>WS0001</st>
																<st>lrpdlaser</st>
															</e>
															<e>
																<st>WS0005</st>
																<st>lrpdlaser</st>
															</e>
															<e>
																<st>WS0007</st>
																<st>lrpdlaser</st>
															</e>
														</wpn>
														<sM z="105604"/>
														<wng z="105605"/>
														<wG z="105606">
															<WGSpec z="105607" t="LINKED" a="true">
																<s z="105608">
																	<st>WS0001</st>
																	<st>WS0005</st>
																	<st>WS0007</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105609">
															<st>phasefield</st>
															<st>delicate</st>
															<st>glitched_sensors</st>
															<st>increased_maintenance</st>
															<st>damaged_mounts</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
														</hM>
														<pM z="105610">
															<st>glitched_sensors</st>
															<st>increased_maintenance</st>
															<st>damaged_mounts</st>
															<st>progsmod_xptracker</st>
														</pM>
														<sMods z="105611"/>
														<sModdedBuiltIns z="105612"/>
														<suM z="105613"/>
														<tags z="105614">
															<st>ship_recoverable</st>
														</tags>
													</savedVariant>
													<status z="105615">
														<status z="105616">
															<ShipStatus z="105617" hF="0.31063822" gW="14" gH="15">
																<aCF z="105618">
																	<f-a z="105619">1.0|1.0|1.0|1.0|0.0|0.0|0.0|1.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105620">1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0</f-a>
																	<f-a z="105621">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0</f-a>
																	<f-a z="105622">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105623">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105624">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.6407137</f-a>
																	<f-a z="105625">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0</f-a>
																	<f-a z="105626">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0</f-a>
																	<f-a z="105627">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0</f-a>
																	<f-a z="105628">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0</f-a>
																	<f-a z="105629">1.0|1.0|0.0|0.0|0.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105630">1.0|1.0|1.0|1.0|1.0|1.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105631">1.0|1.0|1.0|1.0|1.0|1.0|1.0|0.0|0.0|0.0|1.0|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105632">1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0|1.0</f-a>
																</aCF>
																<s ref="105615"/>
																<hullDamageTaken>0.0</hullDamageTaken>
																<armorDamageTaken>0.0</armorDamageTaken>
															</ShipStatus>
														</status>
														<member ref="105601"/>
													</status>
													<rT z="105633" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105601"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105634" o="0" sid="70137f_0" sN="ISS Earthman's Choice" t="SHIP" iF="false" id="70138d" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105635" hId="ii_dictator_default_D" v="10" c="3" hVId="70137f_0" vDN="Standard" s="REFIT" mAAW="false" gV="false">
														<wpn z="105636">
															<e>
																<st>BLINKER8</st>
																<st>ii_targeting_blinker4</st>
															</e>
															<e>
																<st>BLINKER7</st>
																<st>ii_targeting_blinker4</st>
															</e>
															<e>
																<st>BLINKER6</st>
																<st>ii_targeting_blinker3</st>
															</e>
															<e>
																<st>BLINKER5</st>
																<st>ii_targeting_blinker3</st>
															</e>
															<e>
																<st>BLINKER4</st>
																<st>ii_targeting_blinker2</st>
															</e>
															<e>
																<st>BLINKER3</st>
																<st>ii_targeting_blinker2</st>
															</e>
															<e>
																<st>BLINKER2</st>
																<st>ii_targeting_blinker1</st>
															</e>
															<e>
																<st>BLINKER1</st>
																<st>ii_targeting_blinker1</st>
															</e>
															<e>
																<st>ELITE</st>
																<st>ii_elite_lights_dictator</st>
															</e>
															<e>
																<st>WS0012</st>
																<st>kol_tor</st>
															</e>
															<e>
																<st>WS0013</st>
																<st>ii_siegemortar</st>
															</e>
															<e>
																<st>WS0005</st>
																<st>gazerpod</st>
															</e>
															<e>
																<st>WS0007</st>
																<st>ii_particlecannon</st>
															</e>
														</wpn>
														<sM z="105637"/>
														<wng z="105638"/>
														<wG z="105639">
															<WGSpec z="105640" t="LINKED" a="false">
																<s z="105641">
																	<st>WS0005</st>
																</s>
															</WGSpec>
															<WGSpec z="105642" t="LINKED" a="true">
																<s z="105643">
																	<st>WS0015</st>
																	<st>WS0014</st>
																	<st>WS0013</st>
																</s>
															</WGSpec>
															<WGSpec z="105644" t="LINKED" a="true">
																<s z="105645">
																	<st>WS0012</st>
																	<st>WS0011</st>
																	<st>WS0010</st>
																	<st>WS0009</st>
																	<st>WS0008</st>
																</s>
															</WGSpec>
															<WGSpec z="105646" t="LINKED" a="true">
																<s z="105647">
																	<st>WS0007</st>
																	<st>WS0006</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105648">
															<st>ii_reinforced_emplacements</st>
															<st>targetingunit</st>
															<st>missleracks</st>
															<st>faulty_auto</st>
															<st>degraded_life_support</st>
															<st>degraded_engines</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
														</hM>
														<pM z="105649">
															<st>faulty_auto</st>
															<st>degraded_life_support</st>
															<st>degraded_engines</st>
															<st>progsmod_xptracker</st>
														</pM>
														<sMods z="105650"/>
														<sModdedBuiltIns z="105651"/>
														<suM z="105652"/>
														<tags z="105653">
															<st>variant_always_retain_smods_on_salvage</st>
														</tags>
													</savedVariant>
													<crew z="105654">300.0|0.0</crew>
													<status z="105655">
														<status z="105656">
															<ShipStatus z="105657" hF="0.37937728" gW="14" gH="15">
																<aCF z="105658">
																	<f-a z="105659">1.0|1.0|1.0|0.9574748|0.34977275|0.21295983|0.0|0.0|0.0|0.75517786|0.9479147|1.0|1.0|1.0|1.0</f-a>
																	<f-a z="105660">1.0|1.0|0.9574748|0.23070735|0.0|0.0|0.0|0.0|0.0|0.0|0.031850092|0.8817244|1.0|1.0|1.0</f-a>
																	<f-a z="105661">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.2021376|0.93380964|1.0|1.0</f-a>
																	<f-a z="105662">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.8028456|1.0|1.0</f-a>
																	<f-a z="105663">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.099860534|1.0|1.0</f-a>
																	<f-a z="105664">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105665">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0|1.0</f-a>
																	<f-a z="105666">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.79008555|1.0</f-a>
																	<f-a z="105667">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|1.0</f-a>
																	<f-a z="105668">0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.14955622|1.0</f-a>
																	<f-a z="105669">1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.13240026|1.0|1.0</f-a>
																	<f-a z="105670">1.0|1.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.0|0.962482|1.0|1.0</f-a>
																	<f-a z="105671">1.0|1.0|1.0|0.4663513|0.4594213|0.0|0.0|0.0|0.0|0.0|0.0|0.61807275|1.0|1.0|1.0</f-a>
																	<f-a z="105672">1.0|1.0|1.0|1.0|0.9977824|0.99307|0.18891266|0.16496146|0.0|0.6294219|0.6555906|1.0|1.0|1.0|1.0</f-a>
																</aCF>
																<s ref="105655"/>
																<hullDamageTaken>0.0</hullDamageTaken>
																<armorDamageTaken>0.0</armorDamageTaken>
															</ShipStatus>
														</status>
														<member ref="105634"/>
													</status>
													<rT z="105673" cr="0.0" crPTM="0.0" sR="false" mo="false" lCR="false">
														<m ref="105634"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105674" o="0" sid="692ca1_1" sN="TTDS Ayin-Princess" t="SHIP" iF="false" id="692cad" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105675" hId="brilliant_default_D" v="35" c="17" hVId="692ca1_1" vDN="Standard" s="REFIT" mAAW="false" gV="false">
														<wpn z="105676">
															<e>
																<st>WS 004</st>
																<st>tahlan_fount</st>
															</e>
															<e>
																<st>WS 002</st>
																<st>flicker_pdl</st>
															</e>
															<e>
																<st>WS 000</st>
																<st>plasma</st>
															</e>
															<e>
																<st>WS 001</st>
																<st>flicker_pdl</st>
															</e>
														</wpn>
														<sM z="105677"/>
														<wng z="105678"/>
														<wG z="105679">
															<WGSpec z="105680" t="LINKED" a="false">
																<s z="105681">
																	<st>WS 004</st>
																</s>
															</WGSpec>
															<WGSpec z="105682" t="LINKED" a="false">
																<s z="105683">
																	<st>WS 000</st>
																</s>
															</WGSpec>
															<WGSpec z="105684" t="LINKED" a="true">
																<s z="105685">
																	<st>WS 002</st>
																	<st>WS 001</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105686">
															<st>automated</st>
															<st>targetingunit</st>
															<st>degraded_shields</st>
															<st>erratic_injector</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
														</hM>
														<pM z="105687">
															<st>degraded_shields</st>
															<st>erratic_injector</st>
															<st>progsmod_xptracker</st>
														</pM>
														<sMods z="105688"/>
														<sModdedBuiltIns z="105689"/>
														<suM z="105690"/>
													</savedVariant>
													<rT z="105691" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105674"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105692" o="0" sid="692ca1_2" sN="TTDS Machineries of Empire" t="SHIP" iF="false" id="692cb7" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105693" hId="SKR_fresnel_default_D" v="26" c="0" hVId="692ca1_2" vDN="Combat" s="REFIT" mAAW="false" gV="false">
														<wpn z="105694">
															<e>
																<st>WS0001</st>
																<st>SKR_fuscina</st>
															</e>
															<e>
																<st>WS0003</st>
																<st>SKR_fuscina</st>
															</e>
															<e>
																<st>WS0002</st>
																<st>SKR_fuscina</st>
															</e>
															<e>
																<st>WS0009</st>
																<st>pdburst</st>
															</e>
															<e>
																<st>WS0008</st>
																<st>lrpdlaser</st>
															</e>
															<e>
																<st>WS0005</st>
																<st>harpoon</st>
															</e>
															<e>
																<st>WS0004</st>
																<st>amblaster</st>
															</e>
															<e>
																<st>WS0007</st>
																<st>lrpdlaser</st>
															</e>
														</wpn>
														<sM z="105695"/>
														<wng z="105696">
															<st/>
															<st>flash_wing</st>
														</wng>
														<wG z="105697">
															<WGSpec z="105698" t="LINKED" a="false">
																<s z="105699">
																	<st>WS0004</st>
																</s>
															</WGSpec>
															<WGSpec z="105700" t="ALTERNATING" a="false">
																<s z="105701">
																	<st>WS0005</st>
																	<st>WS0006</st>
																</s>
															</WGSpec>
															<WGSpec z="105702" t="LINKED" a="false">
																<s z="105703">
																	<st>WS0001</st>
																	<st>WS0003</st>
																	<st>WS0002</st>
																</s>
															</WGSpec>
															<WGSpec z="105704" t="LINKED" a="true">
																<s z="105705">
																	<st>WS0009</st>
																</s>
															</WGSpec>
															<WGSpec z="105706" t="LINKED" a="true">
																<s z="105707">
																	<st>WS0008</st>
																	<st>WS0007</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105708">
															<st>automated</st>
															<st>missleracks</st>
															<st>targetingunit</st>
															<st>comp_structure</st>
															<st>damaged_deck</st>
															<st>damaged_mounts</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
														</hM>
														<pM z="105709">
															<st>comp_structure</st>
															<st>damaged_deck</st>
															<st>damaged_mounts</st>
															<st>progsmod_xptracker</st>
														</pM>
														<sMods z="105710"/>
														<sModdedBuiltIns z="105711"/>
														<suM z="105712"/>
													</savedVariant>
													<rT z="105713" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105692"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105714" o="0" sid="radiant_Strike" sN="ISS Girl With the Hungry Eyes" t="SHIP" iF="false" id="6331c8" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105715" hId="radiant_default_D" v="0" c="0" hVId="radiant_Strike" vDN="Strike" s="REFIT" mAAW="false" gV="true">
														<wpn z="105716">
															<e>
																<st>WS 009</st>
																<st>pdlaser</st>
															</e>
															<e>
																<st>WS 006</st>
																<st>sabotpod</st>
															</e>
															<e>
																<st>WS 018</st>
																<st>pdlaser</st>
															</e>
															<e>
																<st>WS 015</st>
																<st>pdlaser</st>
															</e>
															<e>
																<st>WS 005</st>
																<st>sabotpod</st>
															</e>
															<e>
																<st>WS 001</st>
																<st>tachyonlance</st>
															</e>
														</wpn>
														<sM z="105717"/>
														<wng z="105718"/>
														<wG z="105719">
															<WGSpec z="105720" t="LINKED" a="false">
																<s z="105721">
																	<st>WS 001</st>
																</s>
															</WGSpec>
															<WGSpec z="105722" t="ALTERNATING" a="false">
																<s z="105723">
																	<st>WS 006</st>
																	<st>WS 005</st>
																</s>
															</WGSpec>
															<WGSpec z="105724" t="LINKED" a="true">
																<s z="105725">
																	<st>WS 009</st>
																	<st>WS 018</st>
																	<st>WS 015</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105726">
															<st>automated</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_hull</st>
															<st>fragile_subsystems</st>
														</hM>
														<pM z="105727">
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_hull</st>
															<st>fragile_subsystems</st>
														</pM>
														<sMods z="105728"/>
														<sModdedBuiltIns z="105729"/>
														<suM z="105730"/>
														<tags z="105731">
															<st>ship_recoverable</st>
														</tags>
													</savedVariant>
													<rT z="105732" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105714"/>
													</rT>
													<buffManager z="105733">
														<member ref="105714"/>
														<buffs cl="linked-list" z="105734">
															<aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff z="105735">
																<id>ash_supplies_recycler</id>
																<statValue>0.84745765</statValue>
															</aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff>
														</buffs>
													</buffManager>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105736" o="0" sid="692ca1_0" sN="TTDS Rho-Earl" t="SHIP" iF="false" id="692cab" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105737" hId="brilliant_default_D" v="35" c="13" hVId="692ca1_0" vDN="Standard" s="REFIT" mAAW="false" gV="false">
														<wpn z="105738">
															<e>
																<st>WS 002</st>
																<st>flicker_pdl</st>
															</e>
														</wpn>
														<sM z="105739"/>
														<wng z="105740"/>
														<wG z="105741">
															<WGSpec z="105742" t="LINKED" a="true">
																<s z="105743">
																	<st>WS 002</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105744">
															<st>automated</st>
															<st>targetingunit</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
														</hM>
														<pM z="105745">
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_structure</st>
														</pM>
														<sMods z="105746"/>
														<sModdedBuiltIns z="105747"/>
														<suM z="105748"/>
													</savedVariant>
													<rT z="105749" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105736"/>
													</rT>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105750" o="0" sid="626c06_5" sN="HSS Defiant" t="SHIP" iF="false" id="xivtf_1687463149434184144" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105751" hId="enforcer_xiv_default_D" v="20" c="15" hVId="626c06_5" vDN="Automated" s="REFIT" mAAW="false" gV="false">
														<wpn z="105752">
															<e>
																<st>WS 007</st>
																<st>sabot</st>
															</e>
															<e>
																<st>WS 003</st>
																<st>wpnxt_heavypounder</st>
															</e>
															<e>
																<st>WS 001</st>
																<st>dualflak</st>
															</e>
														</wpn>
														<sM z="105753"/>
														<wng z="105754"/>
														<wG z="105755">
															<WGSpec z="105756" t="ALTERNATING" a="false">
																<s z="105757">
																	<st>WS 008</st>
																	<st>WS 007</st>
																</s>
															</WGSpec>
															<WGSpec z="105758" t="LINKED" a="true">
																<s z="105759">
																	<st>WS 003</st>
																</s>
															</WGSpec>
															<WGSpec z="105760" t="LINKED" a="true">
																<s z="105761">
																	<st>WS 005</st>
																	<st>WS 001</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105762">
															<st>fourteenth</st>
															<st>missleracks</st>
															<st>fluxdistributor</st>
															<st>automated</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>degraded_engines</st>
															<st>comp_structure</st>
														</hM>
														<pM z="105763">
															<st>missleracks</st>
															<st>fluxdistributor</st>
															<st>automated</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>degraded_engines</st>
															<st>comp_structure</st>
														</pM>
														<sMods z="105764">
															<st>missleracks</st>
															<st>fluxdistributor</st>
														</sMods>
														<sModdedBuiltIns z="105765"/>
														<suM z="105766"/>
														<tags z="105767">
															<st>no_auto_penalty</st>
															<st>unrestorable</st>
															<st>retain_smods_on_recovery</st>
														</tags>
													</savedVariant>
													<rT z="105768" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105750"/>
													</rT>
													<buffManager z="105769">
														<member ref="105750"/>
														<buffs cl="linked-list" z="105770">
															<aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff z="105771">
																<id>ash_supplies_recycler</id>
																<statValue>0.84745765</statValue>
															</aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff>
														</buffs>
													</buffManager>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105772" o="0" sid="626c06_1" sN="HSS Vandal" t="SHIP" iF="false" id="xivtf_2523069692765973161" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105773" hId="dominator_xiv_default_D" v="23" c="30" hVId="626c06_1" vDN="Automated" s="REFIT" mAAW="false" gV="false">
														<wpn z="105774">
															<e>
																<st>WS 008</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 015</st>
																<st>sabotpod</st>
															</e>
															<e>
																<st>WS 003</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 010</st>
																<st>heavyneedler</st>
															</e>
														</wpn>
														<sM z="105775"/>
														<wng z="105776"/>
														<wG z="105777">
															<WGSpec z="105778" t="LINKED" a="false">
																<s z="105779">
																	<st>WS 015</st>
																</s>
															</WGSpec>
															<WGSpec z="105780" t="LINKED" a="true">
																<s z="105781">
																	<st>WS 010</st>
																</s>
															</WGSpec>
															<WGSpec z="105782" t="LINKED" a="true">
																<s z="105783">
																	<st>WS 008</st>
																	<st>WS 007</st>
																	<st>WS 005</st>
																	<st>WS 003</st>
																	<st>WS 001</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105784">
															<st>fourteenth</st>
															<st>armoredweapons</st>
															<st>targetingunit</st>
															<st>fluxdistributor</st>
															<st>fluxcoil</st>
															<st>automated</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_armor</st>
														</hM>
														<pM z="105785">
															<st>targetingunit</st>
															<st>fluxdistributor</st>
															<st>automated</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_armor</st>
														</pM>
														<sMods z="105786">
															<st>targetingunit</st>
															<st>fluxdistributor</st>
														</sMods>
														<sModdedBuiltIns z="105787"/>
														<suM z="105788"/>
														<tags z="105789">
															<st>no_auto_penalty</st>
															<st>unrestorable</st>
															<st>retain_smods_on_recovery</st>
														</tags>
													</savedVariant>
													<rT z="105790" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105772"/>
													</rT>
													<buffManager z="105791">
														<member ref="105772"/>
														<buffs cl="linked-list" z="105792">
															<aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff z="105793">
																<id>ash_supplies_recycler</id>
																<statValue>0.84745765</statValue>
															</aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff>
														</buffs>
													</buffManager>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105794" o="0" sid="legion_xiv_Automated" sN="HSS Vandal" t="SHIP" iF="false" id="xivtf_-100202588351720309" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105795" hId="legion_xiv_default_D" v="50" c="39" hVId="legion_xiv_Automated" vDN="Automated" s="REFIT" mAAW="false" gV="false">
														<wpn z="105796"/>
														<sM z="105797"/>
														<wng z="105798">
															<st>flash_wing</st>
															<st/>
															<st>flash_wing</st>
															<st/>
														</wng>
														<wG z="105799"/>
														<hM z="105800">
															<st>fourteenth</st>
															<st>automated</st>
															<st>missleracks</st>
															<st>targetingunit</st>
															<st>heavyarmor</st>
															<st>reinforcedhull</st>
															<st>hardenedshieldemitter</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>degraded_engines</st>
															<st>faulty_grid</st>
															<st>comp_structure</st>
														</hM>
														<pM z="105801">
															<st>automated</st>
															<st>missleracks</st>
															<st>targetingunit</st>
															<st>heavyarmor</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>degraded_engines</st>
															<st>faulty_grid</st>
															<st>comp_structure</st>
														</pM>
														<sMods z="105802">
															<st>missleracks</st>
															<st>targetingunit</st>
															<st>heavyarmor</st>
														</sMods>
														<sModdedBuiltIns z="105803"/>
														<suM z="105804"/>
														<tags z="105805">
															<st>no_autofit</st>
															<st>no_auto_penalty</st>
															<st>unrestorable</st>
															<st>retain_smods_on_recovery</st>
															<st>always_recoverable</st>
														</tags>
													</savedVariant>
													<rT z="105806" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105794"/>
													</rT>
													<buffManager z="105807">
														<member ref="105794"/>
														<buffs cl="linked-list" z="105808">
															<aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff z="105809">
																<id>ash_supplies_recycler</id>
																<statValue>0.84745765</statValue>
															</aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff>
														</buffs>
													</buffManager>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105810" o="0" sid="626c06_0" sN="HSS Chicomoztoc Metroplex XII" t="SHIP" iF="false" id="xivtf_-965109191363876056" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105811" hId="onslaught_xiv_default_D" v="50" c="50" hVId="626c06_0" vDN="Automated" s="REFIT" mAAW="false" gV="false">
														<wpn z="105812">
															<e>
																<st>WS 008</st>
																<st>lightneedler</st>
															</e>
															<e>
																<st>WS 017</st>
																<st>tpc</st>
															</e>
															<e>
																<st>WS 018</st>
																<st>devastator</st>
															</e>
															<e>
																<st>WS 007</st>
																<st>dualflak</st>
															</e>
															<e>
																<st>WS 016</st>
																<st>tpc</st>
															</e>
															<e>
																<st>WS 005</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 013</st>
																<st>heavyac</st>
															</e>
															<e>
																<st>WS 014</st>
																<st>heavyneedler</st>
															</e>
														</wpn>
														<sM z="105813"/>
														<wng z="105814"/>
														<wG z="105815">
															<WGSpec z="105816" t="LINKED" a="false">
																<s z="105817">
																	<st>WS 017</st>
																	<st>WS 016</st>
																</s>
															</WGSpec>
															<WGSpec z="105818" t="LINKED" a="true">
																<s z="105819">
																	<st>WS 008</st>
																	<st>WS 009</st>
																	<st>WS 013</st>
																	<st>WS 003</st>
																	<st>WS 012</st>
																	<st>WS 001</st>
																</s>
															</WGSpec>
															<WGSpec z="105820" t="LINKED" a="true">
																<s z="105821">
																	<st>WS 015</st>
																	<st>WS 014</st>
																</s>
															</WGSpec>
															<WGSpec z="105822" t="LINKED" a="true">
																<s z="105823">
																	<st>WS 018</st>
																	<st>WS 020</st>
																</s>
															</WGSpec>
															<WGSpec z="105824" t="LINKED" a="true">
																<s z="105825">
																	<st>WS 006</st>
																	<st>WS 007</st>
																	<st>WS 004</st>
																	<st>WS 005</st>
																	<st>WS 002</st>
																	<st>WS 011</st>
																	<st>WS 010</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105826">
															<st>hbi</st>
															<st>fourteenth</st>
															<st>heavyarmor</st>
															<st>armoredweapons</st>
															<st>targetingunit</st>
															<st>fluxdistributor</st>
															<st>fluxcoil</st>
															<st>automated</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_hull</st>
															<st>glitched_sensors</st>
															<st>degraded_shields</st>
															<st>degraded_engines</st>
														</hM>
														<pM z="105827">
															<st>heavyarmor</st>
															<st>targetingunit</st>
															<st>armoredweapons</st>
															<st>automated</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>comp_hull</st>
															<st>glitched_sensors</st>
															<st>degraded_shields</st>
															<st>degraded_engines</st>
														</pM>
														<sMods z="105828">
															<st>heavyarmor</st>
															<st>targetingunit</st>
															<st>armoredweapons</st>
														</sMods>
														<sModdedBuiltIns z="105829"/>
														<suM z="105830"/>
														<tags z="105831">
															<st>no_auto_penalty</st>
															<st>unrestorable</st>
															<st>retain_smods_on_recovery</st>
															<st>always_recoverable</st>
														</tags>
													</savedVariant>
													<rT z="105832" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105810"/>
													</rT>
													<buffManager z="105833">
														<member ref="105810"/>
														<buffs cl="linked-list" z="105834">
															<aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff z="105835">
																<id>ash_supplies_recycler</id>
																<statValue>0.84745765</statValue>
															</aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff>
														</buffs>
													</buffManager>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105836" o="0" sid="3626_0" sN="HSS Waterloo" t="SHIP" iF="false" id="3628" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105837" hId="enforcer_xiv_default_D" v="20" c="16" hVId="3626_0" vDN="Elite" s="REFIT" mAAW="false" gV="false">
														<wpn z="105838">
															<e>
																<st>WS 008</st>
																<st>harpoon_single</st>
															</e>
															<e>
																<st>WS 007</st>
																<st>harpoon_single</st>
															</e>
															<e>
																<st>WS 005</st>
																<st>flak</st>
															</e>
															<e>
																<st>WS 001</st>
																<st>flak</st>
															</e>
														</wpn>
														<sM z="105839"/>
														<wng z="105840"/>
														<wG z="105841">
															<WGSpec z="105842" t="LINKED" a="true">
																<s z="105843">
																	<st>WS 005</st>
																	<st>WS 001</st>
																</s>
															</WGSpec>
															<WGSpec z="105844" t="ALTERNATING" a="false">
																<s z="105845">
																	<st>WS 008</st>
																	<st>WS 007</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105846">
															<st>fourteenth</st>
															<st>missleracks</st>
															<st>fluxdistributor</st>
															<st>fluxcoil</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>glitched_sensors</st>
															<st>fragile_subsystems</st>
															<st>comp_armor</st>
															<st>faulty_grid</st>
														</hM>
														<pM z="105847">
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>glitched_sensors</st>
															<st>fragile_subsystems</st>
															<st>comp_armor</st>
															<st>faulty_grid</st>
														</pM>
														<sMods z="105848"/>
														<sModdedBuiltIns z="105849"/>
														<suM z="105850"/>
														<originalVariant>enforcer_XIV_Elite</originalVariant>
													</savedVariant>
													<rT z="105851" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105836"/>
													</rT>
													<buffManager z="105852">
														<member ref="105836"/>
														<buffs cl="linked-list" z="105853">
															<aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff z="105854">
																<id>ash_supplies_recycler</id>
																<statValue>0.84745765</statValue>
															</aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff>
														</buffs>
													</buffManager>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105855" o="0" sid="3626_2" sN="HSS Defiant" t="SHIP" iF="false" id="362c" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105856" hId="eagle_xiv_default_D" v="30" c="30" hVId="3626_2" vDN="Elite" s="REFIT" mAAW="false" gV="false">
														<wpn z="105857">
															<e>
																<st>WS 008</st>
																<st>heavyac</st>
															</e>
															<e>
																<st>WS 007</st>
																<st>heavyac</st>
															</e>
															<e>
																<st>WS 004</st>
																<st>wpnxt_impactbeam</st>
															</e>
															<e>
																<st>WS 013</st>
																<st>heavymortar</st>
															</e>
															<e>
																<st>WS 002</st>
																<st>sabot_single</st>
															</e>
															<e>
																<st>WS 003</st>
																<st>wpnxt_impactbeam</st>
															</e>
															<e>
																<st>WS 011</st>
																<st>wpnxt_impactbeam</st>
															</e>
															<e>
																<st>WS 012</st>
																<st>wpnxt_impactbeam</st>
															</e>
															<e>
																<st>WS 010</st>
																<st>wpnxt_impactbeam</st>
															</e>
														</wpn>
														<sM z="105858"/>
														<wng z="105859"/>
														<wG z="105860">
															<WGSpec z="105861" t="LINKED" a="false">
																<s z="105862">
																	<st>WS 008</st>
																	<st>WS 007</st>
																</s>
															</WGSpec>
															<WGSpec z="105863" t="LINKED" a="false">
																<s z="105864">
																	<st>WS 002</st>
																</s>
															</WGSpec>
															<WGSpec z="105865" t="LINKED" a="false">
																<s z="105866">
																	<st>WS 013</st>
																</s>
															</WGSpec>
															<WGSpec z="105867" t="LINKED" a="true">
																<s z="105868">
																	<st>WS 004</st>
																	<st>WS 003</st>
																</s>
															</WGSpec>
															<WGSpec z="105869" t="LINKED" a="true">
																<s z="105870">
																	<st>WS 011</st>
																	<st>WS 012</st>
																	<st>WS 010</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105871">
															<st>fourteenth</st>
															<st>targetingunit</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>erratic_injector</st>
															<st>glitched_sensors</st>
															<st>degraded_life_support</st>
														</hM>
														<pM z="105872">
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>erratic_injector</st>
															<st>glitched_sensors</st>
															<st>degraded_life_support</st>
														</pM>
														<sMods z="105873"/>
														<sModdedBuiltIns z="105874"/>
														<suM z="105875"/>
														<originalVariant>eagle_xiv_Elite</originalVariant>
													</savedVariant>
													<rT z="105876" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105855"/>
													</rT>
													<buffManager z="105877">
														<member ref="105855"/>
														<buffs cl="linked-list" z="105878">
															<aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff z="105879">
																<id>ash_supplies_recycler</id>
																<statValue>0.84745765</statValue>
															</aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff>
														</buffs>
													</buffManager>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105880" o="0" sid="onslaught_Elite" sN="ISS No Questions Asked" t="SHIP" iF="false" id="5982dd" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105881" hId="onslaught" v="11" c="0" hVId="onslaught_Elite" vDN="Standard" s="REFIT" mAAW="false" gV="false">
														<wpn z="105882">
															<e>
																<st>WS 019</st>
																<st>mark9</st>
															</e>
															<e>
																<st>WS 008</st>
																<st>lightac</st>
															</e>
															<e>
																<st>WS 009</st>
																<st>lightac</st>
															</e>
															<e>
																<st>WS 017</st>
																<st>tpc</st>
															</e>
															<e>
																<st>WS 006</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 018</st>
																<st>devastator</st>
															</e>
															<e>
																<st>WS 007</st>
																<st>dualflak</st>
															</e>
															<e>
																<st>WS 015</st>
																<st>heavyac</st>
															</e>
															<e>
																<st>WS 004</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 016</st>
																<st>tpc</st>
															</e>
															<e>
																<st>WS 005</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 013</st>
																<st>heavyneedler</st>
															</e>
															<e>
																<st>WS 024</st>
																<st>annihilatorpod</st>
															</e>
															<e>
																<st>WS 002</st>
																<st>vulcan</st>
															</e>
															<e>
																<st>WS 014</st>
																<st>heavyac</st>
															</e>
															<e>
																<st>WS 003</st>
																<st>flak</st>
															</e>
															<e>
																<st>WS 011</st>
																<st>flak</st>
															</e>
															<e>
																<st>WS 022</st>
																<st>annihilatorpod</st>
															</e>
															<e>
																<st>WS 012</st>
																<st>hveldriver</st>
															</e>
															<e>
																<st>WS 023</st>
																<st>annihilatorpod</st>
															</e>
															<e>
																<st>WS 001</st>
																<st>flak</st>
															</e>
															<e>
																<st>WS 020</st>
																<st>devastator</st>
															</e>
															<e>
																<st>WS 010</st>
																<st>flak</st>
															</e>
															<e>
																<st>WS 021</st>
																<st>annihilatorpod</st>
															</e>
														</wpn>
														<sM z="105883"/>
														<wng z="105884"/>
														<wG z="105885">
															<WGSpec z="105886" t="LINKED" a="false">
																<s z="105887">
																	<st>WS 017</st>
																	<st>WS 016</st>
																</s>
															</WGSpec>
															<WGSpec z="105888" t="ALTERNATING" a="false">
																<s z="105889">
																	<st>WS 024</st>
																	<st>WS 022</st>
																	<st>WS 023</st>
																	<st>WS 021</st>
																</s>
															</WGSpec>
															<WGSpec z="105890" t="LINKED" a="true">
																<s z="105891">
																	<st>WS 019</st>
																</s>
															</WGSpec>
															<WGSpec z="105892" t="LINKED" a="true">
																<s z="105893">
																	<st>WS 008</st>
																	<st>WS 009</st>
																	<st>WS 015</st>
																	<st>WS 014</st>
																</s>
															</WGSpec>
															<WGSpec z="105894" t="LINKED" a="true">
																<s z="105895">
																	<st>WS 013</st>
																	<st>WS 012</st>
																</s>
															</WGSpec>
															<WGSpec z="105896" t="LINKED" a="true">
																<s z="105897">
																	<st>WS 018</st>
																	<st>WS 020</st>
																</s>
															</WGSpec>
															<WGSpec z="105898" t="LINKED" a="true">
																<s z="105899">
																	<st>WS 006</st>
																	<st>WS 007</st>
																	<st>WS 004</st>
																	<st>WS 005</st>
																	<st>WS 002</st>
																	<st>WS 003</st>
																	<st>WS 011</st>
																	<st>WS 001</st>
																	<st>WS 010</st>
																</s>
															</WGSpec>
														</wG>
														<hM z="105900">
															<st>hbi</st>
															<st>rat_controller</st>
															<st>solar_shielding</st>
															<st>augmentedengines</st>
															<st>efficiency_overhaul</st>
															<st>insulatedengine</st>
															<st>armoredweapons</st>
															<st>targetingunit</st>
															<st>auxiliarythrusters</st>
															<st>fluxdistributor</st>
															<st>progsmod_xptracker</st>
														</hM>
														<pM z="105901">
															<st>progsmod_xptracker</st>
														</pM>
														<sMods z="105902"/>
														<sModdedBuiltIns z="105903"/>
														<suM z="105904"/>
														<tags z="105905">
															<st>ship_recoverable</st>
														</tags>
													</savedVariant>
													<rT z="105906" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105880"/>
													</rT>
													<buffManager z="105907">
														<member ref="105880"/>
														<buffs cl="linked-list" z="105908">
															<aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff z="105909">
																<id>ash_supplies_recycler</id>
																<statValue>0.84745765</statValue>
															</aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff>
														</buffs>
													</buffManager>
													<fD ref="105178"/>
												</FMmbr>
												<FMmbr z="105910" o="0" sid="missp_nebula_lander_Standard" sN="ISS Gorey Castle" t="SHIP" iF="false" id="5fc3fa" sUN="false" civ="false" cCiv="false">
													<savedVariant z="105911" hId="missp_nebula_lander_default_D" v="0" c="0" hVId="missp_nebula_lander_Standard" vDN="Standard" s="REFIT" mAAW="false" gV="false">
														<wpn z="105912"/>
														<sM z="105913"/>
														<wng z="105914"/>
														<wG z="105915"/>
														<hM z="105916">
															<st>ground_support</st>
															<st>rat_controller</st>
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>erratic_injector</st>
															<st>degraded_drive_field</st>
															<st>increased_maintenance</st>
														</hM>
														<pM z="105917">
															<st>progsmod_xptracker</st>
															<st>sun_sl_notable</st>
															<st>erratic_injector</st>
															<st>degraded_drive_field</st>
															<st>increased_maintenance</st>
														</pM>
														<sMods z="105918"/>
														<sModdedBuiltIns z="105919"/>
														<suM z="105920"/>
														<tags z="105921">
															<st>ship_recoverable</st>
														</tags>
													</savedVariant>
													<rT z="105922" cr="0.0" crPTM="0.0" sR="false" mo="true" lCR="false">
														<m ref="105910"/>
													</rT>
													<buffManager z="105923">
														<member ref="105910"/>
														<buffs cl="linked-list" z="105924">
															<aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff z="105925">
																<id>ash_supplies_recycler</id>
																<statValue>0.84745765</statValue>
															</aptlysimplehullmods.plugins.SuppliesRecyclerScript_-SuppliesRecyclerBuff>
														</buffs>
													</buffManager>
													<fD ref="105178"/>
												</FMmbr>
											</m>
										</mS>
									</c>
									<iGR z="105926" serialization="custom">
										<Random>
											<default>
												<s>165773482863766</s>
												<n>0.0</n>
												<h>false</h>
											</default>
										</Random>
									</iGR>
								</p>
								<f ref="1031"/>
							</Submarket>
						</submarkets>
						<memory cl="Memory" z="105927">
							<d z="105928">
								<e>
									<st>$visitedBefore</st>
									<bp>true</bp>
								</e>
								<e>
									<st>$mc:abandoned_station</st>
									<bp>true</bp>
								</e>
								<e>
									<st>$id</st>
									<st>corvus_abandoned_station_market</st>
								</e>
								<e>
									<st>$size</st>
									<ip>0</ip>
								</e>
								<e>
									<st>$stability</st>
									<ip>0</ip>
								</e>
								<e>
									<st>$isSurveyed</st>
									<bp>true</bp>
								</e>
								<e>
									<st>$surveyLevel</st>
									<st>FULL</st>
								</e>
								<e>
									<st>$isPlanetConditionMarketOnly</st>
									<bp>false</bp>
								</e>
								<e>
									<st>$isHidden</st>
									<bp>false</bp>
								</e>
								<e>
									<st>$isPlayerOwned</st>
									<bp>false</bp>
								</e>
								<e>
									<st>$hasUnexploredRuins</st>
									<bp>false</bp>
								</e>
								<e>
									<st>$smugglingSuspicion</st>
									<fp>0.0</fp>
								</e>
								<e>
									<st>$alertLevel</st>
									<fp>0.0</fp>
								</e>
								<e>
									<st>$nex_isTruePlayerOwned</st>
									<bp>false</bp>
								</e>
								<e>
									<st>$MarketCMD_temp</st>
									<com.fs.starfarer.api.impl.campaign.rulecmd.salvage.MarketCMD_-TempData z="105929">
										<canRaid>false</canRaid>
										<canBombard>false</canBombard>
										<bombardCost>0</bombardCost>
										<marinesLost>0</marinesLost>
										<raidMult>0.0</raidMult>
										<attackerStr>0.0</attackerStr>
										<defenderStr>0.0</defenderStr>
										<nonMarket>false</nonMarket>
										<secret>false</secret>
										<xpGained>0</xpGained>
										<willBecomeHostile z="105930"/>
										<bombardmentTargets z="105931"/>
										<objectives z="105932"/>
									</com.fs.starfarer.api.impl.campaign.rulecmd.salvage.MarketCMD_-TempData>
								</e>
								<e>
									<st>$core_freePortMC</st>
									<null/>
								</e>
							</d>
							<e z="105933">
								<MExp z="105934" k="$mc:abandoned_station" t="0.0"/>
								<MExp z="105935" k="$id" t="0.0"/>
								<MExp z="105936" k="$size" t="0.0"/>
								<MExp z="105937" k="$stability" t="0.0"/>
								<MExp z="105938" k="$isSurveyed" t="0.0"/>
								<MExp z="105939" k="$surveyLevel" t="0.0"/>
								<MExp z="105940" k="$isPlanetConditionMarketOnly" t="0.0"/>
								<MExp z="105941" k="$isHidden" t="0.0"/>
								<MExp z="105942" k="$isPlayerOwned" t="0.0"/>
								<MExp z="105943" k="$hasUnexploredRuins" t="0.0"/>
								<MExp z="105944" k="$smugglingSuspicion" t="0.0"/>
								<MExp z="105945" k="$alertLevel" t="0.0"/>
								<MExp z="105946" k="$nex_isTruePlayerOwned" t="0.0"/>
								<MExp z="105947" k="$MarketCMD_temp" t="0.0"/>
								<MExp z="105948" k="$core_freePortMC" t="0.0"/>
							</e>
						</memory>
						<stats z="105949">
							<dynamic z="105950">
								<stats z="105951"/>
								<mods z="105952"/>
							</dynamic>
						</stats>
						<isPlanetConditionMarketOnly>false</isPlanetConditionMarketOnly>
						<accessibilityMod z="105953" fB="0.0" m="1.0" pM="0.0" nR="false"/>
						<incomeMult z="105954" b="1.0" m="1.0"/>
						<upkeepMult z="105955" b="1.0" m="1.0"/>
						<useStockpilesForShortages>false</useStockpilesForShortages>
						<industries z="105956"/>
						<playerOwned>false</playerOwned>
						<hasSpaceport>false</hasSpaceport>
						<hasWaystation>false</hasWaystation>
						<immigrationModifiers z="105957"/>
						<allowImport>true</allowImport>
						<allowExport>true</allowExport>
						<incentiveCredits>0.0</incentiveCredits>
						<constructionQueue z="105958">
							<items z="105959"/>
						</constructionQueue>
						<commDirectory z="105960">
							<entries z="105961"/>
						</commDirectory>
						<people z="105962">
							<Person z="105963" id="p_454296" pid="steady" spr="graphics/portraits/portrait_generic_grayscale.png" rnk="spaceCommander" pst="fleetCommander" wTCRC="0" cW="1.0" fid="neutral" a="false" im="MEDIUM">
								<n z="105964" f="" l="" g="ANY"/>
								<stats z="105965" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0"/>
								<market cl="Market" ref="105162"/>
							</Person>
						</people>
						<admin ref="105963"/>
						<prevStability>-1.0</prevStability>
						<daysInExistence>0.0</daysInExistence>
						<connectedEntities z="105966">
							<CCEnt ref="105156"/>
						</connectedEntities>
						<conditions z="105967">
							<MCon z="105968" i="abandoned_station" u="2a" s="true">
								<m cl="Market" ref="105162"/>
							</MCon>
						</conditions>
						<surveyLevel>FULL</surveyLevel>
						<forceNoConvertOnSave>false</forceNoConvertOnSave>
						<isFreePort>false</isFreePort>
					</market>
					<sc z="105969"/>
					<cV z="105970" sn="graphics/illustrations/abandoned_station2.jpg" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
					<tags z="105971">
						<st>station</st>
					</tags>
					<j1>{"f0":60,"f1":60,"f2":50,"f3":-1,"f4":-1,"f5":"station_side06"}</j1>
					<la z="105972" enum-type="CaEnLa">STATIONS</la>
				</CCEnt>
				<CCEnt z="105973" fL="STATIONS">
					<loc z="105974">-2736.4297|593.2556</loc>
					<vel z="105975">0.0|0.0</vel>
					<j0>{"f6":167.76764,"f0":"Asharu Stellar Shade","f2":[255,255,255,255],"f3":"stellar_shade","f4":"asharu_shade"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbtPD" z="105976" r="2800.0" op="100.0" ca="167.76764">
						<e cl="CCEnt" ref="105973"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="105977">
						<d z="105978"/>
					</me>
					<sc z="105979"/>
					<cV z="105980" sn="graphics/illustrations/orbital_shade.jpg" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
					<tags z="105981">
						<st>stellar_shade</st>
						<st>neutrino</st>
						<st>has_interaction_dialog</st>
					</tags>
					<j1>{"f0":50,"f1":50,"f2":36,"f3":-1,"f4":-1,"f5":"stellar_shade"}</j1>
					<la z="105982" enum-type="CaEnLa">STATIONS</la>
				</CCEnt>
				<Plnt ref="104181"/>
				<CCEnt z="105983" fL="STATIONS">
					<loc z="105984">-421.19714|-4823.3945</loc>
					<vel z="105985">0.0|0.0</vel>
					<j0>{"f6":247.36932,"f0":"Jangala Station","f2":[255,255,255,255],"f3":"station_jangala","f4":"corvus_hegemony_station"}</j0>
					<ow ref="873"/>
					<orbit cl="COrbtPD" z="105986" r="360.0" op="30.0" ca="247.36932">
						<e cl="CCEnt" ref="105983"/>
						<f cl="Plnt" ref="104181"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="105987">
						<d z="105988">
							<e>
								<st>$stationFleet</st>
								<st>enRef_8c9e</st>
							</e>
						</d>
					</me>
					<market cl="Market" ref="103808"/>
					<sc z="105989"/>
					<cV z="105990" sn="graphics/illustrations/jangala_station.jpg" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
					<tags z="105991">
						<st>station</st>
					</tags>
					<j1>{"f0":120,"f1":120,"f2":90,"f3":-1,"f4":-1,"f5":"station_jangala_type"}</j1>
					<la z="105992" enum-type="CaEnLa">STATIONS</la>
				</CCEnt>
				<CCEnt z="105993" fL="STATIONS">
					<loc z="105994">-4030.9297|-2000.4017</loc>
					<vel z="105995">0.0|0.0</vel>
					<j0>{"f6":206.3935,"f0":"Jangala Relay","f2":[255,255,255,255],"f3":"comm_relay","f4":"corvus_relay"}</j0>
					<ow ref="873"/>
					<orbit cl="COrbtPD" z="105996" r="4500.0" op="200.0" ca="206.3935">
						<e cl="CCEnt" ref="105993"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="105997">
						<d z="105998"/>
					</me>
					<sc z="105999"/>
					<cV z="106000" sn="graphics/illustrations/comm_relay.jpg" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
					<tags z="106001">
						<st>comm_relay</st>
						<st>neutrino_high</st>
						<st>objective</st>
					</tags>
					<j1>{"f0":89,"f1":48,"f2":75,"f3":-1,"f4":-1,"f5":"comm_relay"}</j1>
					<la z="106002" enum-type="CaEnLa">STATIONS</la>
					<p cl="CommRelayEP" z="106003">
						<e cl="CCEnt" ref="105993"/>
					</p>
				</CCEnt>
				<JumpPoint z="106004" r="50.0" dSC="misc" dSI="wormhole_hyper" sO="1245.3271">
					<loc z="106005">3747.657|-2490.9973</loc>
					<vel z="106006">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Jangala Jump-point","f2":[255,255,255,255],"f4":"jangala_jump"}</j0>
					<ow ref="93"/>
					<orbit cl="COrbt" z="106007" r="4500.0" op="200.0" ca="326.3888">
						<e cl="JumpPoint" ref="106004"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106008">
						<d z="106009"/>
					</me>
					<sc z="106010"/>
					<tags z="106011">
						<st>jump_point</st>
					</tags>
					<dst z="106012">
						<JumpDestination z="106013" l="hyperspace" minD="0.0" maxD="0.0">
							<d cl="JumpPoint" z="106014" r="85.0" dSC="misc" dSI="wormhole_stars" sO="42.699993">
								<loc z="106015">820.4482|-9672.901</loc>
								<vel z="106016">0.0|0.0</vel>
								<j0>{"f6":0,"f0":"Jangala Jump-point","f2":[255,255,255,255],"f4":"49"}</j0>
								<ow ref="93"/>
								<orbit cl="UpdateFromSystemLocationOrbit" z="106017" oR="501.25" lI="1.44" e="0.0">
									<sP cl="LocationToken" z="106018">
										<loc z="106019">400.0|-9400.0</loc>
										<where cl="Hyperspace" ref="2"/>
										<orbit cl="UFHLOrbt" z="106020">
											<s cl="Sstm" ref="104188"/>
											<a cl="LocationToken" ref="106018"/>
										</orbit>
										<id>46</id>
										<faction ref="13"/>
										<tags z="106021">
											<st>system_anchor</st>
										</tags>
										<memory z="106022">
											<d z="106023">
												<e>
													<st>$anchor_starSystem</st>
													<Sstm ref="104188"/>
												</e>
											</d>
										</memory>
									</sP>
									<s cl="Plnt" ref="104185"/>
									<iSE cl="JumpPoint" ref="106004"/>
									<iH cl="JumpPoint" ref="106014"/>
									<p z="106024">820.4482|-9672.901</p>
									<l z="106025">818.9457|-9675.202</l>
								</orbit>
								<cL cl="Hyperspace" ref="2"/>
								<me z="106026">
									<d z="106027"/>
								</me>
								<sc z="106028"/>
								<tags z="106029">
									<st>jump_point</st>
								</tags>
								<dst z="106030">
									<JumpDestination z="106031" l="Jangala Jump-point" minD="0.0" maxD="0.0">
										<d cl="JumpPoint" ref="106004"/>
									</JumpDestination>
								</dst>
								<dP ref="104181"/>
								<f z="106032" b="1.0" i="1.0" o="1.0" s="IDLE" d="false" u="false"/>
								<layers z="106033" enum-type="CaEnLa">JUMP_POINTS</layers>
							</d>
						</JumpDestination>
					</dst>
					<rP ref="104181"/>
					<f z="106034" b="1.0" i="1.0" o="1.0" s="IDLE" d="false" u="false"/>
					<layers z="106035" enum-type="CaEnLa">JUMP_POINTS</layers>
				</JumpPoint>
				<CCEnt z="106036" fL="STATIONS">
					<loc z="106037">5863.086|1274.4498</loc>
					<vel z="106038">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Corvus Gate","f2":[255,255,255,255],"f3":"inactive_gate","f4":"jangala_gate"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="106039" r="6000.0" op="350.0" ca="12.263519">
						<e cl="CCEnt" ref="106036"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106040">
						<d z="106041"/>
					</me>
					<sc z="106042"/>
					<cV z="106043" sn="graphics/illustrations/dead_gate.jpg" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
					<tags z="106044">
						<st>gate</st>
						<st>neutrino</st>
					</tags>
					<j1>{"f0":192,"f1":192,"f2":120,"f3":-1,"f4":-1,"f5":"inactive_gate"}</j1>
					<la z="106045" enum-type="CaEnLa">BELOW_STATIONS,STATIONS</la>
					<p cl="GateEntityPlugin" z="106046" mA="false" aI="true" sBUD="0.0" aTDLY="0.0" iUA="0.0">
						<e cl="CCEnt" ref="106036"/>
						<bUF z="106047" b="0.0" i="1.0" o="1.0" s="IDLE" d="true" u="false"/>
						<gF z="106048" b="0.0" i="1.0" o="1.0" s="IDLE" d="true" u="true"/>
					</p>
				</CCEnt>
				<CampaignTerrain z="106049" type="asteroid_belt" radius="0.0">
					<loc z="106050">0.0|0.0</loc>
					<vel z="106051">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"2d"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="106052" r="0.0" op="100.0" ca="0.0">
						<e cl="CampaignTerrain" ref="106049"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106053">
						<d z="106054"/>
					</me>
					<sc z="106055"/>
					<tags z="106056">
						<st>terrain</st>
					</tags>
					<plugin cl="AsteroidBeltTerrainPlugin" z="106057" tid="asteroid_belt" n="Nemo's Belt" nTCA="false">
						<entity cl="CampaignTerrain" ref="106049"/>
						<params cl="AsteroidBeltParams" defined-in="BaseRingTerrain" z="106058" bWIE="500.0" mR="5650.0" n="Nemo's Belt" nA="90" minO="150.0" maxO="300.0" minS="4.0" maxS="16.0"/>
						<params ref="106058"/>
					</plugin>
				</CampaignTerrain>
				<RingBand z="106059">
					<loc z="106060">0.0|0.0</loc>
					<vel z="106061">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Null","f2":[255,255,255,255],"f4":"2e"}</j0>
					<ow ref="93"/>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106062">
						<d z="106063"/>
					</me>
					<sc z="106064"/>
					<j1>{"f6":-3218.5547,"f7":"misc","f8":"rings_dust0","f10":0,"f11":2,"f0":256,"f1":3,"f2":[255,255,255,255],"f3":256,"f4":305,"f5":5600}</j1>
					<focus cl="Plnt" ref="104185"/>
					<layers z="106065" enum-type="CaEnLa">RINGS</layers>
				</RingBand>
				<RingBand z="106066">
					<loc z="106067">0.0|0.0</loc>
					<vel z="106068">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Null","f2":[255,255,255,255],"f4":"2f"}</j0>
					<ow ref="93"/>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106069">
						<d z="106070"/>
					</me>
					<sc z="106071"/>
					<j1>{"f6":-3357.5386,"f7":"misc","f8":"rings_asteroids0","f10":0,"f11":2,"f0":256,"f1":3,"f2":[255,255,255,255],"f3":256,"f4":295,"f5":5720}</j1>
					<focus cl="Plnt" ref="104185"/>
					<layers z="106072" enum-type="CaEnLa">RINGS</layers>
				</RingBand>
				<Plnt z="106073">
					<loc z="106074">-2759.83|7295.4326</loc>
					<vel z="106075">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Barad","f2":[255,255,255,255],"f4":"barad"}</j0>
					<ow ref="93"/>
					<orbit cl="COrbt" z="106076" r="7800.0" op="400.0" ca="110.721405">
						<e cl="Plnt" ref="106073"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106077">
						<d z="106078">
							<e>
								<st>$salvageSeed</st>
								<Lp>-9086376478329049517</Lp>
							</e>
						</d>
					</me>
					<market cl="PCMarket" z="106079">
						<id>market_barad</id>
						<name>Barad</name>
						<primaryEntity cl="Plnt" ref="106073"/>
						<surveyLevel>FULL</surveyLevel>
						<cond z="106080">
							<st>volatiles_diffuse</st>
							<st>high_gravity</st>
							<st>extreme_weather</st>
						</cond>
						<surveyed z="106081">
							<st>volatiles_diffuse</st>
							<st>high_gravity</st>
							<st>extreme_weather</st>
						</surveyed>
					</market>
					<sc z="106082"/>
					<tags z="106083">
						<st>planet</st>
						<st>gas_giant</st>
					</tags>
					<angle>146.38681</angle>
					<cloudAngle>310.7096</cloudAngle>
					<radius>300.0</radius>
					<type>gas_giant</type>
					<layers z="106084" enum-type="CaEnLa">PLANETS,ABOVE</layers>
				</Plnt>
				<CampaignTerrain z="106085" type="magnetic_field" radius="0.0">
					<loc z="106086">-2759.83|7295.4326</loc>
					<vel z="106087">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"30"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="106088" r="0.0" op="100.0" ca="0.0">
						<e cl="CampaignTerrain" ref="106085"/>
						<f cl="Plnt" ref="106073"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106089">
						<d z="106090"/>
					</me>
					<sc z="106091"/>
					<tags z="106092">
						<st>terrain</st>
					</tags>
					<plugin cl="MagneticFieldTerrainPlugin" z="106093" tid="magnetic_field" n="Magnetic Field">
						<e cl="CampaignTerrain" ref="106085"/>
						<params cl="MagneticFieldParams" defined-in="BaseRingTerrain" z="106094" bWIE="500.0" mR="250.0" c="ff8c64eb|ffb46ed2|ff968cbe|ff8cbed2|ff5ac8aa|ff41e6a0|ff14dc46" aF="0.5" iR="350.0" oR="600.0">
							<e cl="Plnt" ref="106073"/>
							<bC z="106095">50,20,100,40</bC>
						</params>
						<r z="106096" a="23.844818">
							<d cl="MagneticFieldTerrainPlugin" ref="106093"/>
						</r>
						<params ref="106094"/>
						<fM z="106097">
							<fT z="106098" i="0.5" a="1.5" c="1.2342246" e="0.654" ie="false"/>
							<f z="106099">
								<Flare z="106100" d="218.12598" a="18.565681" eLM="1.0" eLF="0.0" sFM="0.8" c="ff5ac8aa|ff41e6a0|ff14dc46">
									<f z="106101" b="0.70442873" i="0.92841184" o="0.96192217" s="IN" d="true" u="false"/>
								</Flare>
								<Flare z="106102" d="209.02032" a="14.250005" eLM="1.0" eLF="0.0" sFM="0.8" c="ff5ac8aa|ff41e6a0|ff14dc46">
									<f z="106103" b="0.0" i="0.8242984" o="0.65943" s="IDLE" d="true" u="false"/>
								</Flare>
								<Flare z="106104" d="224.98254" a="14.531297" eLM="1.0" eLF="0.0" sFM="0.8" c="ff968cbe|ff8cbed2|ff5ac8aa|ff41e6a0|ff14dc46">
									<f z="106105" b="0.0" i="0.9636985" o="0.7162611" s="IDLE" d="true" u="false"/>
								</Flare>
								<Flare z="106106" d="229.3886" a="15.14771" eLM="1.0" eLF="0.0" sFM="0.8" c="ff41e6a0|ff14dc46">
									<f z="106107" b="0.0" i="0.73698294" o="0.52058154" s="IDLE" d="true" u="false"/>
								</Flare>
								<Flare z="106108" d="205.66745" a="10.554608" eLM="1.0" eLF="0.0" sFM="0.8" c="ff8cbed2|ff5ac8aa|ff41e6a0|ff14dc46">
									<f z="106109" b="0.0" i="0.6362522" o="0.75857294" s="IDLE" d="true" u="false"/>
								</Flare>
								<Flare z="106110" d="218.50204" a="44.137024" eLM="1.0" eLF="0.0" sFM="0.8" c="ff968cbe|ff8cbed2|ff5ac8aa|ff41e6a0|ff14dc46">
									<f z="106111" b="0.0" i="1.5153948" o="3.571968" s="IDLE" d="true" u="false"/>
								</Flare>
							</f>
							<d cl="MagneticFieldTerrainPlugin" ref="106093"/>
						</fM>
					</plugin>
				</CampaignTerrain>
				<Plnt z="106112">
					<loc z="106113">-1985.4283|7139.2217</loc>
					<vel z="106114">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Garnir","f2":[255,255,255,255],"f3":"planet_barad_a","f4":"corvus_IIIa"}</j0>
					<ow ref="1899"/>
					<orbit cl="COrbt" z="106115" r="790.0" op="20.0" ca="348.59546">
						<e cl="Plnt" ref="106112"/>
						<f cl="Plnt" ref="106073"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106116">
						<d z="106117">
							<e>
								<st>$salvageSeed</st>
								<Lp>446220626288858829</Lp>
							</e>
							<e>
								<st>$illustrated_entity_image</st>
								<ip>146</ip>
							</e>
						</d>
					</me>
					<market cl="Market" z="106118">
						<id>corvus_IIIa</id>
						<name>Garnir</name>
						<commodities z="106119">
							<COMkt z="106120" c="supplies" sto="2151.2346" mS="0" iSL="true" mD="3" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106121" b="0.0" m="633.3704">
									<fMs z="106122" s="core" v="633.3704"/>
								</g>
								<d z="106123" dC="supplies">
									<d z="106124" b="0.0" m="1900.1113">
										<fMs z="106125" s="core" v="1900.1113"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106126" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106127" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106128" b="0.0" m="3.0">
									<fMs z="106129" s="core_base" d="Desired import volume (in-faction)" v="3.0"/>
								</available>
								<tradeMod z="106130" b="0.0" m="0.0"/>
								<tradeModPlus z="106131" b="0.0" m="0.0"/>
								<tradeModMinus z="106132" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106133" c="fuel" sto="1480.3895" mS="0" iSL="true" mD="1" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106134" b="0.0" m="433.23224">
									<fMs z="106135" s="core" v="433.23224"/>
								</g>
								<d z="106136" dC="fuel">
									<d z="106137" b="0.0" m="1299.6968">
										<fMs z="106138" s="core" v="1299.6968"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106139" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106140" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106141" b="0.0" m="1.0">
									<fMs z="106142" s="core_base" d="Desired import volume (in-faction)" v="1.0"/>
								</available>
								<tradeMod z="106143" b="0.0" m="0.0"/>
								<tradeModPlus z="106144" b="0.0" m="0.0"/>
								<tradeModMinus z="106145" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106146" c="crew" sto="1548.6475" mS="2" iSL="true" mD="0" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106147" b="0.0" m="294.403">
									<fMs z="106148" s="core" v="294.403"/>
								</g>
								<d z="106149" dC="crew">
									<d z="106150" b="0.0" m="883.20905">
										<fMs z="106151" s="core" v="883.20905"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106152" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106153" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106154" b="0.0" m="2.0">
									<fMs z="106155" s="core_local" d="Local production" v="2.0"/>
								</available>
								<tradeMod z="106156" b="0.0" m="0.0"/>
								<tradeModPlus z="106157" b="0.0" m="0.0"/>
								<tradeModMinus z="106158" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106159" c="marines" sto="286.70673" mS="0" iSL="true" mD="3" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106160" b="0.0" m="127.589134">
									<fMs z="106161" s="core" v="127.589134"/>
								</g>
								<d z="106162" dC="marines">
									<d z="106163" b="0.0" m="382.7674">
										<fMs z="106164" s="core" v="382.7674"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106165" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106166" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106167" b="0.0" m="3.0">
									<fMs z="106168" s="core_base" d="Desired import volume (in-faction)" v="3.0"/>
								</available>
								<tradeMod z="106169" b="0.0" m="0.0"/>
								<tradeModPlus z="106170" b="0.0" m="0.0"/>
								<tradeModMinus z="106171" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106172" c="food" sto="8309.3545" mS="0" iSL="true" mD="4" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106173" b="0.0" m="2004.8033">
									<fMs z="106174" s="core" v="2004.8033"/>
								</g>
								<d z="106175" dC="food">
									<d z="106176" b="0.0" m="6014.41">
										<fMs z="106177" s="core" v="6014.41"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106178" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106179" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106180" b="0.0" m="4.0">
									<fMs z="106181" s="core_base" d="Desired import volume (in-faction)" v="4.0"/>
								</available>
								<tradeMod z="106182" b="0.0" m="0.0"/>
								<tradeModPlus z="106183" b="0.0" m="0.0"/>
								<tradeModMinus z="106184" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106185" c="organics" sto="3091.424" mS="0" iSL="true" mD="2" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106186" b="0.0" m="768.777">
									<fMs z="106187" s="core" v="768.777"/>
								</g>
								<d z="106188" dC="organics">
									<d z="106189" b="0.0" m="2306.331">
										<fMs z="106190" s="core" v="2306.331"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106191" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106192" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106193" b="0.0" m="2.0">
									<fMs z="106194" s="core_base" d="Desired import volume" v="2.0"/>
								</available>
								<tradeMod z="106195" b="0.0" m="0.0"/>
								<tradeModPlus z="106196" b="0.0" m="0.0"/>
								<tradeModMinus z="106197" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106198" c="volatiles" sto="1078.002" mS="3" iSL="true" mD="0" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106199" b="0.0" m="193.4522">
									<fMs z="106200" s="core" v="193.4522"/>
								</g>
								<d z="106201" dC="volatiles">
									<d z="106202" b="0.0" m="580.35657">
										<fMs z="106203" s="core" v="580.35657"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106204" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106205" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106206" b="0.0" m="3.0">
									<fMs z="106207" s="core_local" d="Local production" v="3.0"/>
								</available>
								<tradeMod z="106208" b="0.0" m="0.0"/>
								<tradeModPlus z="106209" b="0.0" m="0.0"/>
								<tradeModMinus z="106210" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106211" c="domestic_goods" sto="1914.5217" mS="0" iSL="true" mD="2" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106212" b="0.0" m="574.65265">
									<fMs z="106213" s="core" v="574.65265"/>
								</g>
								<d z="106214" dC="domestic_goods">
									<d z="106215" b="0.0" m="1723.958">
										<fMs z="106216" s="core" v="1723.958"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106217" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106218" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106219" b="0.0" m="2.0">
									<fMs z="106220" s="core_base" d="Desired import volume (in-faction)" v="2.0"/>
								</available>
								<tradeMod z="106221" b="0.0" m="0.0"/>
								<tradeModPlus z="106222" b="0.0" m="0.0"/>
								<tradeModMinus z="106223" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106224" c="drugs" sto="1158.3495" mS="0" iSL="true" mD="3" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106225" b="0.0" m="366.25366">
									<fMs z="106226" s="core" v="366.25366"/>
								</g>
								<d z="106227" dC="drugs">
									<d z="106228" b="0.0" m="1098.761">
										<fMs z="106229" s="core" v="1098.761"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106230" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106231" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106232" b="0.0" m="3.0">
									<fMs z="106233" s="core_base" d="Desired import volume (in-faction)" v="3.0"/>
								</available>
								<tradeMod z="106234" b="0.0" m="0.0"/>
								<tradeModPlus z="106235" b="0.0" m="0.0"/>
								<tradeModMinus z="106236" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106237" c="hand_weapons" sto="201.61574" mS="0" iSL="true" mD="1" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106238" b="0.0" m="98.63359">
									<fMs z="106239" s="core" v="98.63359"/>
								</g>
								<d z="106240" dC="hand_weapons">
									<d z="106241" b="0.0" m="295.90076">
										<fMs z="106242" s="core" v="295.90076"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106243" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106244" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106245" b="0.0" m="1.0">
									<fMs z="106246" s="core_base" d="Desired import volume (in-faction)" v="1.0"/>
								</available>
								<tradeMod z="106247" b="0.0" m="0.0"/>
								<tradeModPlus z="106248" b="0.0" m="0.0"/>
								<tradeModMinus z="106249" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106250" c="ships" sto="202.38884" mS="0" iSL="true" mD="1" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106251" b="0.0" m="104.33034">
									<fMs z="106252" s="core" v="104.33034"/>
								</g>
								<d z="106253" dC="ships">
									<d z="106254" b="0.0" m="312.99103">
										<fMs z="106255" s="core" v="312.99103"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106256" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106257" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106258" b="0.0" m="1.0">
									<fMs z="106259" s="core_base" d="Desired import volume (in-faction)" v="1.0"/>
								</available>
								<tradeMod z="106260" b="0.0" m="0.0"/>
								<tradeModPlus z="106261" b="0.0" m="0.0"/>
								<tradeModMinus z="106262" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106263" c="water" sto="28836.887" mS="4" iSL="true" mD="0" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106264" b="0.0" m="5149.0054">
									<fMs z="106265" s="core" v="5149.0054"/>
								</g>
								<d z="106266" dC="water">
									<d z="106267" b="0.0" m="15447.016">
										<fMs z="106268" s="core" v="15447.016"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106269" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="106270" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106271" b="0.0" m="4.0">
									<fMs z="106272" s="core_local" d="Local production" v="4.0"/>
								</available>
								<tradeMod z="106273" b="0.0" m="0.0"/>
								<tradeModPlus z="106274" b="0.0" m="0.0"/>
								<tradeModMinus z="106275" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106276" c="biotics" sto="102.06142" mS="0" iSL="true" mD="1" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106277" b="0.0" m="72.23819">
									<fMs z="106278" s="core" v="72.23819"/>
								</g>
								<d z="106279" dC="biotics">
									<d z="106280" b="0.0" m="216.71457">
										<fMs z="106281" s="core" v="216.71457"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106282" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="106283" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106284" b="0.0" m="1.0">
									<fMs z="106285" s="core_base" d="Desired import volume (in-faction)" v="1.0"/>
								</available>
								<tradeMod z="106286" b="0.0" m="0.0"/>
								<tradeModPlus z="106287" b="0.0" m="0.0"/>
								<tradeModMinus z="106288" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106289" c="recitificates" sto="1013.0689" mS="0" iSL="true" mD="2" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106290" b="0.0" m="310.46014">
									<fMs z="106291" s="core" v="310.46014"/>
								</g>
								<d z="106292" dC="recitificates">
									<d z="106293" b="0.0" m="931.38043">
										<fMs z="106294" s="core" v="931.38043"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106295" fB="0.0" m="1.0" pM="0.0" nR="true"/>
								<pSM z="106296" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106297" b="0.0" m="2.0">
									<fMs z="106298" s="core_base" d="Desired import volume (in-faction)" v="2.0"/>
								</available>
								<tradeMod z="106299" b="0.0" m="0.0"/>
								<tradeModPlus z="106300" b="0.0" m="0.0"/>
								<tradeModMinus z="106301" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106302" c="alcoholism_blood_c" sto="478.69937" mS="0" iSL="true" mD="1" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106303" b="0.0" m="173.28773">
									<fMs z="106304" s="core" v="173.28773"/>
								</g>
								<d z="106305" dC="alcoholism_blood_c">
									<d z="106306" b="0.0" m="519.8632">
										<fMs z="106307" s="core" v="519.8632"/>
									</d>
									<m ref="106118"/>
								</d>
								<pDM z="106308" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106309" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106310" b="0.0" m="1.0">
									<fMs z="106311" s="core_base" d="Desired import volume (in-faction)" v="1.0"/>
								</available>
								<tradeMod z="106312" b="0.0" m="0.0"/>
								<tradeModPlus z="106313" b="0.0" m="0.0"/>
								<tradeModMinus z="106314" b="0.0" m="0.0"/>
							</COMkt>
							<COMkt z="106315" c="sotf_planetkiller" sto="0.0" mS="0" iSL="true" mD="1" iDL="true" eU="0.0">
								<m ref="106118"/>
								<g z="106316" b="0.0" m="98.63359">
									<fMs z="106317" s="core" v="98.63359"/>
								</g>
								<d ref="106240"/>
								<pDM z="106318" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<pSM z="106319" fB="0.0" m="1.0" pM="0.0" nR="false"/>
								<available z="106320" b="0.0" m="0.0"/>
								<tradeMod z="106321" b="0.0" m="0.0"/>
								<tradeModPlus z="106322" b="0.0" m="0.0"/>
								<tradeModMinus z="106323" b="0.0" m="0.0"/>
							</COMkt>
						</commodities>
						<demandData z="106324">
							<demand z="106325" dC="polymer">
								<d z="106326" b="0.0" m="534.86774">
									<fMs z="106327" s="core" v="534.86774"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106328" dC="rare_ore">
								<d z="106329" b="0.0" m="499.26608">
									<fMs z="106330" s="core" v="499.26608"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106331" dC="electronics">
								<d z="106332" b="0.0" m="299.55005">
									<fMs z="106333" s="core" v="299.55005"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106334" dC="alcoholism_water_c">
								<d z="106335" b="0.0" m="705.0073">
									<fMs z="106336" s="core" v="705.0073"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106337" dC="alcoholism_tea_c">
								<d z="106338" b="0.0" m="522.6625">
									<fMs z="106339" s="core" v="522.6625"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand ref="106214"/>
							<demand ref="106136"/>
							<demand ref="106305"/>
							<demand z="106340" dC="ms_hdbatteries">
								<d z="106341" b="0.0" m="224.86789">
									<fMs z="106342" s="core" v="224.86789"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106343" dC="metals">
								<d z="106344" b="0.0" m="1610.1392">
									<fMs z="106345" s="core" v="1610.1392"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand ref="106279"/>
							<demand ref="106149"/>
							<demand ref="106240"/>
							<demand z="106346" dC="vic_booze_c">
								<d z="106347" b="0.0" m="305.05893">
									<fMs z="106348" s="core" v="305.05893"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand ref="106123"/>
							<demand z="106349" dC="purified_rare_ore">
								<d z="106350" b="0.0" m="525.7644">
									<fMs z="106351" s="core" v="525.7644"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106352" dC="luxury_goods">
								<d z="106353" b="0.0" m="501.91644">
									<fMs z="106354" s="core" v="501.91644"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand ref="106188"/>
							<demand z="106355" dC="vic_genetech">
								<d z="106356" b="0.0" m="264.38892">
									<fMs z="106357" s="core" v="264.38892"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106358" dC="heavy_machinery">
								<d z="106359" b="0.0" m="358.47516">
									<fMs z="106360" s="core" v="358.47516"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106361" dC="alcoholism_stout_c">
								<d z="106362" b="0.0" m="537.7322">
									<fMs z="106363" s="core" v="537.7322"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106364" dC="alcoholism_sunshine_c">
								<d z="106365" b="0.0" m="528.0302">
									<fMs z="106366" s="core" v="528.0302"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106367" dC="IndEvo_parts">
								<d z="106368" b="0.0" m="361.206">
									<fMs z="106369" s="core" v="361.206"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106370" dC="alcoholism_absynth_c">
								<d z="106371" b="0.0" m="528.521">
									<fMs z="106372" s="core" v="528.521"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106373" dC="organs">
								<d z="106374" b="0.0" m="288.72095">
									<fMs z="106375" s="core" v="288.72095"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106376" dC="alcoholism_king_c">
								<d z="106377" b="0.0" m="538.4686">
									<fMs z="106378" s="core" v="538.4686"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106379" dC="ore">
								<d z="106380" b="0.0" m="3986.0933">
									<fMs z="106381" s="core" v="3986.0933"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand ref="106227"/>
							<demand z="106382" dC="alcoholism_tears_c">
								<d z="106383" b="0.0" m="516.64996">
									<fMs z="106384" s="core" v="516.64996"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106385" dC="alcoholism_freedom_c">
								<d z="106386" b="0.0" m="628.18585">
									<fMs z="106387" s="core" v="628.18585"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106388" dC="alcoholism_fuel_c">
								<d z="106389" b="0.0" m="500.44427">
									<fMs z="106390" s="core" v="500.44427"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand ref="106266"/>
							<demand z="106391" dC="compound">
								<d z="106392" b="0.0" m="543.29016">
									<fMs z="106393" s="core" v="543.29016"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand ref="106175"/>
							<demand z="106394" dC="purified_ore">
								<d z="106395" b="0.0" m="537.00525">
									<fMs z="106396" s="core" v="537.00525"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand ref="106253"/>
							<demand ref="106162"/>
							<demand ref="106292"/>
							<demand z="106397" dC="domain_artifacts">
								<d z="106398" b="0.0" m="291.20392">
									<fMs z="106399" s="core" v="291.20392"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106400" dC="rare_metals">
								<d z="106401" b="0.0" m="291.786">
									<fMs z="106402" s="core" v="291.786"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106403" dC="refined_metal">
								<d z="106404" b="0.0" m="527.2407">
									<fMs z="106405" s="core" v="527.2407"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand z="106406" dC="purified_rare_metal">
								<d z="106407" b="0.0" m="541.1207">
									<fMs z="106408" s="core" v="541.1207"/>
								</d>
								<m ref="106118"/>
							</demand>
							<demand ref="106201"/>
							<market ref="106118"/>
						</demandData>
						<size>3</size>
						<location z="106409">400.0|-9400.0</location>
						<demandPriceMod z="106410" fB="0.0" m="1.0" pM="0.0" nR="false"/>
						<supplyPriceMod z="106411" fB="0.0" m="1.0" pM="0.0" nR="false"/>
						<tariff z="106412" b="0.0" m="0.09">
							<fMs z="106413" s="default_tariff" v="0.3"/>
							<mMs z="106414" s="nexerelinMult" v="0.6"/>
							<mMs z="106415" s="nexerelin_freeMarket" v="0.5"/>
						</tariff>
						<factionId>pirates</factionId>
						<power z="106416" b="0.0" m="4.0">
							<fMs z="106417" s="free_market_3de0" d="Free port" v="-3.0"/>
							<fMs z="106418" s="_ind_population_3_ms" d="Base value" v="5.0"/>
							<fMs z="106419" s="ind_population_0" d="Domestic goods demand met" v="1.0"/>
							<fMs z="106420" s="ind_grounddefenses" d="Ground defenses" v="1.0"/>
						</power>
						<hazard z="106421" b="0.0" m="1.75">
							<fMs z="106422" s="haz_base" d="Base value" v="1.0"/>
							<fMs z="106423" s="no_atmosphere_3ddc" d="No Atmosphere" v="0.5"/>
							<fMs z="106424" s="cold_3dde" d="Cold" v="0.25"/>
						</hazard>
						<primaryEntity cl="Plnt" ref="106112"/>
						<submarkets z="106425">
							<Submarket z="106426" s="open_market">
								<m ref="106118"/>
								<p cl="NexOpnMkt" z="106427" mSWUI="30.0" msSWU="2.2618973" sLCU="0.0">
									<m cl="Market" ref="106118"/>
									<s cl="Submarket" ref="106426"/>
									<c cl="CargoData" z="106428" uS="true" mC="1000.0" sU="5305.306" mF="500.0" mP="750.0" fT="false">
										<s z="106429">
											<CIStack z="106430" rS="false" s="117.130356" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">supplies</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106431" rS="false" s="78.40646" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">fuel</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106432" rS="false" s="208.77283" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">crew</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106433" rS="false" s="15.234643" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">marines</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106434" rS="false" s="10.23325" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">hand_weapons</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106435" rS="false" s="62.173214" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">drugs</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106436" rS="false" s="103.8957" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">domestic_goods</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106437" rS="false" s="25.469286" mS="1000000.0" cSPU="0.5" t="RESOURCES">
												<d cl="st">alcoholism_blood_c</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106438" rS="false" s="125.34504" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">volatiles</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106439" rS="false" s="156.8143" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">organics</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106440" rS="false" s="417.75897" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">food</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106441" rS="false" s="4185.282" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">water</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106442" rS="false" s="5.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">biotics</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106443" rS="false" s="51.938572" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">recitificates</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106444" rS="true" s="5.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">wpnxt_minimortarbattery</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106445" rS="true" s="2.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">shredder</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106446" rS="true" s="1.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">heavymortar</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106447" rS="true" s="4.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">lightmg</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106448" rS="true" s="3.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">hammer_single</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106449" rS="true" s="3.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">wpnxt_miniblaster</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106450" rS="true" s="1.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">filgap_david</d>
												<c ref="106428"/>
											</CIStack>
											<CIStack z="106451" rS="true" s="3.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
												<d cl="st">talon_wing</d>
												<c ref="106428"/>
											</CIStack>
										</s>
										<c z="106452">
											<value>0.0</value>
										</c>
										<mS z="106453" nP="" nSf="pirates" nS="false" oSML="false">
											<m z="106454">
												<FMmbr z="106455" o="0" sid="filgap_pharos_Hull" sN="The Fantasy Jumper" t="SHIP" iF="false" id="71dadc" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106456" hId="filgap_pharos_default_D" v="0" c="0" hVId="filgap_pharos_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106457"/>
														<sM z="106458"/>
														<wng z="106459"/>
														<wG z="106460"/>
														<hM z="106461">
															<st>civgrade</st>
															<st>nav_relay</st>
															<st>erratic_injector</st>
															<st>increased_maintenance</st>
															<st>degraded_drive_field</st>
														</hM>
														<pM z="106462">
															<st>erratic_injector</st>
															<st>increased_maintenance</st>
															<st>degraded_drive_field</st>
														</pM>
														<sMods z="106463"/>
														<sModdedBuiltIns z="106464"/>
														<suM z="106465"/>
													</savedVariant>
													<rT z="106466" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106455"/>
													</rT>
													<fD ref="106453"/>
												</FMmbr>
												<FMmbr z="106467" o="0" sid="filgap_copernic_Hull" sN="Into the Void" t="SHIP" iF="false" id="71dace" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106468" hId="filgap_copernic_default_D" v="0" c="0" hVId="filgap_copernic_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106469"/>
														<sM z="106470"/>
														<wng z="106471">
															<st>filum_wing</st>
														</wng>
														<wG z="106472"/>
														<hM z="106473">
															<st>surveying_equipment</st>
															<st>solar_shielding</st>
															<st>civgrade</st>
															<st>faulty_auto</st>
															<st>fragile_subsystems</st>
															<st>erratic_injector</st>
															<st>degraded_life_support</st>
															<st>damaged_deck</st>
														</hM>
														<pM z="106474">
															<st>faulty_auto</st>
															<st>fragile_subsystems</st>
															<st>erratic_injector</st>
															<st>degraded_life_support</st>
															<st>damaged_deck</st>
														</pM>
														<sMods z="106475"/>
														<sModdedBuiltIns z="106476"/>
														<suM z="106477"/>
													</savedVariant>
													<rT z="106478" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106467"/>
													</rT>
													<fD ref="106453"/>
												</FMmbr>
												<FMmbr z="106479" o="0" sid="cerberus_Hull" sN="A Corpse at Large" t="SHIP" iF="false" id="71dab4" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106480" hId="cerberus_default_D" v="0" c="0" hVId="cerberus_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106481"/>
														<sM z="106482"/>
														<wng z="106483"/>
														<wG z="106484"/>
														<hM z="106485">
															<st>rugged</st>
															<st>shielded_holds</st>
															<st>erratic_injector</st>
															<st>faulty_auto</st>
															<st>damaged_mounts</st>
														</hM>
														<pM z="106486">
															<st>erratic_injector</st>
															<st>faulty_auto</st>
															<st>damaged_mounts</st>
														</pM>
														<sMods z="106487"/>
														<sModdedBuiltIns z="106488"/>
														<suM z="106489"/>
													</savedVariant>
													<rT z="106490" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106479"/>
													</rT>
													<fD ref="106453"/>
												</FMmbr>
												<FMmbr z="106491" o="0" sid="shepherd_Hull" sN="Chonchon" t="SHIP" iF="false" id="71dad0" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106492" hId="shepherd_default_D" v="0" c="0" hVId="shepherd_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106493"/>
														<sM z="106494"/>
														<wng z="106495">
															<st>borer_wing</st>
														</wng>
														<wG z="106496"/>
														<hM z="106497">
															<st>civgrade</st>
															<st>surveying_equipment</st>
															<st>repair_gantry</st>
															<st>comp_armor</st>
															<st>damaged_deck</st>
															<st>faulty_auto</st>
															<st>damaged_mounts</st>
															<st>faulty_grid</st>
														</hM>
														<pM z="106498">
															<st>comp_armor</st>
															<st>damaged_deck</st>
															<st>faulty_auto</st>
															<st>damaged_mounts</st>
															<st>faulty_grid</st>
														</pM>
														<sMods z="106499"/>
														<sModdedBuiltIns z="106500"/>
														<suM z="106501"/>
													</savedVariant>
													<rT z="106502" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106491"/>
													</rT>
													<fD ref="106453"/>
												</FMmbr>
												<FMmbr z="106503" o="0" sid="BSC_Tramp_MK2_Hull" sN="General Zapped an Angel" t="SHIP" iF="false" id="71dab6" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106504" hId="BSC_Tramp_MK2_default_D" v="0" c="0" hVId="BSC_Tramp_MK2_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106505"/>
														<sM z="106506"/>
														<wng z="106507"/>
														<wG z="106508"/>
														<hM z="106509">
															<st>civgrade</st>
															<st>increased_maintenance</st>
															<st>comp_armor</st>
															<st>damaged_mounts</st>
															<st>glitched_sensors</st>
														</hM>
														<pM z="106510">
															<st>increased_maintenance</st>
															<st>comp_armor</st>
															<st>damaged_mounts</st>
															<st>glitched_sensors</st>
														</pM>
														<sMods z="106511"/>
														<sModdedBuiltIns z="106512"/>
														<suM z="106513"/>
													</savedVariant>
													<rT z="106514" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106503"/>
													</rT>
													<fD ref="106453"/>
												</FMmbr>
												<FMmbr z="106515" o="0" sid="hermes_Hull" sN="Guardian Devil" t="SHIP" iF="false" id="71dab8" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106516" hId="hermes_default_D" v="0" c="0" hVId="hermes_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106517"/>
														<sM z="106518"/>
														<wng z="106519"/>
														<wG z="106520"/>
														<hM z="106521">
															<st>civgrade</st>
															<st>degraded_drive_field</st>
															<st>comp_storage</st>
															<st>erratic_injector</st>
															<st>increased_maintenance</st>
														</hM>
														<pM z="106522">
															<st>degraded_drive_field</st>
															<st>comp_storage</st>
															<st>erratic_injector</st>
															<st>increased_maintenance</st>
														</pM>
														<sMods z="106523"/>
														<sModdedBuiltIns z="106524"/>
														<suM z="106525"/>
													</savedVariant>
													<rT z="106526" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106515"/>
													</rT>
													<fD ref="106453"/>
												</FMmbr>
												<FMmbr z="106527" o="0" sid="kite_Hull" sN="Solar Wind" t="SHIP" iF="false" id="71daba" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106528" hId="kite_default_D" v="0" c="0" hVId="kite_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106529"/>
														<sM z="106530"/>
														<wng z="106531"/>
														<wG z="106532"/>
														<hM z="106533">
															<st>civgrade</st>
															<st>comp_armor</st>
															<st>increased_maintenance</st>
															<st>degraded_life_support</st>
														</hM>
														<pM z="106534">
															<st>comp_armor</st>
															<st>increased_maintenance</st>
															<st>degraded_life_support</st>
														</pM>
														<sMods z="106535"/>
														<sModdedBuiltIns z="106536"/>
														<suM z="106537"/>
													</savedVariant>
													<rT z="106538" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106527"/>
													</rT>
													<fD ref="106453"/>
												</FMmbr>
												<FMmbr z="106539" o="0" sid="mudskipper_Hull" sN="The Red Typhoon" t="SHIP" iF="false" id="71dabc" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106540" hId="mudskipper_default_D" v="0" c="0" hVId="mudskipper_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106541"/>
														<sM z="106542"/>
														<wng z="106543"/>
														<wG z="106544"/>
														<hM z="106545">
															<st>civgrade</st>
															<st>increased_maintenance</st>
															<st>degraded_drive_field</st>
															<st>comp_storage</st>
															<st>erratic_injector</st>
														</hM>
														<pM z="106546">
															<st>increased_maintenance</st>
															<st>degraded_drive_field</st>
															<st>comp_storage</st>
															<st>erratic_injector</st>
														</pM>
														<sMods z="106547"/>
														<sModdedBuiltIns z="106548"/>
														<suM z="106549"/>
													</savedVariant>
													<rT z="106550" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106539"/>
													</rT>
													<fD ref="106453"/>
												</FMmbr>
												<FMmbr z="106551" o="0" sid="mudskipper_Hull" sN="October Tide" t="SHIP" iF="false" id="71dabe" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106552" hId="mudskipper_default_D" v="0" c="0" hVId="mudskipper_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106553"/>
														<sM z="106554"/>
														<wng z="106555"/>
														<wG z="106556"/>
														<hM z="106557">
															<st>civgrade</st>
															<st>comp_storage</st>
															<st>degraded_drive_field</st>
															<st>erratic_injector</st>
															<st>increased_maintenance</st>
														</hM>
														<pM z="106558">
															<st>comp_storage</st>
															<st>degraded_drive_field</st>
															<st>erratic_injector</st>
															<st>increased_maintenance</st>
														</pM>
														<sMods z="106559"/>
														<sModdedBuiltIns z="106560"/>
														<suM z="106561"/>
													</savedVariant>
													<rT z="106562" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106551"/>
													</rT>
													<fD ref="106453"/>
												</FMmbr>
												<FMmbr z="106563" o="0" sid="BSC_Bitzer_P_Hull" sN="Honeymoon on Mars" t="SHIP" iF="false" id="71dad2" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106564" hId="BSC_Bitzer_P_default_D" v="0" c="0" hVId="BSC_Bitzer_P_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106565">
															<e>
																<st>WS0004</st>
																<st>swarmer</st>
															</e>
														</wpn>
														<sM z="106566"/>
														<wng z="106567"/>
														<wG z="106568"/>
														<hM z="106569">
															<st>rugged</st>
															<st>degraded_engines</st>
															<st>comp_hull</st>
															<st>glitched_sensors</st>
															<st>faulty_auto</st>
															<st>damaged_mounts</st>
														</hM>
														<pM z="106570">
															<st>degraded_engines</st>
															<st>comp_hull</st>
															<st>glitched_sensors</st>
															<st>faulty_auto</st>
															<st>damaged_mounts</st>
														</pM>
														<sMods z="106571"/>
														<sModdedBuiltIns z="106572"/>
														<suM z="106573"/>
													</savedVariant>
													<rT z="106574" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106563"/>
													</rT>
													<fD ref="106453"/>
												</FMmbr>
											</m>
										</mS>
									</c>
									<iGR z="106575" serialization="custom">
										<Random>
											<default>
												<s>263776744621318</s>
												<n>0.0</n>
												<h>false</h>
											</default>
										</Random>
									</iGR>
								</p>
								<f ref="1899"/>
							</Submarket>
							<Submarket z="106576" s="black_market">
								<m ref="106118"/>
								<p cl="NexBlackMkt" z="106577" mSWUI="30.0" msSWU="2.2618973" sLCU="0.0">
									<m cl="Market" ref="106118"/>
									<s cl="Submarket" ref="106576"/>
									<c cl="CargoData" z="106578" uS="true" mC="1000.0" sU="7110.493" mF="500.0" mP="750.0" fT="false">
										<s z="106579">
											<CIStack z="106580" rS="false" s="157.56573" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">supplies</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106581" rS="false" s="104.63274" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">fuel</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106582" rS="false" s="280.43173" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">crew</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106583" rS="false" s="20.4665" mS="1000000.0" cSPU="0.0" t="RESOURCES">
												<d cl="st">marines</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106584" rS="false" s="13.23325" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">hand_weapons</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106585" rS="false" s="83.39949" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">drugs</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106586" rS="false" s="140.09924" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">domestic_goods</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106587" rS="false" s="34.46649" mS="1000000.0" cSPU="0.5" t="RESOURCES">
												<d cl="st">alcoholism_blood_c</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106588" rS="false" s="167.79898" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">volatiles</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106589" rS="false" s="210.26547" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">organics</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106590" rS="false" s="560.86346" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">food</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106591" rS="false" s="5611.8677" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">water</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106592" rS="false" s="6.233248" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">biotics</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106593" rS="false" s="69.93298" mS="1000000.0" cSPU="1.0" t="RESOURCES">
												<d cl="st">recitificates</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106594" rS="true" s="2.0" mS="1000000.0" cSPU="8.0" t="WEAPONS">
												<d cl="st">hellbore</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106595" rS="true" s="4.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">tahlan_praxus</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106596" rS="true" s="2.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">filgap_miningbeam</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106597" rS="true" s="1.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">apmg</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106598" rS="true" s="1.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">SKR_accelMissilesLauncher</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106599" rS="true" s="1.0" mS="1000000.0" cSPU="4.0" t="WEAPONS">
												<d cl="st">dualflak</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106600" rS="true" s="4.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">reaper</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106601" rS="true" s="3.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">atropos_single</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106602" rS="true" s="1.0" mS="1000000.0" cSPU="2.0" t="WEAPONS">
												<d cl="st">wpnxt_minivulcan</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106603" rS="true" s="2.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
												<d cl="st">eis_piranha_wing</d>
												<c ref="106578"/>
											</CIStack>
											<CIStack z="106604" rS="true" s="2.0" mS="1000000.0" cSPU="1.0" t="FIGHTER_CHIP">
												<d cl="st">msp_vulgar_wing</d>
												<c ref="106578"/>
											</CIStack>
										</s>
										<c z="106605">
											<value>0.0</value>
										</c>
										<mS z="106606" nP="" nSf="pirates" nS="false" oSML="false">
											<m z="106607">
												<FMmbr z="106608" o="0" sid="BSC_Marauder_Hull" sN="Ulcer Culture" t="SHIP" iF="false" id="71daf2" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106609" hId="BSC_Marauder_default_D" v="0" c="0" hVId="BSC_Marauder_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106610"/>
														<sM z="106611"/>
														<wng z="106612"/>
														<wG z="106613"/>
														<hM z="106614">
															<st>comp_armor</st>
															<st>faulty_grid</st>
															<st>glitched_sensors</st>
															<st>faulty_auto</st>
														</hM>
														<pM z="106615">
															<st>comp_armor</st>
															<st>faulty_grid</st>
															<st>glitched_sensors</st>
															<st>faulty_auto</st>
														</pM>
														<sMods z="106616"/>
														<sModdedBuiltIns z="106617"/>
														<suM z="106618"/>
													</savedVariant>
													<rT z="106619" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106608"/>
													</rT>
													<fD ref="106606"/>
												</FMmbr>
												<FMmbr z="106620" o="0" sid="filgap_copernic_Hull" sN="The Judging of the Priestess" t="SHIP" iF="false" id="71db0e" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106621" hId="filgap_copernic_default_D" v="0" c="0" hVId="filgap_copernic_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106622"/>
														<sM z="106623"/>
														<wng z="106624">
															<st>filum_wing</st>
														</wng>
														<wG z="106625"/>
														<hM z="106626">
															<st>surveying_equipment</st>
															<st>solar_shielding</st>
															<st>civgrade</st>
															<st>defective_manufactory</st>
														</hM>
														<pM z="106627">
															<st>defective_manufactory</st>
														</pM>
														<sMods z="106628"/>
														<sModdedBuiltIns z="106629"/>
														<suM z="106630"/>
													</savedVariant>
													<rT z="106631" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106620"/>
													</rT>
													<fD ref="106606"/>
												</FMmbr>
												<FMmbr z="106632" o="0" sid="BSC_Coyote_Hull" sN="Alien" t="SHIP" iF="false" id="71db22" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106633" hId="BSC_Coyote_default_D" v="0" c="0" hVId="BSC_Coyote_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106634"/>
														<sM z="106635"/>
														<wng z="106636"/>
														<wG z="106637"/>
														<hM z="106638">
															<st>glitched_sensors</st>
															<st>increased_maintenance</st>
														</hM>
														<pM z="106639">
															<st>glitched_sensors</st>
															<st>increased_maintenance</st>
														</pM>
														<sMods z="106640"/>
														<sModdedBuiltIns z="106641"/>
														<suM z="106642"/>
													</savedVariant>
													<rT z="106643" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106632"/>
													</rT>
													<fD ref="106606"/>
												</FMmbr>
												<FMmbr z="106644" o="0" sid="msp_baseplate_Hull" sN="Glowy Lucre" t="SHIP" iF="false" id="71db10" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106645" hId="msp_baseplate_default_D" v="0" c="0" hVId="msp_baseplate_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106646">
															<e>
																<st>WS0009</st>
																<st>ms_blinky</st>
															</e>
															<e>
																<st>WS0004</st>
																<st>ms_blinkyB</st>
															</e>
															<e>
																<st>WS0010</st>
																<st>ms_blinkyB</st>
															</e>
															<e>
																<st>WS0007</st>
																<st>ms_blinky</st>
															</e>
														</wpn>
														<sM z="106647"/>
														<wng z="106648"/>
														<wG z="106649"/>
														<hM z="106650">
															<st>ms_stupidCarrier</st>
															<st>ill_advised</st>
															<st>comp_armor</st>
														</hM>
														<pM z="106651">
															<st>comp_armor</st>
														</pM>
														<sMods z="106652"/>
														<sModdedBuiltIns z="106653"/>
														<suM z="106654"/>
													</savedVariant>
													<rT z="106655" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106644"/>
													</rT>
													<fD ref="106606"/>
												</FMmbr>
												<FMmbr z="106656" o="0" sid="kite_pirates_Hull" sN="Permanent Fatal Errors" t="SHIP" iF="false" id="71db12" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106657" hId="kite_pirates_default_D" v="0" c="0" hVId="kite_pirates_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106658"/>
														<sM z="106659"/>
														<wng z="106660"/>
														<wG z="106661"/>
														<hM z="106662">
															<st>civgrade</st>
															<st>erratic_injector</st>
															<st>degraded_engines</st>
														</hM>
														<pM z="106663">
															<st>erratic_injector</st>
															<st>degraded_engines</st>
														</pM>
														<sMods z="106664"/>
														<sModdedBuiltIns z="106665"/>
														<suM z="106666"/>
													</savedVariant>
													<rT z="106667" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106656"/>
													</rT>
													<fD ref="106606"/>
												</FMmbr>
												<FMmbr z="106668" o="0" sid="salshiexp_search_vessel_Hull" sN="At the Edge of Dying" t="SHIP" iF="false" id="71db14" sUN="false" civ="false" cCiv="false">
													<rT z="106669" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106668"/>
													</rT>
													<fD ref="106606"/>
												</FMmbr>
												<FMmbr z="106670" o="0" sid="uw_sidecar_Hull" sN="Myrmidons" t="SHIP" iF="false" id="71daf4" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106671" hId="uw_sidecar_default_D" v="0" c="0" hVId="uw_sidecar_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106672"/>
														<sM z="106673"/>
														<wng z="106674"/>
														<wG z="106675"/>
														<hM z="106676">
															<st>glitched_sensors</st>
															<st>faulty_auto</st>
															<st>degraded_shields</st>
														</hM>
														<pM z="106677">
															<st>glitched_sensors</st>
															<st>faulty_auto</st>
															<st>degraded_shields</st>
														</pM>
														<sMods z="106678"/>
														<sModdedBuiltIns z="106679"/>
														<suM z="106680"/>
													</savedVariant>
													<rT z="106681" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106670"/>
													</rT>
													<fD ref="106606"/>
												</FMmbr>
												<FMmbr z="106682" o="0" sid="BSC_Tramp_Hull" sN="Poison Realm" t="SHIP" iF="false" id="71db16" sUN="false" civ="false" cCiv="false">
													<savedVariant z="106683" hId="BSC_Tramp_default_D" v="0" c="0" hVId="BSC_Tramp_Hull" vDN="Custom" s="REFIT" mAAW="true" gV="false">
														<wpn z="106684"/>
														<sM z="106685"/>
														<wng z="106686"/>
														<wG z="106687"/>
														<hM z="106688">
															<st>civgrade</st>
															<st>increased_maintenance</st>
															<st>degraded_drive_field</st>
														</hM>
														<pM z="106689">
															<st>increased_maintenance</st>
															<st>degraded_drive_field</st>
														</pM>
														<sMods z="106690"/>
														<sModdedBuiltIns z="106691"/>
														<suM z="106692"/>
													</savedVariant>
													<rT z="106693" cr="0.5" crPTM="0.5" sR="false" mo="true" lCR="false">
														<m ref="106682"/>
													</rT>
													<fD ref="106606"/>
												</FMmbr>
											</m>
										</mS>
									</c>
									<iGR z="106694" serialization="custom">
										<Random>
											<default>
												<s>163820071772915</s>
												<n>0.0</n>
												<h>false</h>
											</default>
										</Random>
									</iGR>
								</p>
								<f ref="1899"/>
							</Submarket>
							<Submarket z="106695" s="storage">
								<m ref="106118"/>
								<p cl="NexStoreSubmkt" z="106696" mSWUI="30.0" msSWU="2525.8877" sLCU="2525.8877" paid="false">
									<m cl="Market" ref="106118"/>
									<s cl="Submarket" ref="106695"/>
									<c cl="CargoData" z="106697" uS="true" mC="1000.0" sU="50.0" mF="500.0" mP="750.0" fT="false">
										<s z="106698"/>
										<c z="106699">
											<value>0.0</value>
										</c>
										<mS z="106700" nP="ISS" nSf="player" nS="false" oSML="false">
											<m z="106701"/>
										</mS>
									</c>
									<iGR z="106702" serialization="custom">
										<Random>
											<default>
												<s>51646483324989</s>
												<n>0.0</n>
												<h>false</h>
											</default>
										</Random>
									</iGR>
								</p>
								<f ref="1031"/>
							</Submarket>
						</submarkets>
						<memory cl="Memory" z="106703">
							<d z="106704">
								<e>
									<st>$startingFactionId</st>
									<st>pirates</st>
								</e>
								<e>
									<st>$nex_existed_at_start</st>
									<bp>true</bp>
								</e>
								<e>
									<st>$startingFreeMarket</st>
									<bp>true</bp>
								</e>
								<e>
									<st>$nex_fleetPoolPointsLastTick</st>
									<fp>0.0363</fp>
								</e>
								<e>
									<st>$nex_groundPoolPointsLastTick</st>
									<fp>0.056100003</fp>
								</e>
								<e>
									<st>$visitedBefore</st>
									<bp>true</bp>
								</e>
								<e>
									<st>$mmm_mbm_random</st>
									<Random z="106705" serialization="custom">
										<Random>
											<default>
												<s>29311529694894</s>
												<n>0.0</n>
												<h>false</h>
											</default>
										</Random>
									</Random>
								</e>
								<e>
									<st>$mmm_mbm_data</st>
									<map z="106706">
										<e>
											<st>dsp</st>
											<Lp-array z="106707">
												<Lp>0</Lp>
												<Lp>-55610921870413</Lp>
												<Lp>6458718526935675498</Lp>
											</Lp-array>
										</e>
										<e>
											<st>DiktatLobsterBarEvent</st>
											<Lp-array z="106708">
												<Lp>0</Lp>
												<Lp>-55611267684646</Lp>
												<Lp>-1345041147300292621</Lp>
											</Lp-array>
										</e>
										<e>
											<st>LuddicCraftBarEvent</st>
											<Lp-array z="106709">
												<Lp>0</Lp>
												<Lp>-55611859296109</Lp>
												<Lp>4007680998771668014</Lp>
											</Lp-array>
										</e>
										<e>
											<st>seco</st>
											<Lp-array z="106710">
												<Lp>0</Lp>
												<Lp>-55611327598312</Lp>
												<Lp>-933715704705420003</Lp>
											</Lp-array>
										</e>
										<e>
											<st>proCom</st>
											<Lp-array z="106711">
												<Lp>1</Lp>
												<Lp>-55611008617966</Lp>
												<Lp>-1956661369600907441</Lp>
											</Lp-array>
										</e>
										<e>
											<st>tabo</st>
											<Lp-array z="106712">
												<Lp>0</Lp>
												<Lp>-55611140933621</Lp>
												<Lp>5454254481498328917</Lp>
											</Lp-array>
										</e>
										<e>
											<st>HistorianBarEvent</st>
											<Lp-array z="106713">
												<Lp>0</Lp>
												<Lp>-55611697296933</Lp>
												<Lp>3362293238407826054</Lp>
											</Lp-array>
										</e>
										<e>
											<st>mcb</st>
											<Lp-array z="106714">
												<Lp>0</Lp>
												<Lp>-55611352361551</Lp>
												<Lp>7635810629306674860</Lp>
											</Lp-array>
										</e>
										<e>
											<st>nex_msb</st>
											<Lp-array z="106715">
												<Lp>0</Lp>
												<Lp>-55610406457815</Lp>
												<Lp>-7408240617631912512</Lp>
											</Lp-array>
										</e>
										<e>
											<st>hijack</st>
											<Lp-array z="106716">
												<Lp>0</Lp>
												<Lp>-55611365886929</Lp>
												<Lp>1084456269141572303</Lp>
											</Lp-array>
										</e>
										<e>
											<st>ddro</st>
											<Lp-array z="106717">
												<Lp>1</Lp>
												<Lp>-55610760427090</Lp>
												<Lp>-5933345376920465257</Lp>
											</Lp-array>
										</e>
										<e>
											<st>LuddicFarmerBarEvent</st>
											<Lp-array z="106718">
												<Lp>0</Lp>
												<Lp>-55610318529837</Lp>
												<Lp>-775609029306540850</Lp>
											</Lp-array>
										</e>
										<e>
											<st>ucb</st>
											<Lp-array z="106719">
												<Lp>1</Lp>
												<Lp>-55610637174991</Lp>
												<Lp>-5928232465992971235</Lp>
											</Lp-array>
										</e>
										<e>
											<st>cpc</st>
											<Lp-array z="106720">
												<Lp>0</Lp>
												<Lp>-55611682792508</Lp>
												<Lp>-2474274285799088731</Lp>
											</Lp-array>
										</e>
										<e>
											<st>CorruptPLClerkSuppliesBarEvent</st>
											<Lp-array z="106721">
												<Lp>0</Lp>
												<Lp>-55611261040939</Lp>
												<Lp>-3607251221961640664</Lp>
											</Lp-array>
										</e>
										<e>
											<st>smug</st>
											<Lp-array z="106722">
												<Lp>1</Lp>
												<Lp>-55610992396048</Lp>
												<Lp>-4024649941649374338</Lp>
											</Lp-array>
										</e>
										<e>
											<st>extr</st>
											<Lp-array z="106723">
												<Lp>0</Lp>
												<Lp>-55611263759067</Lp>
												<Lp>4685383640874072929</Lp>
											</Lp-array>
										</e>
										<e>
											<st>cpm</st>
											<Lp-array z="106724">
												<Lp>0</Lp>
												<Lp>-55611324344272</Lp>
												<Lp>-6603302494211039261</Lp>
											</Lp-array>
										</e>
										<e>
											<st>dhi</st>
											<Lp-array z="106725">
												<Lp>0</Lp>
												<Lp>-55610974712234</Lp>
												<Lp>3690954424050558655</Lp>
											</Lp-array>
										</e>
										<e>
											<st>ssat</st>
											<Lp-array z="106726">
												<Lp>1</Lp>
												<Lp>-55610719030276</Lp>
												<Lp>1555065839700160345</Lp>
											</Lp-array>
										</e>
										<e>
											<st>DeliveryBarEvent</st>
											<Lp-array z="106727">
												<Lp>0</Lp>
												<Lp>-55610655030191</Lp>
												<Lp>2342318570033137724</Lp>
											</Lp-array>
										</e>
										<e>
											<st>QuartermasterCargoSwapBarEvent</st>
											<Lp-array z="106728">
												<Lp>0</Lp>
												<Lp>-55610548113553</Lp>
												<Lp>-7735524277721110751</Lp>
											</Lp-array>
										</e>
										<e>
											<st>MercsOnTheRunBarEvent</st>
											<Lp-array z="106729">
												<Lp>0</Lp>
												<Lp>-55610823457852</Lp>
												<Lp>505884498400922592</Lp>
											</Lp-array>
										</e>
										<e>
											<st>lpt</st>
											<Lp-array z="106730">
												<Lp>0</Lp>
												<Lp>-55610884729593</Lp>
												<Lp>-7073373597492205559</Lp>
											</Lp-array>
										</e>
										<e>
											<st>ttscmtwo</st>
											<Lp-array z="106731">
												<Lp>0</Lp>
												<Lp>-55611700344321</Lp>
												<Lp>-3884347424549049995</Lp>
											</Lp-array>
										</e>
										<e>
											<st>cheapCom</st>
											<Lp-array z="106732">
												<Lp>0</Lp>
												<Lp>-55610539515213</Lp>
												<Lp>-1802877864444160618</Lp>
											</Lp-array>
										</e>
										<e>
											<st>nex_bShip</st>
											<Lp-array z="106733">
												<Lp>1</Lp>
												<Lp>-55611027817728</Lp>
												<Lp>6213684793657034375</Lp>
											</Lp-array>
										</e>
										<e>
											<st>dcom</st>
											<Lp-array z="106734">
												<Lp>1</Lp>
												<Lp>-55610596360562</Lp>
												<Lp>-2900803872615819533</Lp>
											</Lp-array>
										</e>
										<e>
											<st>sShip</st>
											<Lp-array z="106735">
												<Lp>0</Lp>
												<Lp>-55610683181448</Lp>
												<Lp>-401718987042502786</Lp>
											</Lp-array>
										</e>
										<e>
											<st>jabr</st>
											<Lp-array z="106736">
												<Lp>0</Lp>
												<Lp>-55611679670633</Lp>
												<Lp>-2121062575081022623</Lp>
											</Lp-array>
										</e>
										<e>
											<st>TriTachLoanBarEvent</st>
											<Lp-array z="106737">
												<Lp>0</Lp>
												<Lp>-55611301381912</Lp>
												<Lp>-9020113492698784024</Lp>
											</Lp-array>
										</e>
										<e>
											<st>hmdf</st>
											<Lp-array z="106738">
												<Lp>1</Lp>
												<Lp>-55610472870828</Lp>
												<Lp>7205793020309417506</Lp>
											</Lp-array>
										</e>
										<e>
											<st>sitm</st>
											<Lp-array z="106739">
												<Lp>0</Lp>
												<Lp>-55611214581460</Lp>
												<Lp>5062577785888452953</Lp>
											</Lp-array>
										</e>
										<e>
											<st>locrlf</st>
											<Lp-array z="106740">
												<Lp>0</Lp>
												<Lp>-55610274961685</Lp>
												<Lp>-2929585664689617389</Lp>
											</Lp-array>
										</e>
										<e>
											<st>TriTachMajorLoanBarEvent</st>
											<Lp-array z="106741">
												<Lp>0</Lp>
												<Lp>-55610513351712</Lp>
												<Lp>-3390693017435999898</Lp>
											</Lp-array>
										</e>
										<e>
											<st>psb</st>
											<Lp-array z="106742">
												<Lp>0</Lp>
												<Lp>-55611964988486</Lp>
												<Lp>-2558002685827638413</Lp>
											</Lp-array>
										</e>
										<e>
											<st>nex_dcom</st>
											<Lp-array z="106743">
												<Lp>0</Lp>
												<Lp>-55611522596683</Lp>
												<Lp>2405689896309488298</Lp>
											</Lp-array>
										</e>
									</map>
								</e>
								<e>
									<st>$mmm_mbm_last_added</st>
									<Lp>-55613697947000</Lp>
								</e>
								<e>
									<st>$nex_invasionPointsLastTick</st>
									<fp>2.75</fp>
								</e>
							</d>
							<e z="106744">
								<MExp z="106745" k="$nex_fleetPoolPointsLastTick" t="2.53307"/>
								<MExp z="106746" k="$nex_groundPoolPointsLastTick" t="2.53307"/>
								<MExp z="106747" k="$nex_invasionPointsLastTick" t="2.4476705"/>
							</e>
						</memory>
						<stats z="106748">
							<dynamic z="106749">
								<stats z="106750"/>
								<mods z="106751">
									<e>
										<st>officer_prob</st>
										<SBonus z="106752" fB="0.2" m="1.0" pM="0.0" nR="true">
											<fBs z="106753" s="ind_population_0" v="0.1"/>
											<fBs z="106754" s="ind_spaceport_0" v="0.1"/>
										</SBonus>
									</e>
									<e>
										<st>ground_defenses_mod</st>
										<SBonus z="106755" fB="50.0" m="1.1" pM="0.0" nR="true">
											<fBs z="106756" s="ind_population" d="Base value for a size 3 colony" v="50.0"/>
											<mBs z="106757" s="ind_population" d="Stability" v="0.55"/>
											<mBs z="106758" s="ind_grounddefenses" d="Ground defenses" v="2.0"/>
										</SBonus>
									</e>
									<e>
										<st>admin_prob</st>
										<SBonus z="106759" fB="0.05" m="1.0" pM="0.0" nR="true">
											<fBs z="106760" s="ind_population_0" v="0.05"/>
										</SBonus>
									</e>
									<e>
										<st>fleet_quality_mod</st>
										<SBonus z="106761" fB="-0.05" m="1.0" pM="0.0" nR="true">
											<fBs z="106762" s="ind_population_0" d="Stability" v="-0.05"/>
											<fBs z="106763" s="ind_population_1" d="Pirate fleet doctrine" v="0.0"/>
										</SBonus>
									</e>
									<e>
										<st>officer_is_merc_prob</st>
										<SBonus z="106764" fB="0.5" m="1.0" pM="0.0" nR="true">
											<fBs z="106765" s="free_market_3de0" v="0.25"/>
											<fBs z="106766" s="ind_population_0" v="0.25"/>
										</SBonus>
									</e>
									<e>
										<st>max_industries</st>
										<SBonus z="106767" fB="1.0" m="1.0" pM="0.0" nR="false">
											<fBs z="106768" s="ind_population" v="1.0"/>
										</SBonus>
									</e>
									<e>
										<st>additional_officer_prob_mult</st>
										<SBonus z="106769" fB="0.1" m="1.0" pM="0.0" nR="true">
											<fBs z="106770" s="ind_population_0" v="0.1"/>
										</SBonus>
									</e>
									<e>
										<st>combat_fleet_size_mult</st>
										<SBonus z="106771" fB="0.5" m="1.425" pM="0.0" nR="true">
											<fBs z="106772" s="ind_population_0" d="Colony size" v="0.5"/>
											<mBs z="106773" s="ind_population_1" d="Pirate fleet doctrine" v="1.5"/>
											<mBs z="106774" s="ind_population_2" d="Ship hulls &amp; weapons demand met" v="1.0"/>
											<mBs z="106775" s="ind_population_3" d="Stability" v="0.95"/>
										</SBonus>
									</e>
								</mods>
							</dynamic>
						</stats>
						<isPlanetConditionMarketOnly>false</isPlanetConditionMarketOnly>
						<accessibilityMod z="106776" fB="0.47000003" m="1.0" pM="0.0" nR="false">
							<fBs z="106777" s="core_base" d="Proximity to other colonies" v="0.43"/>
							<fBs z="106778" s="core_hostile" d="Hostilities with other factions" v="-0.71"/>
							<fBs z="106779" s="free_market_3de0" d="Free port" v="0.25"/>
							<fBs z="106780" s="ind_spaceport_0" d="Spaceport" v="0.5"/>
						</accessibilityMod>
						<incomeMult z="106781" b="1.0" m="0.8">
							<mMs z="106782" s="ind_population_3" d="Stability" v="0.8"/>
						</incomeMult>
						<upkeepMult z="106783" b="1.0" m="0.94500005">
							<mMs z="106784" s="upkeep_hazard_mod" d="Hazard rating" v="1.75"/>
							<mMs z="106785" s="ind_population_3ifi" d="Demand supplied in-faction (92%)" v="0.54"/>
						</upkeepMult>
						<useStockpilesForShortages>false</useStockpilesForShortages>
						<industries z="106786">
							<PopulationAndInfrastructure z="106787" id="population" bP="0.0" b="false" wD="false">
								<m cl="Market" ref="106118"/>
								<buildTime>1.0</buildTime>
								<dR z="106788" b="0.0" m="0.0"/>
								<sB z="106789" b="0.0" m="0.0"/>
							</PopulationAndInfrastructure>
							<Spaceport z="106790" id="spaceport" bP="0.0" b="false" wD="false">
								<m cl="Market" ref="106118"/>
								<buildTime>1.0</buildTime>
								<dR z="106791" b="0.0" m="0.0"/>
								<sB z="106792" b="0.0" m="0.0"/>
							</Spaceport>
							<Mining z="106793" id="mining" bP="0.0" b="false" wD="false">
								<m cl="Market" ref="106118"/>
								<buildTime>1.0</buildTime>
								<dR z="106794" b="0.0" m="0.0"/>
								<sB z="106795" b="0.0" m="0.0"/>
								<shownPlasmaNetVisuals>false</shownPlasmaNetVisuals>
							</Mining>
							<GroundDefenses z="106796" id="grounddefenses" bP="0.0" b="false" wD="false">
								<m cl="Market" ref="106118"/>
								<buildTime>1.0</buildTime>
								<dR z="106797" b="0.0" m="0.0"/>
								<sB z="106798" b="0.0" m="0.0"/>
							</GroundDefenses>
						</industries>
						<playerOwned>false</playerOwned>
						<hasSpaceport>true</hasSpaceport>
						<hasWaystation>false</hasWaystation>
						<population z="106799">
							<comp z="106800">
								<e>
									<st>pirates</st>
									<fp>232.74316</fp>
								</e>
								<e>
									<st>poor</st>
									<fp>46.741264</fp>
								</e>
								<e>
									<st>independent</st>
									<fp>20.515556</fp>
								</e>
							</comp>
							<weight z="106801" b="0.0" m="300.0">
								<fMs z="106802" s="core_set" v="300.0"/>
							</weight>
						</population>
						<incoming z="106803">
							<comp z="106804">
								<e>
									<st>pirates</st>
									<fp>12.444445</fp>
								</e>
								<e>
									<st>poor</st>
									<fp>2.2857144</fp>
								</e>
								<e>
									<st>independent</st>
									<fp>1.2698413</fp>
								</e>
							</comp>
							<weight z="106805" b="0.0" m="-2.5">
								<fMs z="106806" s="inc_st" d="Instability" v="-1.0"/>
								<fMs z="106807" s="inc_access" d="Accessibility" v="4.0"/>
								<fMs z="106808" s="inc_hazard" d="Hazard rating (×1 based on colony size)" v="-15.0"/>
								<fMs z="106809" s="nex_colonyManager_npcGrowth_freePort" d="Free port NPC offset" v="-5.0"/>
								<fMs z="106810" s="free_market_3de0" d="Free port" v="10.0"/>
								<fMs z="106811" s="ind_spaceport" d="Spaceport" v="2.0"/>
								<mMs z="106812" s="nex_colonyManager_npcGrowth" d="NPC market" v="0.5"/>
							</weight>
						</incoming>
						<immigrationModifiers z="106813">
							<ColonyMngr ref="2145"/>
						</immigrationModifiers>
						<allowImport>true</allowImport>
						<allowExport>true</allowExport>
						<incentiveCredits>0.0</incentiveCredits>
						<constructionQueue z="106814">
							<items z="106815"/>
						</constructionQueue>
						<commDirectory z="106816">
							<entries z="106817">
								<CommDirectoryEntry z="106818">
									<id>61d8</id>
									<type>PERSON</type>
									<entryData cl="Person" z="106819" id="p_61d7" pid="steady" spr="graphics/portraits/portrait_pirate03.png" rnk="spaceCommander" pst="portmaster" wTCRC="0" cW="1.0" fid="pirates" a="true" im="VERY_LOW">
										<n z="106820" f="Zada" l="Evans" g="MALE"/>
										<m z="106821">
											<d z="106822">
												<e>
													<st>$voice</st>
													<st>soldier</st>
												</e>
											</d>
										</m>
										<stats z="106823" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0"/>
										<market cl="Market" ref="106118"/>
										<tags z="106824">
											<st>trade</st>
										</tags>
										<voiceOverride>true</voiceOverride>
									</entryData>
									<hidden>false</hidden>
								</CommDirectoryEntry>
								<CommDirectoryEntry z="106825">
									<id>61da</id>
									<type>PERSON</type>
									<entryData cl="Person" z="106826" id="p_61d9" pid="steady" spr="graphics/portraits/portrait_mercenary03.png" rnk="spaceCommander" pst="supplyOfficer" wTCRC="0" cW="1.0" fid="pirates" a="true" im="MEDIUM">
										<n z="106827" f="Nessus" l="Charming" g="MALE"/>
										<m z="106828">
											<d z="106829">
												<e>
													<st>$voice</st>
													<st>spacer</st>
												</e>
											</d>
										</m>
										<stats z="106830" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0"/>
										<market cl="Market" ref="106118"/>
										<tags z="106831">
											<st>trade</st>
											<st>military</st>
										</tags>
										<voiceOverride>true</voiceOverride>
									</entryData>
									<hidden>false</hidden>
								</CommDirectoryEntry>
								<CommDirectoryEntry z="106832">
									<id>61dc</id>
									<type>PERSON</type>
									<entryData cl="Person" z="106833" id="p_61db" pid="steady" spr="graphics/portraits/portrait14.png" rnk="citizen" pst="administrator" wTCRC="0" cW="1.0" fid="pirates" a="true" im="MEDIUM">
										<n z="106834" f="Qacha" l="Hart" g="FEMALE"/>
										<m z="106835">
											<d z="106836">
												<e>
													<st>$voice</st>
													<st>spacer</st>
												</e>
											</d>
										</m>
										<stats z="106837" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0"/>
										<market cl="Market" ref="106118"/>
										<tags z="106838">
											<st>trade</st>
										</tags>
										<voiceOverride>true</voiceOverride>
									</entryData>
									<hidden>false</hidden>
								</CommDirectoryEntry>
								<CommDirectoryEntry z="106839">
									<id>719241</id>
									<type>PERSON</type>
									<entryData cl="Person" z="106840" id="p_719240" pid="reckless" spr="graphics/portraits/portrait_pirate20.png" rnk="spaceLieutenant" pst="officer_for_hire" wTCRC="0" cW="1.0" fid="independent" a="true" im="MEDIUM">
										<n z="106841" f="Pyramus" l="Psyche" g="MALE"/>
										<m z="106842">
											<d z="106843">
												<e>
													<st>$voice</st>
													<st>soldier</st>
												</e>
												<e>
													<st>$ome_hireable</st>
													<bp>true</bp>
												</e>
												<e>
													<st>$ome_eventRef</st>
													<OfficerManagerEvent ref="3503"/>
												</e>
												<e>
													<st>$ome_hiringBonus</st>
													<st>2,000</st>
												</e>
												<e>
													<st>$ome_salary</st>
													<st>900</st>
												</e>
											</d>
										</m>
										<stats z="106844" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0">
											<s>{"polarized_armor":1}</s>
										</stats>
										<market cl="Market" ref="106118"/>
									</entryData>
									<hidden>false</hidden>
								</CommDirectoryEntry>
							</entries>
						</commDirectory>
						<people z="106845">
							<Person ref="106833"/>
							<Person ref="106840"/>
							<Person ref="106826"/>
							<Person ref="106819"/>
						</people>
						<admin ref="106833"/>
						<prevStability>4.0</prevStability>
						<daysInExistence>2494.7976</daysInExistence>
						<connectedEntities z="106846">
							<Plnt ref="106112"/>
							<CCEnt z="106847" fL="STATIONS">
								<loc z="106848">-2020.8677|6962.745</loc>
								<vel z="106849">0.0|0.0</vel>
								<j0>{"f6":258.64514,"f0":"Garnir Extraction Depot","f2":[255,255,255,255],"f3":"pirate_base_barad","f4":"corvus_pirate_station"}</j0>
								<ow ref="1899"/>
								<orbit cl="COrbtPD" z="106850" r="180.0" op="20.0" ca="258.64514">
									<e cl="CCEnt" ref="106847"/>
									<f cl="Plnt" ref="106112"/>
								</orbit>
								<cL cl="Sstm" ref="104188"/>
								<ls cl="Plnt" ref="104185"/>
								<me z="106851">
									<d z="106852">
										<e>
											<st>$illustrated_entity_image</st>
											<ip>278</ip>
										</e>
									</d>
								</me>
								<market cl="Market" ref="106118"/>
								<sc z="106853"/>
								<cV z="106854" sn="graphics/illustrated_entities/images/278.png" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
								<tags z="106855">
									<st>$illustrated_entity_image</st>
									<st>station</st>
								</tags>
								<j1>{"f0":66,"f1":80,"f2":60,"f3":-1,"f4":-1,"f5":"station_lowtech1"}</j1>
								<la z="106856" enum-type="CaEnLa">STATIONS</la>
							</CCEnt>
						</connectedEntities>
						<conditions z="106857">
							<MCon z="106858" i="population_3" u="3ddb" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106859" i="no_atmosphere" u="3ddc" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106860" i="volatiles_plentiful" u="3ddd" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106861" i="cold" u="3dde" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106862" i="free_market" u="3de0" s="true">
								<p cl="FreeMarket" z="106863">
									<m cl="Market" ref="106118"/>
									<c cl="MCon" ref="106862"/>
									<daysActive>100000.0</daysActive>
								</p>
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106864" i="IndEvo_ressCond" u="6f69" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106865" i="alcohol_resourceCondition" u="715a" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106866" i="IcDemmand" u="885c" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106867" i="watterSupplyMining" u="885d" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106868" i="AoDFoodDemand" u="89b9" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106869" i="AodFood" u="89ba" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106870" i="industrial_might" u="8aba" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106871" i="nex_faction_condition" u="11e51c54-3784-44b0-afee-d5d767ac2d92" s="true">
								<p cl="exerelin.campaign.econ.FactionConditionPlugin" z="106872">
									<m cl="Market" ref="106118"/>
									<c cl="MCon" ref="106871"/>
									<factionId>pirates</factionId>
								</p>
								<m cl="Market" ref="106118"/>
							</MCon>
							<MCon z="106873" i="comm_relay" u="65e116" s="true">
								<m cl="Market" ref="106118"/>
							</MCon>
						</conditions>
						<surveyLevel>FULL</surveyLevel>
						<forceNoConvertOnSave>false</forceNoConvertOnSave>
						<isFreePort>true</isFreePort>
					</market>
					<sc z="106874"/>
					<cV z="106875" sn="graphics/illustrated_entities/images/146.png" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
					<tags z="106876">
						<st>$illustrated_entity_image</st>
						<st>planet</st>
					</tags>
					<angle>216.54437</angle>
					<cloudAngle>273.40228</cloudAngle>
					<radius>100.0</radius>
					<type>cryovolcanic</type>
					<layers z="106877" enum-type="CaEnLa">PLANETS,ABOVE</layers>
				</Plnt>
				<CCEnt ref="106847"/>
				<RingBand z="106878">
					<loc z="106879">-2759.83|7295.4326</loc>
					<vel z="106880">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Null","f2":[255,255,255,255],"f4":"31"}</j0>
					<ow ref="93"/>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106881">
						<d z="106882"/>
					</me>
					<sc z="106883"/>
					<j1>{"f6":-22302.262,"f7":"misc","f8":"rings_ice0","f10":0,"f11":2,"f0":256,"f1":2,"f2":[255,255,255,255],"f3":256,"f4":45,"f5":1050}</j1>
					<focus cl="Plnt" ref="106073"/>
					<layers z="106884" enum-type="CaEnLa">RINGS</layers>
				</RingBand>
				<CampaignTerrain z="106885" type="ring" radius="0.0">
					<loc z="106886">-2759.83|7295.4326</loc>
					<vel z="106887">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"32"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="106888" r="0.0" op="100.0" ca="0.0">
						<e cl="CampaignTerrain" ref="106885"/>
						<f cl="Plnt" ref="106073"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106889">
						<d z="106890"/>
					</me>
					<sc z="106891"/>
					<tags z="106892">
						<st>terrain</st>
					</tags>
					<plugin cl="RingSystemTerrainPlugin" z="106893" tid="ring" n="Ring System">
						<entity cl="CampaignTerrain" ref="106885"/>
						<params z="106894" bWIE="192.0" mR="1050.0">
							<e cl="RingBand" ref="106878"/>
						</params>
					</plugin>
				</CampaignTerrain>
				<Plnt z="106895">
					<loc z="106896">-2235.451|8484.981</loc>
					<vel z="106897">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Warion","f2":[255,255,255,255],"f4":"corvus_IIIb"}</j0>
					<ow ref="93"/>
					<orbit cl="COrbt" z="106898" r="1300.0" op="60.0" ca="66.21106">
						<e cl="Plnt" ref="106895"/>
						<f cl="Plnt" ref="106073"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106899">
						<d z="106900">
							<e>
								<st>$salvageSeed</st>
								<Lp>7360953958207592531</Lp>
							</e>
						</d>
					</me>
					<market cl="PCMarket" z="106901">
						<id>market_corvus_IIIb</id>
						<name>Warion</name>
						<primaryEntity cl="Plnt" ref="106895"/>
						<surveyLevel>FULL</surveyLevel>
						<cond z="106902">
							<st>ore_sparse</st>
							<st>no_atmosphere</st>
							<st>low_gravity</st>
						</cond>
						<surveyed z="106903">
							<st>ore_sparse</st>
							<st>no_atmosphere</st>
							<st>low_gravity</st>
						</surveyed>
					</market>
					<sc z="106904"/>
					<tags z="106905">
						<st>planet</st>
					</tags>
					<angle>288.2038</angle>
					<cloudAngle>0.0</cloudAngle>
					<radius>70.0</radius>
					<type>barren</type>
					<layers z="106906" enum-type="CaEnLa">PLANETS,ABOVE</layers>
				</Plnt>
				<CampaignTerrain z="106907" type="asteroid_field" radius="0.0">
					<loc z="106908">4936.268|6039.309</loc>
					<vel z="106909">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"33"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="106910" r="7800.0" op="400.0" ca="50.738922">
						<e cl="CampaignTerrain" ref="106907"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106911">
						<d z="106912"/>
					</me>
					<sc z="106913"/>
					<tags z="106914">
						<st>terrain</st>
					</tags>
					<plugin cl="AsteroidFieldTerrainPlugin" z="106915" tid="asteroid_field" n="Barad L4 Asteroids" nTCA="false">
						<entity cl="CampaignTerrain" ref="106907"/>
						<params cl="AsteroidFieldParams" defined-in="BaseRingTerrain" z="106916" bWIE="532.6843" mR="266.34216" n="Barad L4 Asteroids" minR="500.0" maxR="700.0" minA="20" maxA="30" minS="4.0" maxS="16.0" nA="25"/>
						<params ref="106916"/>
					</plugin>
				</CampaignTerrain>
				<CampaignTerrain z="106917" type="asteroid_field" radius="0.0">
					<loc z="106918">-7698.067|1256.8861</loc>
					<vel z="106919">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"34"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="106920" r="7800.0" op="400.0" ca="170.72699">
						<e cl="CampaignTerrain" ref="106917"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106921">
						<d z="106922"/>
					</me>
					<sc z="106923"/>
					<tags z="106924">
						<st>terrain</st>
					</tags>
					<plugin cl="AsteroidFieldTerrainPlugin" z="106925" tid="asteroid_field" n="Barad L5 Asteroids" nTCA="false">
						<entity cl="CampaignTerrain" ref="106917"/>
						<params cl="AsteroidFieldParams" defined-in="BaseRingTerrain" z="106926" bWIE="532.66644" mR="266.33322" n="Barad L5 Asteroids" minR="500.0" maxR="700.0" minA="20" maxA="30" minS="4.0" maxS="16.0" nA="26"/>
						<params ref="106926"/>
					</plugin>
				</CampaignTerrain>
				<CampaignTerrain z="106927" type="nebula" radius="0.0">
					<loc z="106928">3831.3376|-9236.929</loc>
					<vel z="106929">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"36"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="106930" r="10000.0" op="500.0" ca="292.52795">
						<e cl="CampaignTerrain" ref="106927"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106931">
						<d z="106932"/>
					</me>
					<sc z="106933"/>
					<tags z="106934">
						<st>terrain</st>
					</tags>
					<plugin cl="NTP" z="106935" tid="nebula" n="Nebula">
						<entity cl="CampaignTerrain" ref="106927"/>
						<params z="106936">
							<w>6</w>
							<h>6</h>
							<cat>terrain</cat>
							<key>nebula_amber</key>
							<tW>4</tW>
							<tH>4</tH>
						</params>
						<tileSeed>284571455684895968</tileSeed>
						<savedTiles>eJzjOH/PJAEABssCSg==</savedTiles>
						<elapsed>2788.182</elapsed>
					</plugin>
				</CampaignTerrain>
				<Plnt z="106937">
					<loc z="106938">2649.5417|12331.079</loc>
					<vel z="106939">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Nox","f2":[255,255,255,255],"f4":"corvus:planet_7"}</j0>
					<ow ref="93"/>
					<orbit cl="COrbt" z="106940" r="12612.518" op="553.41437" ca="77.87341">
						<e cl="Plnt" ref="106937"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106941">
						<d z="106942">
							<e>
								<st>$salvageSeed</st>
								<Lp>43042326151718367</Lp>
							</e>
						</d>
					</me>
					<market cl="PCMarket" z="106943">
						<id>market_corvus:planet_7</id>
						<name>Nox</name>
						<primaryEntity cl="Plnt" ref="106937"/>
						<surveyLevel>FULL</surveyLevel>
						<cond z="106944">
							<st>ore_sparse</st>
							<st>very_cold</st>
							<st>no_atmosphere</st>
							<st>poor_light</st>
						</cond>
						<surveyed z="106945">
							<st>ore_sparse</st>
							<st>very_cold</st>
							<st>no_atmosphere</st>
							<st>poor_light</st>
						</surveyed>
					</market>
					<sc z="106946"/>
					<tags z="106947">
						<st>planet</st>
					</tags>
					<angle>208.41547</angle>
					<cloudAngle>0.0</cloudAngle>
					<radius>112.51757</radius>
					<type>US_azure</type>
					<diff z="106948">
						<j>{"atmosphereColor":[138,162,179,155],"tilt":-48.16131591796875,"planetColor":[253,228,237,255]}</j>
					</diff>
					<layers z="106949" enum-type="CaEnLa">PLANETS,ABOVE</layers>
				</Plnt>
				<CampaignTerrain z="106950" type="asteroid_belt" radius="0.0">
					<loc z="106951">0.0|0.0</loc>
					<vel z="106952">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"The Pactolus","f2":[255,255,255,255],"f4":"3c"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="106953" r="0.0" op="100.0" ca="0.0">
						<e cl="CampaignTerrain" ref="106950"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106954">
						<d z="106955"/>
					</me>
					<sc z="106956"/>
					<tags z="106957">
						<st>terrain</st>
					</tags>
					<plugin cl="AsteroidBeltTerrainPlugin" z="106958" tid="asteroid_belt" n="The Pactolus" nTCA="false">
						<entity cl="CampaignTerrain" ref="106950"/>
						<params cl="AsteroidBeltParams" defined-in="BaseRingTerrain" z="106959" bWIE="400.0" mR="13847.033" nA="250" minO="603.27496" maxO="1206.5499" minS="4.0" maxS="16.0"/>
						<params ref="106959"/>
					</plugin>
				</CampaignTerrain>
				<RingBand z="106960">
					<loc z="106961">0.0|0.0</loc>
					<vel z="106962">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Null","f2":[255,255,255,255],"f4":"3d"}</j0>
					<ow ref="93"/>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106963">
						<d z="106964"/>
					</me>
					<sc z="106965"/>
					<j1>{"f6":-1035.9546,"f7":"misc","f8":"rings_asteroids0","f10":0,"f11":2,"f0":256,"f2":[255,255,255,255],"f3":256,"f4":844.58496,"f5":13747.033}</j1>
					<focus cl="Plnt" ref="104185"/>
					<layers z="106966" enum-type="CaEnLa">RINGS</layers>
				</RingBand>
				<RingBand z="106967">
					<loc z="106968">0.0|0.0</loc>
					<vel z="106969">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Null","f2":[255,255,255,255],"f4":"3e"}</j0>
					<ow ref="93"/>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106970">
						<d z="106971"/>
					</me>
					<sc z="106972"/>
					<j1>{"f6":-1240.5509,"f7":"misc","f8":"rings_asteroids0","f10":0,"f11":2,"f0":256,"f1":3,"f2":[255,255,255,255],"f3":256,"f4":804.36664,"f5":13947.033}</j1>
					<focus cl="Plnt" ref="104185"/>
					<layers z="106973" enum-type="CaEnLa">RINGS</layers>
				</RingBand>
				<RingBand z="106974">
					<loc z="106975">0.0|0.0</loc>
					<vel z="106976">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Null","f2":[255,255,255,255],"f4":"3f"}</j0>
					<ow ref="93"/>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106977">
						<d z="106978"/>
					</me>
					<sc z="106979"/>
					<j1>{"f6":-601.919,"f7":"misc","f8":"rings_ice0","f10":0,"f11":2,"f0":256,"f1":1,"f2":[240,231,240,255],"f3":256,"f4":1055.102,"f5":15079.482}</j1>
					<focus cl="Plnt" ref="104185"/>
					<layers z="106980" enum-type="CaEnLa">RINGS</layers>
				</RingBand>
				<CampaignTerrain z="106981" type="ring" radius="0.0">
					<loc z="106982">0.0|0.0</loc>
					<vel z="106983">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"40"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="106984" r="0.0" op="100.0" ca="0.0">
						<e cl="CampaignTerrain" ref="106981"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106985">
						<d z="106986"/>
					</me>
					<sc z="106987"/>
					<tags z="106988">
						<st>terrain</st>
					</tags>
					<plugin cl="RingSystemTerrainPlugin" z="106989" tid="ring" n="Ring System">
						<entity cl="CampaignTerrain" ref="106981"/>
						<params z="106990" bWIE="192.0" mR="15079.482">
							<e cl="RingBand" ref="106974"/>
						</params>
					</plugin>
				</CampaignTerrain>
				<RingBand z="106991">
					<loc z="106992">0.0|0.0</loc>
					<vel z="106993">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Null","f2":[255,255,255,255],"f4":"41"}</j0>
					<ow ref="93"/>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="106994">
						<d z="106995"/>
					</me>
					<sc z="106996"/>
					<j1>{"f6":-463.26443,"f7":"misc","f8":"rings_ice0","f10":0,"f11":2,"f0":256,"f1":1,"f2":[240,231,240,255],"f3":256,"f4":1230.9523,"f5":15079.482}</j1>
					<focus cl="Plnt" ref="104185"/>
					<layers z="106997" enum-type="CaEnLa">RINGS</layers>
				</RingBand>
				<CampaignTerrain z="106998" type="ring" radius="0.0">
					<loc z="106999">0.0|0.0</loc>
					<vel z="107000">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"42"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="107001" r="0.0" op="100.0" ca="0.0">
						<e cl="CampaignTerrain" ref="106998"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107002">
						<d z="107003"/>
					</me>
					<sc z="107004"/>
					<tags z="107005">
						<st>terrain</st>
					</tags>
					<plugin cl="RingSystemTerrainPlugin" z="107006" tid="ring" n="Ring System">
						<entity cl="CampaignTerrain" ref="106998"/>
						<params z="107007" bWIE="192.0" mR="15079.482">
							<e cl="RingBand" ref="106991"/>
						</params>
					</plugin>
				</CampaignTerrain>
				<RingBand z="107008">
					<loc z="107009">0.0|0.0</loc>
					<vel z="107010">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Null","f2":[255,255,255,255],"f4":"43"}</j0>
					<ow ref="93"/>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107011">
						<d z="107012"/>
					</me>
					<sc z="107013"/>
					<j1>{"f6":-703.8836,"f7":"misc","f8":"rings_ice0","f10":0,"f11":2,"f0":256,"f1":2,"f2":[240,231,240,255],"f3":256,"f4":1081.841,"f5":15207.482}</j1>
					<focus cl="Plnt" ref="104185"/>
					<layers z="107014" enum-type="CaEnLa">RINGS</layers>
				</RingBand>
				<CampaignTerrain z="107015" type="ring" radius="0.0">
					<loc z="107016">0.0|0.0</loc>
					<vel z="107017">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"44"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="107018" r="0.0" op="100.0" ca="0.0">
						<e cl="CampaignTerrain" ref="107015"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107019">
						<d z="107020"/>
					</me>
					<sc z="107021"/>
					<tags z="107022">
						<st>terrain</st>
					</tags>
					<plugin cl="RingSystemTerrainPlugin" z="107023" tid="ring" n="Ring System">
						<entity cl="CampaignTerrain" ref="107015"/>
						<params z="107024" bWIE="192.0" mR="15207.482">
							<e cl="RingBand" ref="107008"/>
						</params>
					</plugin>
				</CampaignTerrain>
				<CampaignTerrain z="107025" type="nebula" radius="0.0">
					<loc z="107026">0.0|0.0</loc>
					<vel z="107027">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"45"}</j0>
					<ow ref="13"/>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107028">
						<d z="107029"/>
					</me>
					<sc z="107030"/>
					<tags z="107031">
						<st>terrain</st>
					</tags>
					<plugin cl="NTP" z="107032" tid="nebula" n="Nebula">
						<entity cl="CampaignTerrain" ref="107025"/>
						<params z="107033">
							<w>128</w>
							<h>128</h>
							<cat>terrain</cat>
							<key>nebula_amber</key>
							<tW>4</tW>
							<tH>4</tH>
						</params>
						<tileSeed>1915026171436778176</tileSeed>
						<savedTiles>eJxVVU2IHEUU/qq7dqZkZmd6s8uy0d3ZFocoEnYHURlxzbTiYY8riOSwxBE85CBmD6IewlL+gQfBgBcPHsYoIYKHiJe9CK1oEARvQi5KI4lECLIEhUHWxPdeVVf31OF1ffPqvQ==ej9fvQH8WtlHc/JSESsH1VcdGIsEba9XH+IkMoSlujblb/ip+20/wQRpiZu5TVBbKt9NYCKP4gLjDQNoawRHWyQ0smFpf0lkOpiQ5BgaY8Zj8HFtyYEVPXo56diBnNfoW5blag==yP79GuZlq6Aii9h8J/tDPhux7qI4Ww1+Llr6tbXrLoCyU3HQZkeLXIKEozJ9xsd9WOUirKr7DdYwEw/WKHwlAbnCrxN+x8dH5TOtt8rUZGVtVOmtAq9xOY65E2Yd2IEvA6+OdA==x9QsMBAZmdLekKmBcrjtDt5TXrjsjPfxm8MnxN4cqasOHxP53pul84hD7q8VVbhk3/h8XG7dZ4KZpS0ei4ODlD//xTU9kfDLrt/PZUv8+eZSpdVk9MIzHqjMMsOWrzs8Rf41Mw==eOOWwzsu/+7GrsOZyKR5Y1i6Sx9BjPj7leD/Zag0ubAd8GZEsSUHATMHnp4OZjKKD2qAEzoMuRKBqQzevcF5wg9hITyTUxTTSq3dPTm15NEJYq/SGuXxPr+BjueN4CbjvMSniQ==qeQi4B1NR0c2eC+42aOgdn5GRZ1uhA+rPV/cPaj4yI/p3GVkvm1o0YkXr3Cae8wicKinC/6mYjzvUqQ1FPwEiS3Bj7oEzmKhU7t7flp7SHz/j1Wysnb5+amQ0dx5Cq2dFSGjIw==Oj8fEkR8h8SazRyKoO6Q6BQeX4jwL+G5vLyzidvsxOsjdK0wfQ+e8OuZa2Tq29/LPcWv+VLxzRyd58My40aIFvfyRa2Kaw/IWLgvHFg8IqF1PR2OqsKcDrq3Snx8X/D1kO5dlg==q38K0bn2b/CAeuqcZUpQndUfrP/lH3v/ZQKpUX8z/ugzi1fJGGk8JWivtsA81XYYX2E6r39q1U3gVyQ0wqmRS+ST7E+luJFn0V6S0pQgxf4APyEzNK+bOXfxzMfqYejGswnPcA==Wo9bNSYebSf+GfasmuC5dkZ82HbFpyh32sknOnqXmRZz6xNDM8sSWWjSWZlpmYYlSnVcj6wws11yeYbIXJByc1KkdEuq/bzgL9Qs7vK+YGfyAtVd/qua9NFL3b/Ig2LfwGgQhQ==6QYK9smDGAPfxbmflV2cVvNXvwIbH1Uh6b8sot+FL1KWbZUfqtuVfusHqsgm1z2Rt/B6fDbBqNJ/8PY1hU3LNeQ7Fm42hsKxLFxgyM7yBTI2JvQ+TDUSYP8HLmG9MA==</savedTiles>
						<elapsed>2788.182</elapsed>
					</plugin>
				</CampaignTerrain>
				<JumpPoint z="107034" r="50.0" dSC="misc" dSI="wormhole_hyper" sO="5816.1963">
					<loc z="107035">15181.619|-3426.0315</loc>
					<vel z="107036">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Fringe Jump-point","f2":[255,255,255,255],"f4":"4e"}</j0>
					<ow ref="93"/>
					<orbit cl="COrbt" z="107037" r="15563.395" op="1461.2518" ca="347.28308">
						<e cl="JumpPoint" ref="107034"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107038">
						<d z="107039"/>
					</me>
					<sc z="107040"/>
					<tags z="107041">
						<st>jump_point</st>
					</tags>
					<dst z="107042">
						<JumpDestination z="107043" l="hyperspace" minD="0.0" maxD="0.0">
							<d cl="JumpPoint" z="107044" r="50.0" dSC="misc" dSI="wormhole_stars" sO="24927.574">
								<loc z="107045">1391.7068|-9621.995</loc>
								<vel z="107046">0.0|0.0</vel>
								<j0>{"f6":0,"f0":"Corvus, Fringe Jump-point","f2":[255,255,255,255],"f4":"4d"}</j0>
								<ow ref="93"/>
								<orbit cl="UpdateFromSystemLocationOrbit" z="107047" oR="1016.25" lI="1.44" e="0.0">
									<sP cl="LocationToken" ref="106018"/>
									<s cl="Plnt" ref="104185"/>
									<iSE cl="JumpPoint" ref="107034"/>
									<iH cl="JumpPoint" ref="107044"/>
									<p z="107048">1391.7068|-9621.995</p>
									<l z="107049">1391.453|-9623.125</l>
								</orbit>
								<cL cl="Hyperspace" ref="2"/>
								<me z="107050">
									<d z="107051"/>
								</me>
								<sc z="107052"/>
								<tags z="107053">
									<st>jump_point</st>
								</tags>
								<dst z="107054">
									<JumpDestination z="107055" l="the fringe of the Corvus system" minD="0.0" maxD="0.0">
										<d cl="JumpPoint" ref="107034"/>
									</JumpDestination>
								</dst>
								<f z="107056" b="1.0" i="1.0" o="1.0" s="IDLE" d="false" u="false"/>
								<layers z="107057" enum-type="CaEnLa">JUMP_POINTS</layers>
							</d>
						</JumpDestination>
					</dst>
					<f z="107058" b="1.0" i="1.0" o="1.0" s="IDLE" d="false" u="false"/>
					<layers z="107059" enum-type="CaEnLa">JUMP_POINTS</layers>
				</JumpPoint>
				<CampaignTerrain z="107060" type="radio_chatter" radius="0.0">
					<loc z="107061">-378.755|2774.2646</loc>
					<vel z="107062">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"5588"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="107063" r="0.0" op="100.0" ca="0.0">
						<e cl="CampaignTerrain" ref="107060"/>
						<f cl="Plnt" ref="104212"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107064">
						<d z="107065"/>
					</me>
					<sc z="107066"/>
					<tags z="107067">
						<st>terrain</st>
					</tags>
					<plugin cl="RadioChatterTerrainPlugin" z="107068" tid="radio_chatter" n="Unknown">
						<entity cl="CampaignTerrain" ref="107060"/>
						<params cl="RadioChatterParams" defined-in="BaseRingTerrain" z="107069" bWIE="1250.0" mR="625.0">
							<e cl="Plnt" ref="104212"/>
						</params>
						<params ref="107069"/>
					</plugin>
				</CampaignTerrain>
				<CampaignTerrain z="107070" type="radio_chatter" radius="0.0">
					<loc z="107071">-282.67303|-4491.113</loc>
					<vel z="107072">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"5589"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="107073" r="0.0" op="100.0" ca="0.0">
						<e cl="CampaignTerrain" ref="107070"/>
						<f cl="Plnt" ref="104181"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107074">
						<d z="107075"/>
					</me>
					<sc z="107076"/>
					<tags z="107077">
						<st>terrain</st>
					</tags>
					<plugin cl="RadioChatterTerrainPlugin" z="107078" tid="radio_chatter" n="Unknown">
						<entity cl="CampaignTerrain" ref="107070"/>
						<params cl="RadioChatterParams" defined-in="BaseRingTerrain" z="107079" bWIE="1700.0" mR="850.0">
							<e cl="Plnt" ref="104181"/>
						</params>
						<params ref="107079"/>
					</plugin>
				</CampaignTerrain>
				<CampaignTerrain z="107080" type="radio_chatter" radius="0.0">
					<loc z="107081">-1985.4283|7139.2217</loc>
					<vel z="107082">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"Null","f2":[255,255,255,255],"f4":"558a"}</j0>
					<ow ref="13"/>
					<orbit cl="COrbt" z="107083" r="0.0" op="100.0" ca="0.0">
						<e cl="CampaignTerrain" ref="107080"/>
						<f cl="Plnt" ref="106112"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107084">
						<d z="107085"/>
					</me>
					<sc z="107086"/>
					<tags z="107087">
						<st>terrain</st>
					</tags>
					<plugin cl="RadioChatterTerrainPlugin" z="107088" tid="radio_chatter" n="Unknown">
						<entity cl="CampaignTerrain" ref="107080"/>
						<params cl="RadioChatterParams" defined-in="BaseRingTerrain" z="107089" bWIE="1000.0" mR="500.0">
							<e cl="Plnt" ref="106112"/>
						</params>
						<params ref="107089"/>
					</plugin>
				</CampaignTerrain>
				<Flt z="107090" sS="450.0" sP="450.0" mO="false" f="90.0" n="Jangala Station" aM="true" nFIN="true" sM="true" dF="90.0">
					<loc z="107091">-421.19714|-4823.3945</loc>
					<vel z="107092">0.0|0.0</vel>
					<j0>{"f6":0,"f0":"Null","f2":[255,255,255,255],"f4":"8c9e","f5":true}</j0>
					<o ref="873"/>
					<orbit cl="COrbt" z="107093" r="0.0" op="100.0" ca="0.0">
						<e cl="Flt" ref="107090"/>
						<f cl="CCEnt" ref="105983"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107094">
						<d z="107095">
							<e>
								<st>$fleetType</st>
								<st>patrolSmall</st>
							</e>
							<e>
								<st>$salvageSeed</st>
								<Lp>-9110318378142842218</Lp>
							</e>
							<e>
								<st>$spawnFPMult</st>
								<fp>0.0</fp>
							</e>
							<e>
								<st>$stationMarket</st>
								<st>mRef_jangala</st>
							</e>
						</d>
					</me>
					<sc z="107096">
						<TrA z="107097" id="transponder" dF="0" tO="true" cL="0.0" iAC="true" l="1.0">
							<e cl="Flt" ref="107090"/>
						</TrA>
					</sc>
					<abilities cl="l-h-m" z="107098">
						<e>
							<st>transponder</st>
							<TrA ref="107097"/>
						</e>
					</abilities>
					<fD z="107099" nP="HSS" nSf="hegemony" nS="false" oSML="false">
						<m z="107100">
							<FMmbr z="107101" o="0" sid="station3_midline_Standard" sN="Jangala Station" t="SHIP" iF="false" id="8ca0" sUN="false" civ="false" cCiv="false">
								<c z="107102" id="p_16c20" pid="steady" spr="graphics/portraits/eis_elsa.png" rnk="spaceLieutenant" pst="officer" wTCRC="0" cW="1.0" fid="hegemony" a="false" im="MEDIUM">
									<n z="107103" f="Farah" l="Themis" g="FEMALE"/>
									<m z="107104">
										<d z="107105">
											<e>
												<st>$voice</st>
												<st>soldier</st>
											</e>
										</d>
									</m>
									<stats z="107106" x2="0" xp="268000" bx="0" db="0" l="4" pt="0" sp="0">
										<s>{"ballistic_mastery":1,"ordnance_expert":1,"damage_control":1,"point_defense":2}</s>
									</stats>
								</c>
								<rT z="107107" cr="0.96095" crPTM="0.0" sR="false" mo="false" lCR="true">
									<m ref="107101"/>
								</rT>
								<fD ref="107099"/>
							</FMmbr>
						</m>
						<cargo z="107108" uS="true" mC="0.0" sU="237.0" mF="0.0" mP="0.0" fT="false">
							<s z="107109">
								<CIStack z="107110" rS="false" s="237.0" mS="1000000.0" cSPU="1.0" t="RESOURCES">
									<d cl="st">IndEvo_parts</d>
									<c ref="107108"/>
								</CIStack>
							</s>
							<c z="107111">
								<value>0.0</value>
							</c>
							<cF ref="107099"/>
						</cargo>
						<c z="107112" id="p_8c9f" pid="steady" spr="graphics/portraits/portrait_mercenary06.png" rnk="spaceCommander" pst="fleetCommander" wTCRC="0" cW="1.0" fid="hegemony" a="true" im="MEDIUM">
							<n z="107113" f="Light" l="Laval" g="MALE"/>
							<m z="107114">
								<d z="107115">
									<e>
										<st>$voice</st>
										<st>soldier</st>
									</e>
								</d>
							</m>
							<stats z="107116" x2="0" xp="0" bx="0" db="0" l="1" pt="0" sp="0">
								<fleet cl="Flt" ref="107090"/>
							</stats>
						</c>
						<f ref="107090"/>
					</fD>
					<mM z="107117" a="1.0" s="2.0" sC="true">
						<v z="107118">0.0|0.0</v>
						<l z="107119">0.0|0.0</l>
						<aV z="107120">0.0|0.0</aV>
						<d cl="Flt" ref="107090"/>
						<hardSpeedLimit>-1.0</hardSpeedLimit>
					</mM>
					<fM z="107121" a="150.0" m="100.0" r="0.0" f="90.0"/>
					<s z="107122">
						<tempMod z="107123">
							<timeRemaining>0.1</timeRemaining>
							<source>nav_buoy</source>
							<stat z="107124" fB="2.0" m="1.0" pM="0.0" nR="true">
								<fBs z="107125" s="nav_buoy" d="Makeshift nav buoy" v="2.0"/>
							</stat>
						</tempMod>
						<dynamic z="107126">
							<stats z="107127"/>
							<mods z="107128"/>
						</dynamic>
						<fMBM ref="107124"/>
						<dRM z="107129" fB="11000.0" m="1.0" pM="0.0" nR="false">
							<fBs z="107130" s="transponder_ability_mod" d="Transponder on" v="1000.0"/>
							<fBs z="107131" s="gen" v="10000.0"/>
							<mBs z="107132" s="core_PhaseField" d="Phase ships in fleet" v="1.0"/>
						</dRM>
					</s>
					<lgst z="107133">
						<f ref="107090"/>
					</lgst>
					<nCP z="107134" b="0.0" i="0.1" o="0.1" s="IDLE" d="true" u="true"/>
					<dL z="107135">
						<OrbitalStation z="107136" id="starfortress_mid" bP="0.0" b="false" wD="false" uES="true">
							<m cl="Market" ref="103808"/>
							<buildTime>1.0</buildTime>
							<dR z="107137" b="0.0" m="0.0"/>
							<sB z="107138" b="0.0" m="0.0">
								<fMs z="107139" s="ind_starfortress_mid_1" d="Administrator" v="1.0"/>
							</sB>
							<sF cl="Flt" ref="107090"/>
							<sE cl="CCEnt" ref="105983"/>
						</OrbitalStation>
					</dL>
					<inflater cl="DFInfl" z="107140">
						<p z="107141" s="-8453113639699797128" p="true" q="0.9375" m="PRIORITY_THEN_ALL">
							<allWeapons>true</allWeapons>
							<factionId>hegemony</factionId>
						</p>
					</inflater>
					<hidden>true</hidden>
				</Flt>
				<CCEnt z="107142" fL="STATIONS">
					<loc z="107143">-397.70013|-4735.385</loc>
					<vel z="107144">0.0|0.0</vel>
					<j0>{"f6":202.4997,"f0":"Jangala Animal Center","f2":[255,255,255,255],"f3":"IndEvo_AnimalCenter","f4":"8ca2"}</j0>
					<ow ref="873"/>
					<orbit cl="CircularOrbitWithSpin" z="107145" r="270.0" op="10.8" ca="244.78436" cF="202.4997" sV="-6.740734">
						<e cl="CCEnt" ref="107142"/>
						<f cl="Plnt" ref="104181"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107146">
						<d z="107147"/>
					</me>
					<market cl="Market" ref="103808"/>
					<sc z="107148"/>
					<tags z="107149">
						<st>IndEvo_PetShop</st>
					</tags>
					<j1>{"f0":40,"f1":40,"f2":40,"f3":-1,"f4":-1,"f5":"IndEvo_PetShop"}</j1>
					<la z="107150" enum-type="CaEnLa">STATIONS</la>
				</CCEnt>
				<CCEnt z="107151" fL="TERRAIN_1">
					<loc z="107152">0.0|0.0</loc>
					<vel z="107153">0.0|0.0</vel>
					<j0>{"f6":90,"f0":"","f2":[255,255,255,255],"f4":"luna_campaign_renderer_97ff"}</j0>
					<ow ref="13"/>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107154">
						<d z="107155"/>
					</me>
					<sc z="107156"/>
					<j1>{"f0":64,"f1":64,"f2":0,"f3":-1,"f4":-1,"f5":"luna_campaign_renderer"}</j1>
					<la z="107157" enum-type="CaEnLa">TERRAIN_1,TERRAIN_2,PLANETS,TERRAIN_3,RINGS,TERRAIN_4,ASTEROIDS,TERRAIN_5,JUMP_POINTS,TERRAIN_6,TERRAIN_6A,TERRAIN_6B,BELOW_STATIONS,STATIONS,ABOVE_STATIONS,TERRAIN_7,TERRAIN_7A,TERRAIN_SLIPSTREAM,FLEETS,TERRAIN_8,TERRAIN_9,TERRAIN_10,ABOVE</la>
					<p cl="lunalib.backend.scripts.LunaCampaignRendererEntity" z="107158">
						<e cl="CCEnt" ref="107151"/>
					</p>
				</CCEnt>
				<LocationToken z="107159">
					<loc z="107160">-7217.0605|-2725.7388</loc>
					<where cl="Sstm" ref="104188"/>
					<orbit cl="COrbt" z="107161" r="127.6" op="1000000.0" ca="332.3286">
						<e cl="LocationToken" ref="107159"/>
						<f cl="CCEnt" z="107162" fL="STATIONS">
							<loc z="107163">-7330.0664|-2666.4814</loc>
							<vel z="107164">0.0|0.0</vel>
							<j0>{"f6":199.99005,"f0":"Stable Location","f2":[255,255,255,255],"f3":"stable_location","f4":"35"}</j0>
							<ow ref="13"/>
							<orbit cl="COrbtPD" z="107165" r="7800.0" op="400.0" ca="199.99005">
								<e cl="CCEnt" ref="107162"/>
								<f cl="Plnt" ref="104185"/>
							</orbit>
							<cL cl="Sstm" ref="104188"/>
							<ls cl="Plnt" ref="104185"/>
							<me z="107166">
								<d z="107167">
									<e>
										<st>$COB_burstRange</st>
										<ip>15</ip>
									</e>
								</d>
								<e z="107168">
									<MExp z="107169" k="$COB_burstRange" t="0.0"/>
								</e>
							</me>
							<sc z="107170"/>
							<cV z="107171" sn="graphics/illustrations/free_orbit.jpg" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
							<tags z="107172">
								<st>stable_location</st>
								<st>has_interaction_dialog</st>
							</tags>
							<j1>{"f0":64,"f1":64,"f2":75,"f3":-1,"f4":-1,"f5":"stable_location"}</j1>
							<la z="107173" enum-type="CaEnLa">STATIONS</la>
						</f>
					</orbit>
					<id>451a6</id>
					<faction ref="13"/>
					<tags z="107174">
						<st>fading_out_and_expiring</st>
						<st>non_clickable</st>
					</tags>
					<memory z="107175">
						<d z="107176"/>
					</memory>
				</LocationToken>
				<CCEnt z="107177" fL="STATIONS">
					<loc z="107178">2763.6377|-7293.991</loc>
					<vel z="107179">0.0|0.0</vel>
					<j0>{"f6":290.75134,"f0":"Makeshift Nav Buoy","f2":[255,255,255,255],"f3":"nav_buoy_makeshift","f4":"4523e"}</j0>
					<ow ref="873"/>
					<orbit cl="COrbtPD" z="107180" r="7800.0" op="400.0" ca="290.75134">
						<e cl="CCEnt" ref="107177"/>
						<f cl="Plnt" ref="104185"/>
					</orbit>
					<cL cl="Sstm" ref="104188"/>
					<ls cl="Plnt" ref="104185"/>
					<me z="107181">
						<d z="107182">
							<e>
								<st>$originalStableLocation</st>
								<CCEnt ref="107162"/>
							</e>
						</d>
					</me>
					<sc z="107183"/>
					<cV z="107184" sn="graphics/illustrations/nav_buoy.jpg" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"/>
					<tags z="107185">
						<st>neutrino_high</st>
						<st>makeshift</st>
						<st>nav_buoy</st>
						<st>objective</st>
					</tags>
					<j1>{"f0":64,"f1":64,"f2":75,"f3":-1,"f4":-1,"f5":"nav_buoy_makeshift"}</j1>
					<la z="107186" enum-type="CaEnLa">STATIONS</la>
					<p cl="NexNavBuoy" z="107187">
						<e cl="CCEnt" ref="107177"/>
					</p>
				</CCEnt>
				<CCEnt ref="105006"/>
				<Flt ref="105002"/>
			</saved>
		</o>
		<b z="107188" hM="false">
			<bgO z="107189">336.667|671.7678</bgO>
			<s z="107190" o="graphics/backgrounds/background4.jpg" t="graphics/backgrounds/background2.jpg">
				<d cl="BackgroundAndStars" ref="107188"/>
			</s>
			<colorShifter z="107191">
				<b ref="9686"/>
				<c ref="9686"/>
				<d cl="l-h-m" z="107192"/>
			</colorShifter>
			<particleColorShifter z="107193">
				<b z="107194">191,191,191,200</b>
				<c ref="107194"/>
				<d cl="l-h-m" z="107195"/>
			</particleColorShifter>
			<wasShifted>false</wasShifted>
		</b>
		<hP z="107196" d="1.0" nF="1" lp="false" r="false" e="0.0" pr="0.0" cF="0" cL="0" sN="false" l="2000">
			<p z="107197"/>
		</hP>
		<l z="107198">400.0|-9400.0</l>
		<lC ref="9686"/>
		<lH z="107199" b="0.7097999" i="10.0" o="10.0" s="OUT" d="true" u="true"/>
		<fS z="107200"/>
		<pDat z="107201"/>
		<sPts z="107202"/>
		<scr z="107203"/>
		<activeThisFrame>false</activeThisFrame>
		<tags z="107204">
			<st>theme_core</st>
			<st>theme_core_populated</st>
		</tags>
		<memory z="107205">
			<d z="107206">
				<e>
					<st>$IndEvo_locatorSystemRating</st>
					<ip>130</ip>
				</e>
			</d>
		</memory>
		<age>OLD</age>
		<star ref="104185"/>
		<hA cl="LocationToken" ref="106018"/>
	</cL>
	<ls cl="Plnt" ref="104185"/>
	<me z="107207">
		<d z="107208"/>
	</me>
	<sc z="107209"/>
	<tags z="107210">
		<st>star</st>
	</tags>
	<angle>337.0008</angle>
	<cloudAngle>0.0</cloudAngle>
	<radius>775.0</radius>
	<type>star_yellow</type>
	<layers z="107211" enum-type="CaEnLa">PLANETS,ABOVE</layers>
</f>
```



----------------------------------------------------


Missing stars:
[0]		{{ Name: Gamma Madron; Id: 94756 }}	SystemFinder.Model.StarSystem
[1]		{{ Name: Alpha Madron; Id: 100213 }}	SystemFinder.Model.StarSystem
[2]		{{ Name: Gamma Zendar; Id: 371271 }}	SystemFinder.Model.StarSystem
[3]		{{ Name: Deep Space; Id: 14009 }}	SystemFinder.Model.StarSystem
[4]		{{ Name: Sea of Twilight; Id: 14138 }}	SystemFinder.Model.StarSystem
[5]		{{ Name: Sea of Dreams; Id: 14805 }}	SystemFinder.Model.StarSystem
[6]		{{ Name: Sea of Trust; Id: 15118 }}	SystemFinder.Model.StarSystem
[7]		{{ Name: Sea of Decay; Id: 15478 }}	SystemFinder.Model.StarSystem
[8]		{{ Name: Sea of Clouds; Id: 15761 }}	SystemFinder.Model.StarSystem
[9]		{{ Name: Sea of Time; Id: 16084 }}	SystemFinder.Model.StarSystem
[10]	{{ Name: Sea of Hope; Id: 16424 }}	SystemFinder.Model.StarSystem
[11]	{{ Name: Sea of Hatred; Id: 16797 }}	SystemFinder.Model.StarSystem
[12]	{{ Name: Sea of Sorrow; Id: 17173 }}	SystemFinder.Model.StarSystem
[13]	{{ Name: Sea of Serenity; Id: 18433 }}	SystemFinder.Model.StarSystem
[14]	{{ Name: Sea of Storms; Id: 18762 }}	SystemFinder.Model.StarSystem
[15]	{{ Name: Sea of Tranquilility; Id: 19118 }}	SystemFinder.Model.StarSystem
[16]	{{ Name: Sea of Luxury; Id: 22756 }}	SystemFinder.Model.StarSystem
[17]	{{ Name: Sea of Epidemics; Id: 23045 }}	SystemFinder.Model.StarSystem
[18]	{{ Name: Unknown Location; Id: 356534 }}	SystemFinder.Model.StarSystem
[19]	{{ Name: Delta Site; Id: 378945 }}	SystemFinder.Model.StarSystem
[20]	{{ Name: Deep Space; Id: 418488 }}	SystemFinder.Model.StarSystem
