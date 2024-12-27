document.addEventListener("DOMContentLoaded", function () {
    var container = document.querySelector("#unity-container");
    var canvas = document.querySelector("#unity-canvas");
    var loadingBar = document.querySelector("#unity-loading-bar");
    var progressBarFull = document.querySelector("#unity-progress-bar-full");
    var fullscreenButton = document.querySelector("#unity-fullscreen-button");
    var warningBanner = document.querySelector("#unity-warning");

    // Supprimez les dimensions explicites
    canvas.style.width = "100%";
    canvas.style.height = "100%";

    // Initialisation de Unity
    var buildUrl = "Build";
    var loaderUrl = buildUrl + "/GolfOcean334.github.io.loader.js";
    var config = {
        dataUrl: buildUrl + "/GolfOcean334.github.io.data.br",
        frameworkUrl: buildUrl + "/GolfOcean334.github.io.framework.js.br",
        codeUrl: buildUrl + "/GolfOcean334.github.io.wasm.br",
        streamingAssetsUrl: "StreamingAssets",
        companyName: "GolfOcean33",
        productName: "Web Site",
        productVersion: "0.1.0",
    };

    if (/iPhone|iPad|iPod|Android/i.test(navigator.userAgent)) {
        var meta = document.createElement("meta");
        meta.name = "viewport";
        meta.content =
            "width=device-width, height=device-height, initial-scale=1.0, user-scalable=no, shrink-to-fit=yes";
        document.getElementsByTagName("head")[0].appendChild(meta);
    }

    loadingBar.style.display = "block";

    var script = document.createElement("script");
    script.src = loaderUrl;
    script.onload = () => {
        createUnityInstance(canvas, config, (progress) => {
            progressBarFull.style.width = 100 * progress + "%";
        })
            .then((unityInstance) => {
                loadingBar.style.display = "none";
                fullscreenButton.onclick = () => {
                    unityInstance.SetFullscreen(1);
                };
            })
            .catch((message) => {
                alert(message);
            });
    };

    document.body.appendChild(script);
});
