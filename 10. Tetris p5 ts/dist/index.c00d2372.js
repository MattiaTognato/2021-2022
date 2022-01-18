// modules are defined as an array
// [ module function, map of requires ]
//
// map of requires is short require name -> numeric require
//
// anything defined in a previous bundle is accessed via the
// orig method which is the require for previous bundles

(function (modules, entry, mainEntry, parcelRequireName, globalName) {
  /* eslint-disable no-undef */
  var globalObject =
    typeof globalThis !== 'undefined'
      ? globalThis
      : typeof self !== 'undefined'
      ? self
      : typeof window !== 'undefined'
      ? window
      : typeof global !== 'undefined'
      ? global
      : {};
  /* eslint-enable no-undef */

  // Save the require from previous bundle to this closure if any
  var previousRequire =
    typeof globalObject[parcelRequireName] === 'function' &&
    globalObject[parcelRequireName];

  var cache = previousRequire.cache || {};
  // Do not use `require` to prevent Webpack from trying to bundle this call
  var nodeRequire =
    typeof module !== 'undefined' &&
    typeof module.require === 'function' &&
    module.require.bind(module);

  function newRequire(name, jumped) {
    if (!cache[name]) {
      if (!modules[name]) {
        // if we cannot find the module within our internal map or
        // cache jump to the current global require ie. the last bundle
        // that was added to the page.
        var currentRequire =
          typeof globalObject[parcelRequireName] === 'function' &&
          globalObject[parcelRequireName];
        if (!jumped && currentRequire) {
          return currentRequire(name, true);
        }

        // If there are other bundles on this page the require from the
        // previous one is saved to 'previousRequire'. Repeat this as
        // many times as there are bundles until the module is found or
        // we exhaust the require chain.
        if (previousRequire) {
          return previousRequire(name, true);
        }

        // Try the node require function if it exists.
        if (nodeRequire && typeof name === 'string') {
          return nodeRequire(name);
        }

        var err = new Error("Cannot find module '" + name + "'");
        err.code = 'MODULE_NOT_FOUND';
        throw err;
      }

      localRequire.resolve = resolve;
      localRequire.cache = {};

      var module = (cache[name] = new newRequire.Module(name));

      modules[name][0].call(
        module.exports,
        localRequire,
        module,
        module.exports,
        this
      );
    }

    return cache[name].exports;

    function localRequire(x) {
      var res = localRequire.resolve(x);
      return res === false ? {} : newRequire(res);
    }

    function resolve(x) {
      var id = modules[name][1][x];
      return id != null ? id : x;
    }
  }

  function Module(moduleName) {
    this.id = moduleName;
    this.bundle = newRequire;
    this.exports = {};
  }

  newRequire.isParcelRequire = true;
  newRequire.Module = Module;
  newRequire.modules = modules;
  newRequire.cache = cache;
  newRequire.parent = previousRequire;
  newRequire.register = function (id, exports) {
    modules[id] = [
      function (require, module) {
        module.exports = exports;
      },
      {},
    ];
  };

  Object.defineProperty(newRequire, 'root', {
    get: function () {
      return globalObject[parcelRequireName];
    },
  });

  globalObject[parcelRequireName] = newRequire;

  for (var i = 0; i < entry.length; i++) {
    newRequire(entry[i]);
  }

  if (mainEntry) {
    // Expose entry point to Node, AMD or browser globals
    // Based on https://github.com/ForbesLindesay/umd/blob/master/template.js
    var mainExports = newRequire(mainEntry);

    // CommonJS
    if (typeof exports === 'object' && typeof module !== 'undefined') {
      module.exports = mainExports;

      // RequireJS
    } else if (typeof define === 'function' && define.amd) {
      define(function () {
        return mainExports;
      });

      // <script>
    } else if (globalName) {
      this[globalName] = mainExports;
    }
  }
})({"1DDSm":[function(require,module,exports) {
var HMR_HOST = null;
var HMR_PORT = null;
var HMR_SECURE = false;
var HMR_ENV_HASH = "4a236f9275d0a351";
module.bundle.HMR_BUNDLE_ID = "0a17b4afc00d2372";
"use strict";
function _toConsumableArray(arr) {
    return _arrayWithoutHoles(arr) || _iterableToArray(arr) || _unsupportedIterableToArray(arr) || _nonIterableSpread();
}
function _nonIterableSpread() {
    throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.");
}
function _iterableToArray(iter) {
    if (typeof Symbol !== "undefined" && Symbol.iterator in Object(iter)) return Array.from(iter);
}
function _arrayWithoutHoles(arr) {
    if (Array.isArray(arr)) return _arrayLikeToArray(arr);
}
function _createForOfIteratorHelper(o, allowArrayLike) {
    var it;
    if (typeof Symbol === "undefined" || o[Symbol.iterator] == null) {
        if (Array.isArray(o) || (it = _unsupportedIterableToArray(o)) || allowArrayLike && o && typeof o.length === "number") {
            if (it) o = it;
            var i = 0;
            var F = function F() {
            };
            return {
                s: F,
                n: function n() {
                    if (i >= o.length) return {
                        done: true
                    };
                    return {
                        done: false,
                        value: o[i++]
                    };
                },
                e: function e(_e) {
                    throw _e;
                },
                f: F
            };
        }
        throw new TypeError("Invalid attempt to iterate non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.");
    }
    var normalCompletion = true, didErr = false, err;
    return {
        s: function s() {
            it = o[Symbol.iterator]();
        },
        n: function n() {
            var step = it.next();
            normalCompletion = step.done;
            return step;
        },
        e: function e(_e2) {
            didErr = true;
            err = _e2;
        },
        f: function f() {
            try {
                if (!normalCompletion && it.return != null) it.return();
            } finally{
                if (didErr) throw err;
            }
        }
    };
}
function _unsupportedIterableToArray(o, minLen) {
    if (!o) return;
    if (typeof o === "string") return _arrayLikeToArray(o, minLen);
    var n = Object.prototype.toString.call(o).slice(8, -1);
    if (n === "Object" && o.constructor) n = o.constructor.name;
    if (n === "Map" || n === "Set") return Array.from(o);
    if (n === "Arguments" || /^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(n)) return _arrayLikeToArray(o, minLen);
}
function _arrayLikeToArray(arr, len) {
    if (len == null || len > arr.length) len = arr.length;
    for(var i = 0, arr2 = new Array(len); i < len; i++)arr2[i] = arr[i];
    return arr2;
}
/* global HMR_HOST, HMR_PORT, HMR_ENV_HASH, HMR_SECURE */ /*::
import type {
  HMRAsset,
  HMRMessage,
} from '@parcel/reporter-dev-server/src/HMRServer.js';
interface ParcelRequire {
  (string): mixed;
  cache: {|[string]: ParcelModule|};
  hotData: mixed;
  Module: any;
  parent: ?ParcelRequire;
  isParcelRequire: true;
  modules: {|[string]: [Function, {|[string]: string|}]|};
  HMR_BUNDLE_ID: string;
  root: ParcelRequire;
}
interface ParcelModule {
  hot: {|
    data: mixed,
    accept(cb: (Function) => void): void,
    dispose(cb: (mixed) => void): void,
    // accept(deps: Array<string> | string, cb: (Function) => void): void,
    // decline(): void,
    _acceptCallbacks: Array<(Function) => void>,
    _disposeCallbacks: Array<(mixed) => void>,
  |};
}
declare var module: {bundle: ParcelRequire, ...};
declare var HMR_HOST: string;
declare var HMR_PORT: string;
declare var HMR_ENV_HASH: string;
declare var HMR_SECURE: boolean;
*/ var OVERLAY_ID = '__parcel__error__overlay__';
var OldModule = module.bundle.Module;
function Module(moduleName) {
    OldModule.call(this, moduleName);
    this.hot = {
        data: module.bundle.hotData,
        _acceptCallbacks: [],
        _disposeCallbacks: [],
        accept: function accept(fn) {
            this._acceptCallbacks.push(fn || function() {
            });
        },
        dispose: function dispose(fn) {
            this._disposeCallbacks.push(fn);
        }
    };
    module.bundle.hotData = undefined;
}
module.bundle.Module = Module;
var checkedAssets, acceptedAssets, assetsToAccept;
function getHostname() {
    return HMR_HOST || (location.protocol.indexOf('http') === 0 ? location.hostname : 'localhost');
}
function getPort() {
    return HMR_PORT || location.port;
} // eslint-disable-next-line no-redeclare
var parent = module.bundle.parent;
if ((!parent || !parent.isParcelRequire) && typeof WebSocket !== 'undefined') {
    var hostname = getHostname();
    var port = getPort();
    var protocol = HMR_SECURE || location.protocol == 'https:' && !/localhost|127.0.0.1|0.0.0.0/.test(hostname) ? 'wss' : 'ws';
    var ws = new WebSocket(protocol + '://' + hostname + (port ? ':' + port : '') + '/'); // $FlowFixMe
    ws.onmessage = function(event) {
        checkedAssets = {
        };
        acceptedAssets = {
        };
        assetsToAccept = [];
        var data = JSON.parse(event.data);
        if (data.type === 'update') {
            // Remove error overlay if there is one
            if (typeof document !== 'undefined') removeErrorOverlay();
            var assets = data.assets.filter(function(asset) {
                return asset.envHash === HMR_ENV_HASH;
            }); // Handle HMR Update
            var handled = assets.every(function(asset) {
                return asset.type === 'css' || asset.type === 'js' && hmrAcceptCheck(module.bundle.root, asset.id, asset.depsByBundle);
            });
            if (handled) {
                console.clear();
                assets.forEach(function(asset) {
                    hmrApply(module.bundle.root, asset);
                });
                for(var i = 0; i < assetsToAccept.length; i++){
                    var id = assetsToAccept[i][1];
                    if (!acceptedAssets[id]) hmrAcceptRun(assetsToAccept[i][0], id);
                }
            } else window.location.reload();
        }
        if (data.type === 'error') {
            // Log parcel errors to console
            var _iterator = _createForOfIteratorHelper(data.diagnostics.ansi), _step;
            try {
                for(_iterator.s(); !(_step = _iterator.n()).done;){
                    var ansiDiagnostic = _step.value;
                    var stack = ansiDiagnostic.codeframe ? ansiDiagnostic.codeframe : ansiDiagnostic.stack;
                    console.error('🚨 [parcel]: ' + ansiDiagnostic.message + '\n' + stack + '\n\n' + ansiDiagnostic.hints.join('\n'));
                }
            } catch (err) {
                _iterator.e(err);
            } finally{
                _iterator.f();
            }
            if (typeof document !== 'undefined') {
                // Render the fancy html overlay
                removeErrorOverlay();
                var overlay = createErrorOverlay(data.diagnostics.html); // $FlowFixMe
                document.body.appendChild(overlay);
            }
        }
    };
    ws.onerror = function(e) {
        console.error(e.message);
    };
    ws.onclose = function() {
        console.warn('[parcel] 🚨 Connection to the HMR server was lost');
    };
}
function removeErrorOverlay() {
    var overlay = document.getElementById(OVERLAY_ID);
    if (overlay) {
        overlay.remove();
        console.log('[parcel] ✨ Error resolved');
    }
}
function createErrorOverlay(diagnostics) {
    var overlay = document.createElement('div');
    overlay.id = OVERLAY_ID;
    var errorHTML = '<div style="background: black; opacity: 0.85; font-size: 16px; color: white; position: fixed; height: 100%; width: 100%; top: 0px; left: 0px; padding: 30px; font-family: Menlo, Consolas, monospace; z-index: 9999;">';
    var _iterator2 = _createForOfIteratorHelper(diagnostics), _step2;
    try {
        for(_iterator2.s(); !(_step2 = _iterator2.n()).done;){
            var diagnostic = _step2.value;
            var stack = diagnostic.codeframe ? diagnostic.codeframe : diagnostic.stack;
            errorHTML += "\n      <div>\n        <div style=\"font-size: 18px; font-weight: bold; margin-top: 20px;\">\n          \uD83D\uDEA8 ".concat(diagnostic.message, "\n        </div>\n        <pre>").concat(stack, "</pre>\n        <div>\n          ").concat(diagnostic.hints.map(function(hint) {
                return '<div>💡 ' + hint + '</div>';
            }).join(''), "\n        </div>\n        ").concat(diagnostic.documentation ? "<div>\uD83D\uDCDD <a style=\"color: violet\" href=\"".concat(diagnostic.documentation, "\" target=\"_blank\">Learn more</a></div>") : '', "\n      </div>\n    ");
        }
    } catch (err) {
        _iterator2.e(err);
    } finally{
        _iterator2.f();
    }
    errorHTML += '</div>';
    overlay.innerHTML = errorHTML;
    return overlay;
}
function getParents(bundle, id) /*: Array<[ParcelRequire, string]> */ {
    var modules = bundle.modules;
    if (!modules) return [];
    var parents = [];
    var k, d, dep;
    for(k in modules)for(d in modules[k][1]){
        dep = modules[k][1][d];
        if (dep === id || Array.isArray(dep) && dep[dep.length - 1] === id) parents.push([
            bundle,
            k
        ]);
    }
    if (bundle.parent) parents = parents.concat(getParents(bundle.parent, id));
    return parents;
}
function updateLink(link) {
    var newLink = link.cloneNode();
    newLink.onload = function() {
        if (link.parentNode !== null) // $FlowFixMe
        link.parentNode.removeChild(link);
    };
    newLink.setAttribute('href', link.getAttribute('href').split('?')[0] + '?' + Date.now()); // $FlowFixMe
    link.parentNode.insertBefore(newLink, link.nextSibling);
}
var cssTimeout = null;
function reloadCSS() {
    if (cssTimeout) return;
    cssTimeout = setTimeout(function() {
        var links = document.querySelectorAll('link[rel="stylesheet"]');
        for(var i = 0; i < links.length; i++){
            // $FlowFixMe[incompatible-type]
            var href = links[i].getAttribute('href');
            var hostname = getHostname();
            var servedFromHMRServer = hostname === 'localhost' ? new RegExp('^(https?:\\/\\/(0.0.0.0|127.0.0.1)|localhost):' + getPort()).test(href) : href.indexOf(hostname + ':' + getPort());
            var absolute = /^https?:\/\//i.test(href) && href.indexOf(window.location.origin) !== 0 && !servedFromHMRServer;
            if (!absolute) updateLink(links[i]);
        }
        cssTimeout = null;
    }, 50);
}
function hmrApply(bundle, asset) {
    var modules = bundle.modules;
    if (!modules) return;
    if (asset.type === 'css') reloadCSS();
    else if (asset.type === 'js') {
        var deps = asset.depsByBundle[bundle.HMR_BUNDLE_ID];
        if (deps) {
            if (modules[asset.id]) {
                // Remove dependencies that are removed and will become orphaned.
                // This is necessary so that if the asset is added back again, the cache is gone, and we prevent a full page reload.
                var oldDeps = modules[asset.id][1];
                for(var dep in oldDeps)if (!deps[dep] || deps[dep] !== oldDeps[dep]) {
                    var id = oldDeps[dep];
                    var parents = getParents(module.bundle.root, id);
                    if (parents.length === 1) hmrDelete(module.bundle.root, id);
                }
            }
            var fn = new Function('require', 'module', 'exports', asset.output);
            modules[asset.id] = [
                fn,
                deps
            ];
        } else if (bundle.parent) hmrApply(bundle.parent, asset);
    }
}
function hmrDelete(bundle, id1) {
    var modules = bundle.modules;
    if (!modules) return;
    if (modules[id1]) {
        // Collect dependencies that will become orphaned when this module is deleted.
        var deps = modules[id1][1];
        var orphans = [];
        for(var dep in deps){
            var parents = getParents(module.bundle.root, deps[dep]);
            if (parents.length === 1) orphans.push(deps[dep]);
        } // Delete the module. This must be done before deleting dependencies in case of circular dependencies.
        delete modules[id1];
        delete bundle.cache[id1]; // Now delete the orphans.
        orphans.forEach(function(id) {
            hmrDelete(module.bundle.root, id);
        });
    } else if (bundle.parent) hmrDelete(bundle.parent, id1);
}
function hmrAcceptCheck(bundle, id, depsByBundle) {
    if (hmrAcceptCheckOne(bundle, id, depsByBundle)) return true;
     // Traverse parents breadth first. All possible ancestries must accept the HMR update, or we'll reload.
    var parents = getParents(module.bundle.root, id);
    var accepted = false;
    while(parents.length > 0){
        var v = parents.shift();
        var a = hmrAcceptCheckOne(v[0], v[1], null);
        if (a) // If this parent accepts, stop traversing upward, but still consider siblings.
        accepted = true;
        else {
            // Otherwise, queue the parents in the next level upward.
            var p = getParents(module.bundle.root, v[1]);
            if (p.length === 0) {
                // If there are no parents, then we've reached an entry without accepting. Reload.
                accepted = false;
                break;
            }
            parents.push.apply(parents, _toConsumableArray(p));
        }
    }
    return accepted;
}
function hmrAcceptCheckOne(bundle, id, depsByBundle) {
    var modules = bundle.modules;
    if (!modules) return;
    if (depsByBundle && !depsByBundle[bundle.HMR_BUNDLE_ID]) {
        // If we reached the root bundle without finding where the asset should go,
        // there's nothing to do. Mark as "accepted" so we don't reload the page.
        if (!bundle.parent) return true;
        return hmrAcceptCheck(bundle.parent, id, depsByBundle);
    }
    if (checkedAssets[id]) return true;
    checkedAssets[id] = true;
    var cached = bundle.cache[id];
    assetsToAccept.push([
        bundle,
        id
    ]);
    if (!cached || cached.hot && cached.hot._acceptCallbacks.length) return true;
}
function hmrAcceptRun(bundle, id) {
    var cached = bundle.cache[id];
    bundle.hotData = {
    };
    if (cached && cached.hot) cached.hot.data = bundle.hotData;
    if (cached && cached.hot && cached.hot._disposeCallbacks.length) cached.hot._disposeCallbacks.forEach(function(cb) {
        cb(bundle.hotData);
    });
    delete bundle.cache[id];
    bundle(id);
    cached = bundle.cache[id];
    if (cached && cached.hot && cached.hot._acceptCallbacks.length) cached.hot._acceptCallbacks.forEach(function(cb) {
        var assetsToAlsoAccept = cb(function() {
            return getParents(module.bundle.root, id);
        });
        if (assetsToAlsoAccept && assetsToAccept.length) // $FlowFixMe[method-unbinding]
        assetsToAccept.push.apply(assetsToAccept, assetsToAlsoAccept);
    });
    acceptedAssets[id] = true;
}

},{}],"9Rlze":[function(require,module,exports) {
"use strict";
Object.defineProperty(exports, "__esModule", {
    value: true
});
var Block_1 = require("./Block");
var grid_1 = require("./grid");
var gridMoving_1 = require("./gridMoving");
var grid;
var gridMoving;
var col = 20;
var row = 10;
var wCell = 30;
var timerAuto = 0;
var timerLR = 0;
var timerDown = 0;
var keyProgressionLR = 0;
globalThis.setup = function() {
    createCanvas(row * wCell, col * wCell);
    grid = new grid_1.Grid(col, row, wCell);
    gridMoving = new gridMoving_1.GridMoving(grid, col, row, wCell);
    gridMoving.addBlock(new Block_1.Block(Math.floor(Math.random() * 7), width / 2 / wCell, wCell));
    background(33, 66, 115);
    grid.show();
    gridMoving.show();
};
globalThis.draw = function() {
    background(33, 66, 115);
    if (millis() >= 1000 + timerAuto) {
        moveDown(); //Ogni secondo sposta il blocchetto in giù
        timerAuto = millis();
    }
    if (keyIsDown(RIGHT_ARROW)) {
        if (keyProgressionLR < 2 && millis() >= 100 + timerLR) {
            gridMoving.moveBlock("right");
            keyProgressionLR++;
            timerLR = millis();
        } else if (keyProgressionLR == 2 && millis() >= 50 + timerLR) {
            gridMoving.moveBlock("right");
            timerLR = millis();
        }
    } else if (keyIsDown(LEFT_ARROW)) {
        if (keyProgressionLR < 2 && millis() >= 150 + timerLR) {
            gridMoving.moveBlock("left");
            keyProgressionLR++;
            timerLR = millis();
        } else if (keyProgressionLR == 2 && millis() >= 50 + timerLR) {
            gridMoving.moveBlock("left");
            timerLR = millis();
        }
    }
    if (keyIsDown(DOWN_ARROW)) {
        if (millis() >= 50 + timerDown) {
            moveDown();
            timerDown = millis();
        }
    }
    background(33, 66, 115);
    grid.show();
    gridMoving.show();
};
function moveDown() {
    var stoppedBlockAndCreateBlock = gridMoving.movingDown(); // moving down ritorna un blocco quando un un blocco si ferma e dice se creare o no un'altro blocco
    if (stoppedBlockAndCreateBlock[1] == true && stoppedBlockAndCreateBlock[0] != undefined && stoppedBlockAndCreateBlock[0] != undefined) {
        grid.addBlock(stoppedBlockAndCreateBlock[0]); // aggiungo il blocco che si è fermato alla griglia dei blocchi fermi
        gridMoving.addBlock(new Block_1.Block(Math.floor(Math.random() * 7), width / 2 / wCell, wCell)); //aggiungo un nuovo blocco in movimento
        var fullLinesIndexes = grid.checkFullLines();
        if (fullLinesIndexes.length > 0) grid.deleteLines(fullLinesIndexes);
    } else if (stoppedBlockAndCreateBlock[1] == true) gridMoving.addBlock(new Block_1.Block(Math.floor(Math.random() * 7), width / 2 / wCell, wCell)); //aggiungo un blocco in movimento in caso non ce ne siano
}
globalThis.keyPressed = function() {
    if (key == "ArrowUp") gridMoving.rotateBlock();
};
globalThis.keyReleased = function() {
    if (key == "ArrowLeft") keyProgressionLR = 0;
    if (key == "ArrowRight") keyProgressionLR = 0;
};

},{"./Block":"ecSgA","./grid":"l3V1X","./gridMoving":"b9kLz"}],"ecSgA":[function(require,module,exports) {
"use strict";
Object.defineProperty(exports, "__esModule", {
    value: true
});
exports.Block = void 0;
var Cell_1 = require("./Cell");
var Block = function() {
    function Block1(typeOfBlock, spawnX, wCell) {
        this.cells = [];
        this.typeOfBlock = typeOfBlock;
        this.wCell = wCell;
        switch(this.typeOfBlock){
            case 0:
                this.rotationShapes = [
                    [
                        [
                            0,
                            0
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            0,
                            2
                        ],
                        [
                            0,
                            3
                        ]
                    ],
                    [
                        [
                            -1,
                            1
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            1,
                            1
                        ],
                        [
                            2,
                            1
                        ]
                    ]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 1:
                this.rotationShapes = [
                    [
                        [
                            0,
                            0
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            0,
                            2
                        ],
                        [
                            -1,
                            2
                        ]
                    ],
                    [
                        [
                            1,
                            2
                        ],
                        [
                            -1,
                            1
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            1,
                            1
                        ]
                    ],
                    [
                        [
                            1,
                            0
                        ],
                        [
                            0,
                            0
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            0,
                            2
                        ]
                    ],
                    [
                        [
                            -1,
                            0
                        ],
                        [
                            -1,
                            1
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            1,
                            1
                        ]
                    ]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 2:
                this.rotationShapes = [
                    [
                        [
                            0,
                            0
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            0,
                            2
                        ],
                        [
                            1,
                            2
                        ]
                    ],
                    [
                        [
                            1,
                            0
                        ],
                        [
                            -1,
                            1
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            1,
                            1
                        ]
                    ],
                    [
                        [
                            -1,
                            0
                        ],
                        [
                            0,
                            0
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            0,
                            2
                        ]
                    ],
                    [
                        [
                            -1,
                            2
                        ],
                        [
                            -1,
                            1
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            1,
                            1
                        ]
                    ]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 3:
                this.rotationShapes = [
                    [
                        [
                            1,
                            0
                        ],
                        [
                            1,
                            1
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            0,
                            2
                        ]
                    ],
                    [
                        [
                            0,
                            0
                        ],
                        [
                            1,
                            0
                        ],
                        [
                            1,
                            1
                        ],
                        [
                            2,
                            1
                        ]
                    ]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 4:
                this.rotationShapes = [
                    [
                        [
                            0,
                            0
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            1,
                            1
                        ],
                        [
                            1,
                            2
                        ]
                    ],
                    [
                        [
                            0,
                            1
                        ],
                        [
                            1,
                            1
                        ],
                        [
                            1,
                            0
                        ],
                        [
                            2,
                            0
                        ]
                    ]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 5:
                this.rotationShapes = [
                    [
                        [
                            -1,
                            0
                        ],
                        [
                            0,
                            0
                        ],
                        [
                            1,
                            0
                        ],
                        [
                            0,
                            1
                        ]
                    ],
                    [
                        [
                            0,
                            0
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            0,
                            2
                        ],
                        [
                            1,
                            1
                        ]
                    ],
                    [
                        [
                            0,
                            0
                        ],
                        [
                            -1,
                            1
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            1,
                            1
                        ]
                    ],
                    [
                        [
                            0,
                            0
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            0,
                            2
                        ],
                        [
                            -1,
                            1
                        ]
                    ]
                ];
                this.generateBlockFromShape(spawnX);
                break;
            case 6:
                this.rotationShapes = [
                    [
                        [
                            0,
                            0
                        ],
                        [
                            0,
                            1
                        ],
                        [
                            1,
                            0
                        ],
                        [
                            1,
                            1
                        ]
                    ]
                ];
                this.generateBlockFromShape(spawnX);
                break;
        }
        this.moving = true;
    }
    Object.defineProperty(Block1.prototype, "moving", {
        get: function() {
            return this._moving;
        },
        set: function(value) {
            this._moving = value;
            for(var i = 0; i < this.cells.length; i++)this.cells[i].moving = value; //setta tutte le celle del blocco in movimento con moving = value
        },
        enumerable: false,
        configurable: true
    });
    Block1.prototype.generateBlockFromShape = function(spawnX) {
        this.rotation = Math.floor(Math.random() * this.rotationShapes.length);
        for(var i = 0; i < this.rotationShapes[this.rotation].length; i++)this.cells.push(new Cell_1.Cell(spawnX + this.rotationShapes[this.rotation][i][0], this.rotationShapes[this.rotation][i][1], this.wCell));
    };
    Block1.prototype.getNextIndexOfRotate = function() {
        var rotatedCells = [];
        this.cells.forEach(function(val) {
            return rotatedCells.push(Object.assign({
            }, val));
        });
        for(var i = 0; i < rotatedCells.length; i++){
            rotatedCells[i].x -= this.rotationShapes[this.rotation][i][0] * this.wCell; //sottrai la posizione relativa della cella in modo da avere tutte le celle raccolte in un blocco
            rotatedCells[i].y -= this.rotationShapes[this.rotation][i][1] * this.wCell;
        }
        if (this.rotation == this.rotationShapes.length - 1) var nextRotation = 0;
        else var nextRotation = this.rotation + 1;
        for(var i = 0; i < rotatedCells.length; i++){
            rotatedCells[i].x += this.rotationShapes[nextRotation][i][0] * this.wCell; //somma gli indici relativi per portare i blocchi alla prossima rotazione
            rotatedCells[i].y += this.rotationShapes[nextRotation][i][1] * this.wCell;
        }
        return rotatedCells;
    };
    Block1.prototype.rotate = function() {
        var rotatedCells = this.getNextIndexOfRotate();
        for(var i = 0; i < this.cells.length; i++){
            this.cells[i].x = rotatedCells[i].x;
            this.cells[i].y = rotatedCells[i].y;
        }
        if (this.rotation == this.rotationShapes.length - 1) var nextRotation = 0;
        else var nextRotation = this.rotation + 1;
        this.rotation = nextRotation;
    };
    return Block1;
}();
exports.Block = Block;

},{"./Cell":"lihGa"}],"lihGa":[function(require,module,exports) {
"use strict";
Object.defineProperty(exports, "__esModule", {
    value: true
});
exports.Cell = void 0;
var Cell = function() {
    function Cell1(x, y, w) {
        this.x = x * w;
        this.y = y * w;
        this.w = w;
    }
    Cell1.prototype.show = function() {
        fill(0);
        rect(this.x, this.y, this.w, this.w);
    };
    return Cell1;
}();
exports.Cell = Cell;

},{}],"l3V1X":[function(require,module,exports) {
"use strict";
Object.defineProperty(exports, "__esModule", {
    value: true
});
exports.Grid = void 0;
var Grid = function() {
    function Grid1(col, row, wCell) {
        this.col = col;
        this.row = row;
        this.wCell = wCell;
        this.grid = new Array(row);
        for(var i = 0; i < this.grid.length; i++)this.grid[i] = new Array(col);
    }
    Grid1.prototype.show = function() {
        for(var i = 0; i < this.row; i++){
            for(var j = 0; j < this.col; j++)if (this.grid[i][j] != undefined && this.grid[i][j] != null) this.grid[i][j].show();
            else {
                stroke(148, 140, 117);
                noFill();
                strokeWeight(1);
                rect(i * this.wCell, j * this.wCell, this.wCell, this.wCell); //se non c'è niente disegna il quadratino
            }
        }
    };
    Grid1.prototype.addBlock = function(block) {
        for(var i = 0; i < block.cells.length; i++){
            var cell = block.cells[i];
            this.grid[cell.x / this.wCell][cell.y / this.wCell] = cell;
        }
    };
    Grid1.prototype.checkFullLines = function() {
        var fullLines = [];
        for(var i = 0; i < this.col; i++)for(var j = 0; j < this.row; j++){
            if (this.grid[j][i] == undefined || this.grid[j][i] == null) break; //passa alla colonna successiva
            else if (j == this.row - 1) fullLines.push(i); //mette l'indice della cella piena (da eliminare) dentro l'array
        }
        return fullLines; //ritorno l'indice delle righe da eliminare
    };
    Grid1.prototype.deleteLines = function(lineIndexes) {
        for(var j = 0; j < lineIndexes.length; j++)for(var i = 0; i < this.row; i++)this.grid[i][lineIndexes[j]] = null;
        for(var k = 0; k < lineIndexes.length; k++){
            for(var i = 0; i < lineIndexes[k]; i++)for(var j = 0; j < this.row; j++){
                if (this.grid[j][i] == undefined || this.grid[j][i] == null) continue; //passa alla cella dopo
                else this.grid[j][i].y += this.wCell;
            }
        }
        this.refreshCellPosition();
    };
    Grid1.prototype.refreshCellPosition = function() {
        var cellsInGrid = [];
        for(var i = 0; i < this.row; i++){
            for(var j = 0; j < this.col; j++)if (this.grid[i][j] != undefined && this.grid[i][j] != null) {
                cellsInGrid.push(this.grid[i][j]);
                this.grid[i][j] = null;
            }
        }
        for(var i = 0; i < cellsInGrid.length; i++)this.grid[cellsInGrid[i].x / this.wCell][cellsInGrid[i].y / this.wCell] = cellsInGrid[i];
    };
    return Grid1;
}();
exports.Grid = Grid;

},{}],"b9kLz":[function(require,module,exports) {
"use strict";
Object.defineProperty(exports, "__esModule", {
    value: true
});
exports.GridMoving = void 0;
var GridMoving = function() {
    function GridMoving1(gridBlockStopped, col, row, wCell) {
        this.col = col;
        this.row = row;
        this.wCell = wCell;
        this.gridBlockStopped = gridBlockStopped;
        this.gridMoving = new Array(this.row);
        for(var i = 0; i < this.gridMoving.length; i++)this.gridMoving[i] = new Array(this.col);
    }
    GridMoving1.prototype.show = function() {
        for(var i = 0; i < this.row; i++){
            for(var j = 0; j < this.col; j++)if (this.gridMoving[i][j] != undefined || this.gridMoving[i][j] != null) this.gridMoving[i][j].show();
        }
    };
    GridMoving1.prototype.addBlock = function(block) {
        this.blockMoving = block;
        for(var i = 0; i < block.cells.length; i++){
            var cell = block.cells[i];
            this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = cell;
        }
    };
    GridMoving1.prototype.movingDown = function() {
        if (this.blockMoving == undefined || this.blockMoving == null) return [
            null,
            true
        ];
        if (this.checkIfMovableDown(this.blockMoving)) {
            for(var i = 0; i < this.blockMoving.cells.length; i++){
                var cell = this.blockMoving.cells[i];
                this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = null;
            }
            for(var i = 0; i < this.blockMoving.cells.length; i++){
                var cell = this.blockMoving.cells[i];
                cell.y += cell.w;
                this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = cell;
            }
            return [
                null,
                false
            ];
        } else {
            this.blockMoving.moving = false;
            var tmp = this.blockMoving;
            for(var i = 0; i < this.blockMoving.cells.length; i++){
                var cell = this.blockMoving.cells[i];
                this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = null;
            }
            this.blockMoving = null;
            return [
                tmp,
                true
            ];
        }
    };
    GridMoving1.prototype.checkIfMovableDown = function(block) {
        for(var i = 0; i < block.cells.length; i++){
            var cell = block.cells[i];
            var nextIndex = (cell.y + cell.w) / this.wCell;
            if (cell.y + cell.w >= height || this.gridBlockStopped.grid[cell.x / this.wCell][nextIndex] != undefined || this.gridBlockStopped.grid[cell.x / this.wCell][nextIndex] != null) return false;
        }
        return true;
    };
    GridMoving1.prototype.moveBlock = function(direzione) {
        if (this.blockMoving == undefined || this.blockMoving == null) return;
        if (this.checkIfMovableLR(direzione, this.blockMoving)) {
            for(var i = 0; i < this.blockMoving.cells.length; i++){
                var cell = this.blockMoving.cells[i];
                this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = null;
            }
            for(var i = 0; i < this.blockMoving.cells.length; i++){
                var cell = this.blockMoving.cells[i];
                if (direzione == "right") cell.x += this.wCell;
                else if (direzione == "left") cell.x -= this.wCell;
                this.gridMoving[cell.x / this.wCell][cell.y / this.wCell] = cell;
            }
        }
    };
    GridMoving1.prototype.checkIfMovableLR = function(direzione, block) {
        for(var i = 0; i < block.cells.length; i++){
            var cell = block.cells[i];
            var nextIndex;
            if (direzione == "right") {
                nextIndex = (cell.x + cell.w) / this.wCell;
                if (nextIndex * this.wCell >= width || this.gridBlockStopped.grid[nextIndex][cell.y / this.wCell] != undefined || this.gridBlockStopped.grid[nextIndex][cell.y / this.wCell] != null) return false;
            } else if (direzione == "left") {
                nextIndex = (cell.x - cell.w) / this.wCell;
                if (nextIndex * this.wCell < 0 || this.gridBlockStopped.grid[nextIndex][cell.y / this.wCell] != undefined || this.gridBlockStopped.grid[nextIndex][cell.y / this.wCell] != null) return false;
            }
        }
        return true;
    };
    GridMoving1.prototype.rotateBlock = function() {
        if (this.blockMoving == undefined || this.blockMoving == null) return;
        if (this.checkIfRotatable(this.blockMoving)) this.blockMoving.rotate();
    };
    GridMoving1.prototype.checkIfRotatable = function(block) {
        var nextIndexes = block.getNextIndexOfRotate();
        for(var i = 0; i < nextIndexes.length; i++){
            var cell = nextIndexes[i];
            if (cell.y + cell.w >= height || cell.x < 0 || cell.x >= width || this.gridBlockStopped.grid[cell.x / this.wCell][cell.y / this.wCell] != undefined || this.gridBlockStopped.grid[cell.x / this.wCell][cell.y / this.wCell] != null) return false; //se il blocco sbatte giù || sinistra || destra || ci sono celle dove deve andare ritorna false
        }
        return true; //se esce dal for tutte le celle sono ruotabili quindi ritorno true
    };
    return GridMoving1;
}();
exports.GridMoving = GridMoving;

},{}]},["1DDSm","9Rlze"], "9Rlze", "parcelRequire94c2")

//# sourceMappingURL=index.c00d2372.js.map
