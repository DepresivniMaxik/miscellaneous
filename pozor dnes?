// Tohle je JS kod pro IOS shortcut, ktery se pouzije nejlepe v aplikaci Scriptable
// Logika: opakovaně získává hodnoty (body, maxBody, váhu), dokud uživatel nezadá 'exit'.
// Poté vypočítá vážený průměr v  procentech a zobrazí výsledek.

async function getInput(prompt) {
  let alert = new Alert();
  alert.title = prompt;
  alert.addTextField();
  alert.addAction("OK");
  alert.addCancelAction("Cancel");
  let response = await alert.present();
  if (response === -1) return null; // Cancel pressed
  let text = alert.textFieldValue(0).trim();
  return text;
}

async function main() {
  let bodyList = [];
  let maxBodyList = [];
  let vahaList = [];

  while (true) {
    let bodyInput = await getInput("Zadejte získané body (nebo 'exit' pro ukončení):");
    if (bodyInput === null || bodyInput.toLowerCase() === "exit") break;

    let ziskaneBody = parseFloat(bodyInput);
    if (isNaN(ziskaneBody)) {
      await showMessage("Neplatný vstup pro získané body. Zkuste to znovu.");
      continue;
    }

    let maxBodInput = await getInput("Zadejte maximální počet bodů:");
    if (maxBodInput === null) break;
    let maxBod = parseFloat(maxBodInput);
    if (isNaN(maxBod) || maxBod <= 0) {
      await showMessage("Neplatný vstup pro maximální počet bodů. Zkuste to znovu.");
      continue;
    }

    let vahaInput = await getInput("Zadejte váhu (1-10):");
    if (vahaInput === null) break;
    let vahaZnamky = parseFloat(vahaInput);
    if (isNaN(vahaZnamky) || vahaZnamky < 1 || vahaZnamky > 10) {
      await showMessage("Neplatná váha. Zadejte číslo od 1 do 10.");
      continue;
    }

    bodyList.push(ziskaneBody);
    maxBodyList.push(maxBod);
    vahaList.push(vahaZnamky);
  }

  if (bodyList.length === 0) {
    await showMessage("Nebyla zadána žádná známka.");
    return;
  }

  let prumer = vypocetPrumeru(bodyList, maxBodyList, vahaList);
  await showMessage(`Celkový průměr: ${prumer.toFixed(2)}%`);
}

function vypocetPrumeru(body, maxBody, vaha) {
  let soucet = 0;
  let soucetVah = 0;
  for (let i = 0; i < body.length; i++) {
    let normalizovaneBody = (body[i] / maxBody[i]) * vaha[i];
    soucet += normalizovaneBody;
    soucetVah += vaha[i];
  }
  return soucetVah > 0 ? (soucet / soucetVah) * 100 : 0;
}

async function showMessage(message) {
  let alert = new Alert();
  alert.message = message;
  alert.addAction("OK");
  await alert.present();
}

await main();


