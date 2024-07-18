Gate: (scanned) -- TBD where is this set
CCEnt z, fL="STATIONS"
	<loc z="106037">5863.086|1274.4498</loc>
	<vel z="106038">0.0|0.0</vel>
	<j0>{"f6":90,"f0":"Corvus Gate","f2":[255,255,255,255],"f3":"inactive_gate","f4":"jangala_gate"}</j0>
	
	<cL cl="Sstm" ref="104188"></cL> what system the station exists under
	
	Tags (if it matters)
	<tags z="106044">
	<st>gate</st>
	<st>neutrino</st>
	</tags>
	
	
	
<CCEnt z="106036" fL="STATIONS">
	<loc z="106037">5863.086|1274.4498</loc>
	<vel z="106038">0.0|0.0</vel>
	<j0>{"f6":90,"f0":"Corvus Gate","f2":[255,255,255,255],"f3":"inactive_gate","f4":"jangala_gate"}</j0>
	<ow ref="13"></ow>
	<orbit cl="COrbt" z="106039" r="6000.0" op="350.0" ca="12.263519">
		<e cl="CCEnt" ref="106036"></e>
		<f cl="Plnt" ref="104185"></f>
	</orbit>
	<cL cl="Sstm" ref="104188"></cL>
	<ls cl="Plnt" ref="104185"></ls>
	<me z="106040">
		<d z="106041"></d>
	</me>
	<sc z="106042"></sc>
	<cV z="106043" sn="graphics/illustrations/dead_gate.jpg" sIW="480.0" sIH="300.0" sRSI="true" sIX="0.0" sIY="0.0" sIDW="480.0" sIWH="300.0"></cV>
	<tags z="106044">
		<st>gate</st>
		<st>neutrino</st>
	</tags>
	<j1>{"f0":192,"f1":192,"f2":120,"f3":-1,"f4":-1,"f5":"inactive_gate"}</j1>
	<la z="106045" enum-type="CaEnLa">BELOW_STATIONS,STATIONS</la>
	<p cl="GateEntityPlugin" z="106046" mA="false" aI="true" sBUD="0.0" aTDLY="0.0" iUA="0.0">
		<e cl="CCEnt" ref="106036"></e>
		<bUF z="106047" b="0.0" i="1.0" o="1.0" s="IDLE" d="true" u="false"></bUF>
		<gF z="106048" b="0.0" i="1.0" o="1.0" s="IDLE" d="true" u="true"></gF>
	</p>
</CCEnt>