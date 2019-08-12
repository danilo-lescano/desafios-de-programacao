var aux = document.getElementsByClassName("gameListRow");
var els = [];
for (var i = 0; i < aux.length; i++)
	els[i] = [aux[i], 0];

var games_list = [];
function addGame(el){
	for(let j = 0; j < games_list.length; j++){
		if(games_list[j] === el.id){
			el.style.backgroundColor = "#15202d";
			games_list.splice(j, 1);
			return;
		}
	}
	el.style.backgroundColor = "#f0f";
	games_list[games_list.length] = el.id;
}
function findHours(el){
	var num = parseFloat(el.children[1].children[1].innerHTML.split(" horas registradas")[0].replace(",", ""));
	if(!num)
		num = 0;
	return num;
}
function blackList(el){
	var black_list = ["game_314020", "game_291010", "game_368990", "game_92100", "game_341500", "game_301480", "game_234390", "game_339000", "game_266450", "game_335240", "game_253980", "game_286360", "game_307170", "game_327410", "game_253900", "game_29800", "game_351030", "game_204180", "game_452920", "game_283290", "game_257890", "game_4920", "game_307070", "game_250580", "game_210770", "game_253940", "game_92800", "game_104200", "game_330350", "game_2500", "game_292380", "game_40970", "game_35720", "game_297020", "game_15700", "game_96100", "game_209670", "game_238320", "game_251690", "game_236830", "game_286200", "game_262150", "game_225420", "game_301750", "game_292630", "game_313020", "game_113200", "game_300540", "game_275490", "game_108710", "game_203630", "game_233270", "game_355520", "game_251530", "game_49520", "game_236150", "game_203770", "game_233130", "game_11200", "game_606330", "game_303390", "game_11280", "game_41070", "game_368230", "game_224420", "game_34900", "game_300220", "game_104900", "game_105600", "game_200510", "game_587790", "game_591560", "game_24240", "game_57690", "game_261640", "game_271860", "game_263200", "game_444490", "game_576880", "game_598470", "game_566060", "game_347560", "game_351150", "game_220090", "game_1930", "game_610930", "game_412290", "game_513590", "game_448630", "game_576120", "game_270550", "game_334210", "game_318600", "game_234650", "game_412210", "game_438020", "game_238370", "game_391720", "game_262060", "game_388320", "game_485580", "game_403740", "game_576130", "game_265590", "game_447920", "game_438180", "game_439190", "game_587830", "game_313830", "game_730050", "game_357290", "game_429700", "game_271640", "game_72400", "game_343360", "game_533820", "game_508180", "game_491650", "game_444260", "game_468490", "game_563120", "game_556280", "game_567280", "game_508670", "game_349500", "game_416040", "game_285420", "game_473470", "game_40980", "game_274900", "game_460960", "game_463350", "game_434420", "game_280910", "game_222880", "game_315430", "game_467950", "game_377290", "game_463210", "game_528660", "game_257510", "game_438030", "game_254060", "game_467010", "game_420740", "game_269210", "game_431710", "game_292410", "game_416080", "game_400240", "game_527990", "game_397500", "game_281920", "game_391070", "game_576560", "game_485950", "game_314450", "game_441870", "game_391420", "game_399790", "game_258220", "game_410210", "game_556870", "game_396160", "game_333740", "game_338710", "game_444220", "game_509220", "game_204880", "game_505210", "game_357070", "game_219910", "game_339160", "game_268540", "game_243200", "game_230820", "game_365450", "game_243780", "game_209080", "game_303510", "game_380020", "game_485450", "game_448780", "game_422250", "game_212910", "game_311860", "game_214340", "game_509570", "game_329000", "game_377600", "game_343710", "game_734920", "game_433950", "game_715010", "game_680360", "game_292030", "game_40960", "game_70000", "game_299720", "game_448440", "game_391260", "game_486150", "game_308600", "game_40950", "game_344040", "game_435150", "game_312640", "game_231430", "game_209170", "game_341310", "game_360640", "game_370100", "game_360650", "game_306040", "game_344910", "game_375510", "game_383330", "game_391740", "game_202990", "game_295690", "game_399430", "game_318430", "game_383580", "game_366890", "game_326180", "game_18820", "game_403560", "game_355150", "game_331790", "game_407230", "game_364270", "game_285840", "game_35450", "game_267980", "game_335430", "game_293180", "game_360380", "game_264240", "game_201570", "game_274560", "game_338050", "game_239450", "game_238240", "game_287120", "game_238910", "game_400250", "game_371390", "game_304390", "game_371440", "game_396790", "game_382490", "game_115110", "game_289130", "game_429470", "game_364690", "game_347430", "game_378100", "game_382120", "game_439250", "game_351490", "game_257050", "game_428430", "game_453980", "game_319180", "game_407300", "game_370510", "game_485330", "game_394540", "game_461640", "game_446640", "game_454890", "game_457820", "game_233250", "game_438010", "game_454200", "game_423710", "game_371670", "game_444460", "game_463220", "game_453820", "game_467000", "game_405610", "game_448640", "game_340650", "game_440760", "game_296870", "game_340070", "game_391660", "game_462960", "game_412170", "game_385080", "game_444480", "game_317250", "game_385070", "game_461140"];
	for(let j = 0; j < black_list.length; j++){
		if(el.id === black_list[j]){
			el.children[1].children[1].innerHTML = "";
			return true;
		}
	}
	return false;
}

for(let i = 0; i < els.length; i++){
	//els[0][i].onclick = ()=>{addGame(els[0][i]);};
	els[i][1] = blackList(els[i][0]) ? 0 : findHours(els[i][0]);
}

els.sort(function(a, b) {
  return b[1] - a[1];
});

for(let i = 0; i < els.length; i++){
	document.getElementById("games_list_rows").appendChild(els[i][0]);
}