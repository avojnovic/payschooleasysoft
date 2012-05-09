﻿(function(){var a=null;function b(){var c=true,e="undefined",d="navigate",b=false;Type._registerScript("MicrosoftAjaxHistory.js",["MicrosoftAjaxComponentModel.js","MicrosoftAjaxSerialization.js"]);var f=Sys._isBrowser;Sys.HistoryEventArgs=function(a){Sys.HistoryEventArgs.initializeBase(this);this._state=a};Sys.HistoryEventArgs.prototype={get_state:function(){return this._state}};Sys.HistoryEventArgs.registerClass("Sys.HistoryEventArgs",Sys.EventArgs);Sys.Application._appLoadHandler=a;Sys.Application._beginRequestHandler=a;Sys.Application._clientId=a;Sys.Application._currentEntry="";Sys.Application._endRequestHandler=a;Sys.Application._history=a;Sys.Application._enableHistory=b;Sys.Application._historyFrame=a;Sys.Application._historyInitialized=b;Sys.Application._historyPointIsNew=b;Sys.Application._ignoreTimer=b;Sys.Application._initialState=a;Sys.Application._state={};Sys.Application._timerCookie=0;Sys.Application._timerHandler=a;Sys.Application._uniqueId=a;Sys._Application.prototype.get_stateString=function(){var b=a;if(f("Firefox")){var d=window.location.href,c=d.indexOf("#");if(c!==-1)b=d.substring(c+1);else b="";return b}else b=window.location.hash;if(b.length>0&&b.charAt(0)==="#")b=b.substring(1);return b};Sys._Application.prototype.get_enableHistory=function(){return this._enableHistory};Sys._Application.prototype.set_enableHistory=function(a){this._enableHistory=a};Sys._Application.prototype.add_navigate=function(a){this._addHandler(d,a)};Sys._Application.prototype.remove_navigate=function(a){this._removeHandler(d,a)};Sys._Application.prototype.addHistoryPoint=function(g,j){var b=this;b._ensureHistory();var d=b._state;for(var f in g){var h=g[f];if(h===a){if(typeof d[f]!==e)delete d[f]}else d[f]=h}var i=b._serializeState(d);b._historyPointIsNew=c;b._setState(i,j);b._raiseNavigate()};Sys._Application.prototype.setServerId=function(a,b){this._clientId=a;this._uniqueId=b};Sys._Application.prototype.setServerState=function(a){this._ensureHistory();this._state.__s=a;this._updateHiddenField(a)};Sys._Application.prototype._deserializeState=function(a){var e={};a=a||"";var b=a.indexOf("&&");if(b!==-1&&b+2<a.length){e.__s=a.substr(b+2);a=a.substr(0,b)}var g=a.split("&");for(var f=0,j=g.length;f<j;f++){var d=g[f],c=d.indexOf("=");if(c!==-1&&c+1<d.length){var i=d.substr(0,c),h=d.substr(c+1);e[i]=decodeURIComponent(h)}}return e};Sys._Application.prototype._enableHistoryInScriptManager=function(){this._enableHistory=c};Sys._Application.prototype._ensureHistory=function(){var a=this;if(!a._historyInitialized&&a._enableHistory){if(f("InternetExplorer")&&Sys.Browser.documentMode<8){a._historyFrame=Sys.get("#__historyFrame");a._ignoreIFrame=c}a._timerHandler=Function.createDelegate(a,a._onIdle);a._timerCookie=window.setTimeout(a._timerHandler,100);try{a._initialState=a._deserializeState(a.get_stateString())}catch(b){}a._historyInitialized=c}};Sys._Application.prototype._navigate=function(d){var a=this;a._ensureHistory();var c=a._deserializeState(d);if(a._uniqueId){var e=a._state.__s||"",b=c.__s||"";if(b!==e){a._updateHiddenField(b);__doPostBack(a._uniqueId,b);a._state=c;return}}a._setState(d);a._state=c;a._raiseNavigate()};Sys._Application.prototype._onIdle=function(){var a=this;delete a._timerCookie;var c=a.get_stateString();if(c!==a._currentEntry){if(!a._ignoreTimer){a._historyPointIsNew=b;a._navigate(c)}}else a._ignoreTimer=b;a._timerCookie=window.setTimeout(a._timerHandler,100)};Sys._Application.prototype._onIFrameLoad=function(c){var a=this;a._ensureHistory();if(!a._ignoreIFrame){a._historyPointIsNew=b;a._navigate(c)}a._ignoreIFrame=b};Sys._Application.prototype._onPageRequestManagerBeginRequest=function(){this._ignoreTimer=c;this._originalTitle=document.title};Sys._Application.prototype._onPageRequestManagerEndRequest=function(l,k){var d=this,i=k.get_dataItems()[d._clientId],h=d._originalTitle;d._originalTitle=a;var g=Sys.get("#__EVENTTARGET");if(g&&g.value===d._uniqueId)g.value="";if(typeof i!==e){d.setServerState(i);d._historyPointIsNew=c}else d._ignoreTimer=b;var f=d._serializeState(d._state);if(f!==d._currentEntry){d._ignoreTimer=c;if(typeof h==="string"){if(Sys.Browser.agent!==Sys.Browser.InternetExplorer||Sys.Browser.version>7){var j=document.title;document.title=h;d._setState(f);document.title=j}else d._setState(f);d._raiseNavigate()}else{d._setState(f);d._raiseNavigate()}}};Sys._Application.prototype._raiseNavigate=function(){var a=this,e=a._historyPointIsNew,c={};for(var b in a._state)if(b!=="__s")c[b]=a._state[b];var g=new Sys.HistoryEventArgs(c);Sys.Observer.raiseEvent(a,d,g);if(!e){var h;try{if(f("Firefox")&&window.location.hash&&(!window.frameElement||window.top.location.hash))Sys.Browser.version<3.5?window.history.go(0):(location.hash=a.get_stateString())}catch(h){}}};Sys._Application.prototype._serializeState=function(d){var a=[];for(var b in d){var e=d[b];if(b==="__s")var c=e;else a[a.length]=b+"="+encodeURIComponent(e)}return a.join("&")+(c?"&&"+c:"")};Sys._Application.prototype._setState=function(f,g){var d=this;if(d._enableHistory){f=f||"";if(f!==d._currentEntry){if(window.theForm){var i=window.theForm.action,j=i.indexOf("#");window.theForm.action=(j!==-1?i.substring(0,j):i)+"#"+f}if(d._historyFrame&&d._historyPointIsNew){d._ignoreIFrame=c;var h=d._historyFrame.contentWindow.document;h.open("javascript:'<html></html>'");h.write("<html><head><title>"+(g||document.title)+'</title><script type="text/javascript">parent.Sys.Application._onIFrameLoad('+Sys.Serialization.JavaScriptSerializer.serialize(f)+");</script></head><body></body></html>");h.close()}d._ignoreTimer=b;d._currentEntry=f;if(d._historyFrame||d._historyPointIsNew){var k=d.get_stateString();if(f!==k){window.location.hash=f;d._currentEntry=d.get_stateString();if(typeof g!==e&&g!==a)document.title=g}}d._historyPointIsNew=b}}};Sys._Application.prototype._updateHiddenField=function(b){if(this._clientId){var a=document.getElementById(this._clientId);if(a)a.value=b}}}if(window.Sys&&Sys.loader)Sys.loader.registerScript("History",a,b);else b()})();
