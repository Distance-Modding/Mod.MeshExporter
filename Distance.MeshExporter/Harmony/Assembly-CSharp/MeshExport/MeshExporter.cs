using Centrifuge.Distance.EditorTools.Attributes;
using LevelEditorActions;
using LevelEditorTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityFBXExporter;

namespace Mod.MeshExporter.Harmony
{
    [EditorTool, KeyboardShortcut("CTRL+SHIFT+P")]
    public class MeshExporterTool : InstantTool
    {
        internal static ToolInfo info_ => new ToolInfo("MeshExporter", "MeshExporter.", ToolCategory.Others, ToolButtonState.Button, true, 1220);
        public override ToolInfo Info_ => info_;
        
        // Required by distance itself
        public static void Register()
        {
            if (!G.Sys.LevelEditor_.registeredToolsNamesToTypes_.ContainsKey(info_.Name_))
                G.Sys.LevelEditor_.RegisterTool(info_);
        }

        public override bool Run()
        {
            GameObject[] selectedGameObjects = G.Sys.LevelEditor_.SelectedObjects_.ToArray();

            Mod.Logger.Info(Mod.FileSystem_.RootDirectory);

            FBXExporter.ExportGameObjToFBX(selectedGameObjects[0], Mod.FileSystem_.RootDirectory + "\\exportMesh.fbx");
            
            return true;
        }

        private bool IsGameObjNull(GameObject objec)
        {
            return ((UnityEngine.Object)objec == (UnityEngine.Object)null);
        }

        private bool IsGameCompNull<T>(T objec)
        {
            return (objec == null);
        }

        private GameObject FOONIC(GameObject parentObjec, string name) //FindObjectOfNameInChildren
        {
            if((UnityEngine.Object)parentObjec != (UnityEngine.Object)null)
            {
                foreach (GameObject gameObject in parentObjec.gameObject.GetChildren())
                {
                    if (gameObject.name == name)
                    {
                        return gameObject;
                        break;
                    }
                }
            }
            return null;
        }

        private GameObject FOONIC(GameObject[] childObjecRay, string name) //For use with main object list
        {
            foreach (GameObject gameObject in childObjecRay)
            {
                if (gameObject.transform.parent == null && gameObject.name == name)
                {
                    return gameObject;
                    break;
                }
            }
            return null;
        }

        private void printPropsAndFields(UILabel comp)
        {
            Mod.Logger.Info("<PROPS>");
            Mod.Logger.Info("alignment: " + comp.alignment);
            Mod.Logger.Info("alpha: " + comp.alpha);
            Mod.Logger.Info("ambigiousFont: " + comp.ambigiousFont);
            Mod.Logger.Info("applyGradient: " + comp.applyGradient);
            Mod.Logger.Info("bitmapFont: " + comp.bitmapFont);
            Mod.Logger.Info("border: " + comp.border);
            Mod.Logger.Info("color: " + comp.color);
            Mod.Logger.Info("depth: " + comp.depth);
            Mod.Logger.Info("drawRegion: " + comp.drawRegion);
            Mod.Logger.Info("effectColor: " + comp.effectColor);
            Mod.Logger.Info("effectDistance: " + comp.effectDistance);
            Mod.Logger.Info("effectStyle: " + comp.effectStyle);
            Mod.Logger.Info("enabled: " + comp.enabled);
            Mod.Logger.Info("floatSpacingX: " + comp.floatSpacingX);
            Mod.Logger.Info("floatSpacingY: " + comp.floatSpacingY);
            //Mod.Logger.Info("enabled: " + comp.font);
            Mod.Logger.Info("fontSize: " + comp.fontSize);
            Mod.Logger.Info("fontStyle: " + comp.fontStyle);
            Mod.Logger.Info("gradientBottom: " + comp.gradientBottom);
            Mod.Logger.Info("gradientTop: " + comp.gradientTop);
            Mod.Logger.Info("height: " + comp.height);
            Mod.Logger.Info("hideFlags: " + comp.hideFlags);
            //Mod.Logger.Info("enabled: " + comp.lineHeight);
            //Mod.Logger.Info("enabled: " + comp.lineWidth);
            Mod.Logger.Info("mainTexture: " + comp.mainTexture);
            Mod.Logger.Info("material: " + comp.material);
            Mod.Logger.Info("maxLineCount: " + comp.maxLineCount);
            Mod.Logger.Info("multiLine: " + comp.multiLine);
            Mod.Logger.Info("onRender: " + comp.onRender);
            Mod.Logger.Info("overflowMethod: " + comp.overflowMethod);
            Mod.Logger.Info("pivot: " + comp.pivot);
            Mod.Logger.Info("rawPivot: " + comp.rawPivot);
            Mod.Logger.Info("shader: " + comp.shader);
            Mod.Logger.Info("shouldBeProcessed: " + comp.shouldBeProcessed);
            //Mod.Logger.Info("enabled: " + comp.shrinkToFit);
            Mod.Logger.Info("spacingX: " + comp.spacingX);
            Mod.Logger.Info("spacingY: " + comp.spacingY);
            Mod.Logger.Info("supportEncoding: " + comp.supportEncoding);
            Mod.Logger.Info("symbolStyle: " + comp.symbolStyle);
            Mod.Logger.Info("tag: " + comp.tag);
            Mod.Logger.Info("text: " + comp.text);
            Mod.Logger.Info("trueTypeFont: " + comp.trueTypeFont);
            Mod.Logger.Info("useFloatSpacing: " + comp.useFloatSpacing);
            Mod.Logger.Info("useGUILayout: " + comp.useGUILayout);
            Mod.Logger.Info("width: " + comp.width);
            Mod.Logger.Info("<FIELDS>");
            Mod.Logger.Info("aspectRatio: " + comp.aspectRatio);
            Mod.Logger.Info("autoResizeBoxCollider: " + comp.autoResizeBoxCollider);
            Mod.Logger.Info("bottomAnchor: " + comp.bottomAnchor);
            Mod.Logger.Info("drawCall: " + comp.drawCall);
            Mod.Logger.Info("fillGeometry: " + comp.fillGeometry);
            Mod.Logger.Info("finalAlpha: " + comp.finalAlpha);
            Mod.Logger.Info("geometry: " + comp.geometry);
            Mod.Logger.Info("hideIfOffScreen: " + comp.hideIfOffScreen);
            Mod.Logger.Info("hitCheck: " + comp.hitCheck);
            Mod.Logger.Info("keepAspectRatio: " + comp.keepAspectRatio);
            Mod.Logger.Info("keepCrispWhenShrunk: " + comp.keepCrispWhenShrunk);
            Mod.Logger.Info("leftAnchor: " + comp.leftAnchor);
            Mod.Logger.Info("onChange: " + comp.onChange);
            Mod.Logger.Info("onPostFill: " + comp.onPostFill);
            Mod.Logger.Info("panel: " + comp.panel);
            Mod.Logger.Info("rightAnchor: " + comp.rightAnchor);
            Mod.Logger.Info("topAnchor: " + comp.topAnchor);
            Mod.Logger.Info("updateAnchors: " + comp.updateAnchors);
            Mod.Logger.Info("<FIELDSM>");
            Mod.Logger.Info("mActiveTTF: " + comp.mActiveTTF);
            Mod.Logger.Info("mAlignment: " + comp.mAlignment);
            Mod.Logger.Info("mAlphaFrameID: " + comp.mAlphaFrameID);
            Mod.Logger.Info("mAnchorsCached: " + comp.mAnchorsCached);
            Mod.Logger.Info("mApplyGradient: " + comp.mApplyGradient);
            Mod.Logger.Info("mCalculatedSize: " + comp.mCalculatedSize);
            Mod.Logger.Info("mCam: " + comp.mCam);
            Mod.Logger.Info("mChanged: " + comp.mChanged);
            Mod.Logger.Info("mChildren: " + comp.mChildren);
            Mod.Logger.Info("mColor: " + comp.mColor);
            Mod.Logger.Info("mCorners: " + comp.mCorners);
            Mod.Logger.Info("mDensity: " + comp.mDensity);
            Mod.Logger.Info("mDepth: " + comp.mDepth);
            Mod.Logger.Info("mDrawRegion: " + comp.mDrawRegion);
            Mod.Logger.Info("mEffectColor: " + comp.mEffectColor);
            Mod.Logger.Info("mEffectDistance: " + comp.mEffectDistance);
            Mod.Logger.Info("mEffectStyle: " + comp.mEffectStyle);
            Mod.Logger.Info("mEncoding: " + comp.mEncoding);
            Mod.Logger.Info("mFinalFontSize: " + comp.mFinalFontSize);
            Mod.Logger.Info("mFloatSpacingX: " + comp.mFloatSpacingX);
            Mod.Logger.Info("mFloatSpacingY: " + comp.mFloatSpacingY);
            Mod.Logger.Info("mFont: " + comp.mFont);
            Mod.Logger.Info("mFontSize: " + comp.mFontSize);
            Mod.Logger.Info("mFontStyle: " + comp.mFontStyle);
            Mod.Logger.Info("mGo: " + comp.mGo);
            Mod.Logger.Info("mGradientBottom: " + comp.mGradientBottom);
            Mod.Logger.Info("mGradientTop: " + comp.mGradientTop);
            Mod.Logger.Info("mHeight: " + comp.mHeight);
            Mod.Logger.Info("mIsInFront: " + comp.mIsInFront);
            Mod.Logger.Info("mIsVisibleByAlpha: " + comp.mIsVisibleByAlpha);
            Mod.Logger.Info("mIsVisibleByPanel: " + comp.mIsVisibleByPanel);
            Mod.Logger.Info("mLastAlpha: " + comp.mLastAlpha);
            Mod.Logger.Info("mLastHeight: " + comp.mLastHeight);
            Mod.Logger.Info("mLastWidth: " + comp.mLastWidth);
            Mod.Logger.Info("mLineWidth: " + comp.mLineWidth);
            Mod.Logger.Info("mLocalToPanel: " + comp.mLocalToPanel);
            Mod.Logger.Info("mMaterial: " + comp.mMaterial);
            Mod.Logger.Info("mMatrixFrame: " + comp.mMatrixFrame);
            Mod.Logger.Info("mMaxLineCount: " + comp.mMaxLineCount);
            Mod.Logger.Info("mMaxLineHeight: " + comp.mMaxLineHeight);
            Mod.Logger.Info("mMaxLineWidth: " + comp.mMaxLineWidth);
            Mod.Logger.Info("mMoved: " + comp.mMoved);
            Mod.Logger.Info("mMultiline: " + comp.mMultiline);
            Mod.Logger.Info("mOldV0: " + comp.mOldV0);
            Mod.Logger.Info("mOldV1: " + comp.mOldV1);
            Mod.Logger.Info("mOnRender: " + comp.mOnRender);
            Mod.Logger.Info("mOverflow: " + comp.mOverflow);
            Mod.Logger.Info("mOverflowEllipsis: " + comp.mOverflowEllipsis);
            Mod.Logger.Info("mParent: " + comp.mParent);
            Mod.Logger.Info("mParentFound: " + comp.mParentFound);
            Mod.Logger.Info("mPivot: " + comp.mPivot);
            Mod.Logger.Info("mPlayMode: " + comp.mPlayMode);
            Mod.Logger.Info("mPremultiply: " + comp.mPremultiply);
            Mod.Logger.Info("mProcessedText: " + comp.mProcessedText);
            Mod.Logger.Info("mRoot: " + comp.mRoot);
            Mod.Logger.Info("mRootSet: " + comp.mRootSet);
            Mod.Logger.Info("mScale: " + comp.mScale);
            Mod.Logger.Info("mShouldBeProcessed: " + comp.mShouldBeProcessed);
            Mod.Logger.Info("mShrinkToFit: " + comp.mShrinkToFit);
            Mod.Logger.Info("mSpacingX: " + comp.mSpacingX);
            Mod.Logger.Info("mSpacingY: " + comp.mSpacingY);
            Mod.Logger.Info("mStarted: " + comp.mStarted);
            Mod.Logger.Info("mSymbols: " + comp.mSymbols);
            Mod.Logger.Info("mText: " + comp.mText);
            Mod.Logger.Info("mTrans: " + comp.mTrans);
            Mod.Logger.Info("mTrueTypeFont: " + comp.mTrueTypeFont);
            Mod.Logger.Info("mUpdateAnchors: " + comp.mUpdateAnchors);
            Mod.Logger.Info("mUpdateFrame: " + comp.mUpdateFrame);
            Mod.Logger.Info("mUseFloatSpacing: " + comp.mUseFloatSpacing);
            Mod.Logger.Info("mWidth: " + comp.mWidth);

        }


            private void printPropsAndFields(UIButton comp)
        {
            Mod.Logger.Info("<PROPS>");
            Mod.Logger.Info("enabled: " + comp.enabled);
            Mod.Logger.Info("hideFlags: " + comp.hideFlags);
            Mod.Logger.Info("isEnabled: " + comp.isEnabled);
            Mod.Logger.Info("normalSprite: " + comp.normalSprite);
            Mod.Logger.Info("normalSprite2D: " + comp.normalSprite2D);
            Mod.Logger.Info("state: " + comp.state);
            Mod.Logger.Info("tag: " + comp.tag);
            Mod.Logger.Info("useGUILayout: " + comp.useGUILayout);
            Mod.Logger.Info("<FIELDS>");
            Mod.Logger.Info("disabledColor: " + comp.disabledColor);
            Mod.Logger.Info("disabledSprite: " + comp.disabledSprite);
            Mod.Logger.Info("disabledSprite2D: " + comp.disabledSprite2D);
            Mod.Logger.Info("dragHighlight: " + comp.dragHighlight);
            Mod.Logger.Info("duration: " + comp.duration);
            Mod.Logger.Info("hover: " + comp.hover);
            Mod.Logger.Info("hoverSprite: " + comp.hoverSprite);
            Mod.Logger.Info("hoverSprite2D: " + comp.hoverSprite2D);
            Mod.Logger.Info("onClick: " + comp.onClick);
            Mod.Logger.Info("pixelSnap: " + comp.pixelSnap);
            Mod.Logger.Info("pressed: " + comp.pressed);
            Mod.Logger.Info("pressedSprite: " + comp.pressedSprite);
            Mod.Logger.Info("pressedSprite2D: " + comp.pressedSprite2D);
            Mod.Logger.Info("tweenTarget: " + comp.tweenTarget);
            Mod.Logger.Info("<FIELDSM>");
            Mod.Logger.Info("mDefaultColor: " + comp.mDefaultColor);
            Mod.Logger.Info("mInitDone: " + comp.mInitDone);
            Mod.Logger.Info("mNormalSprite: " + comp.mNormalSprite);
            Mod.Logger.Info("mNormalSprite2D: " + comp.mNormalSprite2D);
            Mod.Logger.Info("mSprite: " + comp.mSprite);
            Mod.Logger.Info("mSprite2D: " + comp.mSprite2D);
            Mod.Logger.Info("mStartingColor: " + comp.mStartingColor);
            Mod.Logger.Info("mState: " + comp.mState);
            Mod.Logger.Info("mWidget: " + comp.mWidget);
        }

            private void printPropsAndFields(UIExIntegerInput comp)
        {
            Mod.Logger.Info("<PROPS>");
            Mod.Logger.Info("cursorPosition: " + comp.cursorPosition);
            Mod.Logger.Info("defaultText: " + comp.defaultText);
            Mod.Logger.Info("Dragging_: " + comp.Dragging_);
            Mod.Logger.Info("enabled: " + comp.enabled);
            Mod.Logger.Info("ExpStepSize_: " + comp.ExpStepSize_);
            Mod.Logger.Info("hideFlags: " + comp.hideFlags);
            Mod.Logger.Info("isSelected: " + comp.isSelected);
            Mod.Logger.Info("Max_: " + comp.Max_);
            Mod.Logger.Info("Min_: " + comp.Min_);
            //Mod.Logger.Info("alpha: " + comp.selected);
            Mod.Logger.Info("selectionEnd: " + comp.selectionEnd);
            Mod.Logger.Info("selectionStart: " + comp.selectionStart);
            Mod.Logger.Info("StepSize_: " + comp.StepSize_);
            Mod.Logger.Info("tag: " + comp.tag);
            //Mod.Logger.Info("alpha: " + comp.text);
            Mod.Logger.Info("useGUILayout: " + comp.useGUILayout);
            Mod.Logger.Info("value: " + comp.value);
            Mod.Logger.Info("Value_: " + comp.Value_);
            Mod.Logger.Info("<FIELDS>");
            Mod.Logger.Info("activeTextColor: " + comp.activeTextColor);
            Mod.Logger.Info("caretColor: " + comp.caretColor);
            Mod.Logger.Info("characterLimit: " + comp.characterLimit);
            Mod.Logger.Info("customString_: " + comp.customString_);
            Mod.Logger.Info("dragDelta_: " + comp.dragDelta_);
            Mod.Logger.Info("expressionTree_: " + comp.expressionTree_);
            Mod.Logger.Info("expStepSize_: " + comp.expStepSize_);
            Mod.Logger.Info("facadeButton_: " + comp.facadeButton_);
            Mod.Logger.Info("hideInput: " + comp.hideInput);
            Mod.Logger.Info("ignoreNextInputOnChangeEvent_: " + comp.ignoreNextInputOnChangeEvent_);
            Mod.Logger.Info("inactiveColor_: " + comp.inactiveColor_);
            Mod.Logger.Info("inputType: " + comp.inputType);
            Mod.Logger.Info("keyboardType: " + comp.keyboardType);
            Mod.Logger.Info("label: " + comp.label);
            Mod.Logger.Info("max_: " + comp.max_);
            Mod.Logger.Info("min_: " + comp.min_);
            Mod.Logger.Info("onChange: " + comp.onChange);
            Mod.Logger.Info("onChange_: " + comp.onChange_);
            Mod.Logger.Info("onFinish_: " + comp.onFinish_);
            Mod.Logger.Info("onReturnKey: " + comp.onReturnKey);
            Mod.Logger.Info("onStart_: " + comp.onStart_);
            Mod.Logger.Info("onSubmit: " + comp.onSubmit);
            Mod.Logger.Info("onValidate: " + comp.onValidate);
            Mod.Logger.Info("openedKeyboard_: " + comp.openedKeyboard_);
            Mod.Logger.Info("previousValue_: " + comp.previousValue_);
            Mod.Logger.Info("savedAs: " + comp.savedAs);
            Mod.Logger.Info("selectAllTextOnFocus: " + comp.selectAllTextOnFocus);
            Mod.Logger.Info("selectionColor: " + comp.selectionColor);
            Mod.Logger.Info("selectOnSubmit_: " + comp.selectOnSubmit_);
            Mod.Logger.Info("selectOnTab: " + comp.selectOnTab);
            Mod.Logger.Info("stepSize_: " + comp.stepSize_);
            Mod.Logger.Info("submitted_: " + comp.submitted_);
            Mod.Logger.Info("touchID_: " + comp.touchID_);
            Mod.Logger.Info("validation: " + comp.validation);
            Mod.Logger.Info("value_: " + comp.value_);
            Mod.Logger.Info("<FIELDSM>");
            Mod.Logger.Info("mBlankTex: " + comp.mBlankTex);
            Mod.Logger.Info("mCached: " + comp.mCached);
            Mod.Logger.Info("mCam: " + comp.mCam);
            Mod.Logger.Info("mCaret: " + comp.mCaret);
            Mod.Logger.Info("mDefaultColor: " + comp.mDefaultColor);
            Mod.Logger.Info("mDefaultText: " + comp.mDefaultText);
            Mod.Logger.Info("mDoInit: " + comp.mDoInit);
            Mod.Logger.Info("mHighlight: " + comp.mHighlight);
            Mod.Logger.Info("mLastAlpha: " + comp.mLastAlpha);
            Mod.Logger.Info("mLoadSavedValue: " + comp.mLoadSavedValue);
            Mod.Logger.Info("mNextBlink: " + comp.mNextBlink);
            Mod.Logger.Info("mOnGUI: " + comp.mOnGUI);
            Mod.Logger.Info("mPivot: " + comp.mPivot);
            Mod.Logger.Info("mPosition: " + comp.mPosition);
            Mod.Logger.Info("mSelectionEnd: " + comp.mSelectionEnd);
            Mod.Logger.Info("mSelectionStart: " + comp.mSelectionStart);
            Mod.Logger.Info("mSelectMe: " + comp.mSelectMe);
            Mod.Logger.Info("mSelectTime: " + comp.mSelectTime);
            Mod.Logger.Info("mValue: " + comp.mValue);

        }

            private void printPropsAndFields(UIWidget comp)
        {
            Mod.Logger.Info("<PROPS>");
            Mod.Logger.Info("alpha: " + comp.alpha);
            Mod.Logger.Info("color: " + comp.color);
            Mod.Logger.Info("depth: " + comp.depth);
            Mod.Logger.Info("drawRegion: " + comp.drawRegion);
            Mod.Logger.Info("enabled: " + comp.enabled);
            Mod.Logger.Info("height: " + comp.height);
            Mod.Logger.Info("hideFlags: " + comp.hideFlags);
            Mod.Logger.Info("mainTexture: " + comp.mainTexture);
            Mod.Logger.Info("name: " + comp.name);
            Mod.Logger.Info("onRender: " + comp.onRender);
            Mod.Logger.Info("pivot: " + comp.pivot);
            Mod.Logger.Info("rawPivot: " + comp.rawPivot);
            Mod.Logger.Info("shader: " + comp.shader);
            Mod.Logger.Info("tag: " + comp.tag);
            Mod.Logger.Info("useGUILayout: " + comp.useGUILayout);
            Mod.Logger.Info("width: " + comp.width);
            Mod.Logger.Info("<FIELDS>");
            Mod.Logger.Info("aspectRatio: " + comp.aspectRatio);
            Mod.Logger.Info("autoResizeBoxCollider: " + comp.autoResizeBoxCollider);
            Mod.Logger.Info("bottomAnchor: " + comp.bottomAnchor);
            Mod.Logger.Info("drawCall: " + comp.drawCall);
            Mod.Logger.Info("fillGeometry: " + comp.fillGeometry);
            Mod.Logger.Info("finalAlpha: " + comp.finalAlpha);
            Mod.Logger.Info("geometry: " + comp.geometry);
            Mod.Logger.Info("hideIfOffScreen: " + comp.hideIfOffScreen);
            Mod.Logger.Info("hitCheck: " + comp.hitCheck);
            Mod.Logger.Info("keepAspectRatio: " + comp.keepAspectRatio);
            Mod.Logger.Info("leftAnchor: " + comp.leftAnchor);
            Mod.Logger.Info("onChange: " + comp.onChange);
            Mod.Logger.Info("onPostFill: " + comp.onPostFill);
            Mod.Logger.Info("panel: " + comp.panel);
            Mod.Logger.Info("rightAnchor: " + comp.rightAnchor);
            Mod.Logger.Info("topAnchor: " + comp.topAnchor);
            Mod.Logger.Info("updateAnchors: " + comp.updateAnchors);
            Mod.Logger.Info("<M>");
            Mod.Logger.Info("mAlphaFrameID: " + comp.mAlphaFrameID);
            Mod.Logger.Info("mAnchorsCached: " + comp.mAnchorsCached);
            Mod.Logger.Info("mCam: " + comp.mCam);
            Mod.Logger.Info("mChanged: " + comp.mChanged);
            Mod.Logger.Info("mChildren: " + comp.mChildren);
            Mod.Logger.Info("mColor: " + comp.mColor);
            Mod.Logger.Info("mCorners: " + comp.mCorners);
            Mod.Logger.Info("mDepth: " + comp.mDepth);
            Mod.Logger.Info("mDrawRegion: " + comp.mDrawRegion);
            Mod.Logger.Info("mGo: " + comp.mGo);
            Mod.Logger.Info("mHeight: " + comp.mHeight);
            Mod.Logger.Info("mIsInFront: " + comp.mIsInFront);
            Mod.Logger.Info("mIsVisibleByAlpha: " + comp.mIsVisibleByAlpha);
            Mod.Logger.Info("mIsVisibleByPanel: " + comp.mIsVisibleByPanel);
            Mod.Logger.Info("mLastAlpha: " + comp.mLastAlpha);
            Mod.Logger.Info("mLocalToPanel: " + comp.mLocalToPanel);
            Mod.Logger.Info("mMatrixFrame: " + comp.mMatrixFrame);
            Mod.Logger.Info("mMoved: " + comp.mMoved);
            Mod.Logger.Info("mOldV0: " + comp.mOldV0);
            Mod.Logger.Info("mOldV1: " + comp.mOldV1);
            Mod.Logger.Info("mOnRender: " + comp.mOnRender);
            Mod.Logger.Info("mParent: " + comp.mParent);
            Mod.Logger.Info("mParentFound: " + comp.mParentFound);
            Mod.Logger.Info("mPivot: " + comp.mPivot);
            Mod.Logger.Info("mPlayMode: " + comp.mPlayMode);
            Mod.Logger.Info("mRoot: " + comp.mRoot);
            Mod.Logger.Info("mRootSet: " + comp.mRootSet);
            Mod.Logger.Info("mStarted: " + comp.mStarted);
            Mod.Logger.Info("mTrans: " + comp.mTrans);
            Mod.Logger.Info("mUpdateAnchors: " + comp.mUpdateAnchors);
            Mod.Logger.Info("mUpdateFrame: " + comp.mUpdateFrame);
            Mod.Logger.Info("mWidth: " + comp.mWidth);
        }

            private void printPropsAndFields(UISprite comp)
        {
            Mod.Logger.Info("<PROPS>");
            Mod.Logger.Info("alpha: " + comp.alpha);
            Mod.Logger.Info("atlas: " + comp.atlas);
            Mod.Logger.Info("color: " + comp.color);
            Mod.Logger.Info("depth: " + comp.depth);
            Mod.Logger.Info("drawRegion: " + comp.drawRegion);
            Mod.Logger.Info("enabled: " + comp.enabled);
            Mod.Logger.Info("fillAmount: " + comp.fillAmount);
            Mod.Logger.Info("centerType: " + comp.centerType);
            Mod.Logger.Info("fillDirection: " + comp.fillDirection);
            Mod.Logger.Info("flip: " + comp.flip);
            Mod.Logger.Info("height: " + comp.height);
            Mod.Logger.Info("hideFlags: " + comp.hideFlags);
            Mod.Logger.Info("invert: " + comp.invert);
            Mod.Logger.Info("mainTexture: " + comp.mainTexture);
            Mod.Logger.Info("name: " + comp.name);
            Mod.Logger.Info("onRender: " + comp.onRender);
            Mod.Logger.Info("pivot: " + comp.pivot);
            Mod.Logger.Info("rawPivot: " + comp.rawPivot);
            Mod.Logger.Info("shader: " + comp.shader);
            Mod.Logger.Info("spriteName: " + comp.spriteName);
            Mod.Logger.Info("tag: " + comp.tag);
            Mod.Logger.Info("type: " + comp.type);
            Mod.Logger.Info("useGUILayout: " + comp.useGUILayout);
            Mod.Logger.Info("width: " + comp.width);
            Mod.Logger.Info("<FIELDS>");
            Mod.Logger.Info("aspectRatio: " + comp.aspectRatio);
            Mod.Logger.Info("autoResizeBoxCollider: " + comp.autoResizeBoxCollider);
            Mod.Logger.Info("bottomAnchor: " + comp.bottomAnchor);
            Mod.Logger.Info("bottomType: " + comp.bottomType);
            Mod.Logger.Info("centerType: " + comp.centerType);
            Mod.Logger.Info("drawCall: " + comp.drawCall);
            Mod.Logger.Info("fillGeometry: " + comp.fillGeometry);
            Mod.Logger.Info("finalAlpha: " + comp.finalAlpha);
            Mod.Logger.Info("geometry: " + comp.geometry);
            Mod.Logger.Info("hideIfOffScreen: " + comp.hideIfOffScreen);
            Mod.Logger.Info("hitCheck: " + comp.hitCheck);
            Mod.Logger.Info("keepAspectRatio: " + comp.keepAspectRatio);
            Mod.Logger.Info("leftAnchor: " + comp.leftAnchor);
            Mod.Logger.Info("leftType: " + comp.leftType);
            Mod.Logger.Info("onChange: " + comp.onChange);
            Mod.Logger.Info("onPostFill: " + comp.onPostFill);
            Mod.Logger.Info("panel: " + comp.panel);
            Mod.Logger.Info("rightAnchor: " + comp.rightAnchor);
            Mod.Logger.Info("rightType: " + comp.rightType);
            Mod.Logger.Info("topAnchor: " + comp.topAnchor);
            Mod.Logger.Info("topType: " + comp.topType);
            Mod.Logger.Info("updateAnchors: " + comp.updateAnchors);
            Mod.Logger.Info("<M>");
            Mod.Logger.Info("mAlphaFrameID: " + comp.mAlphaFrameID);
            Mod.Logger.Info("mAnchorsCached: " + comp.mAnchorsCached);
            Mod.Logger.Info("mAtlas: " + comp.mAtlas);
            Mod.Logger.Info("mCam: " + comp.mCam);
            Mod.Logger.Info("mChanged: " + comp.mChanged);
            Mod.Logger.Info("mChildren: " + comp.mChildren);
            Mod.Logger.Info("mColor: " + comp.mColor);
            Mod.Logger.Info("mCorners: " + comp.mCorners);
            Mod.Logger.Info("mDepth: " + comp.mDepth);
            Mod.Logger.Info("mDrawRegion: " + comp.mDrawRegion);
            Mod.Logger.Info("mFillAmount: " + comp.mFillAmount);
            Mod.Logger.Info("mFillCenter: " + comp.mFillCenter);
            Mod.Logger.Info("mFillDirection: " + comp.mFillDirection);
            Mod.Logger.Info("mFlip: " + comp.mFlip);
            Mod.Logger.Info("mGo: " + comp.mGo);
            Mod.Logger.Info("mHeight: " + comp.mHeight);
            Mod.Logger.Info("mInnerUV: " + comp.mInnerUV);
            Mod.Logger.Info("mInvert: " + comp.mInvert);
            Mod.Logger.Info("mIsInFront: " + comp.mIsInFront);
            Mod.Logger.Info("mIsVisibleByAlpha: " + comp.mIsVisibleByAlpha);
            Mod.Logger.Info("mIsVisibleByPanel: " + comp.mIsVisibleByPanel);
            Mod.Logger.Info("mLastAlpha: " + comp.mLastAlpha);
            Mod.Logger.Info("mLocalToPanel: " + comp.mLocalToPanel);
            Mod.Logger.Info("mMatrixFrame: " + comp.mMatrixFrame);
            Mod.Logger.Info("mMoved: " + comp.mMoved);
            Mod.Logger.Info("mOldV0: " + comp.mOldV0);
            Mod.Logger.Info("mOldV1: " + comp.mOldV1);
            Mod.Logger.Info("mOnRender: " + comp.mOnRender);
            Mod.Logger.Info("mOuterUV: " + comp.mOuterUV);
            Mod.Logger.Info("mParent: " + comp.mParent);
            Mod.Logger.Info("mParentFound: " + comp.mParentFound);
            Mod.Logger.Info("mPivot: " + comp.mPivot);
            Mod.Logger.Info("mPlayMode: " + comp.mPlayMode);
            Mod.Logger.Info("mRoot: " + comp.mRoot);
            Mod.Logger.Info("mRootSet: " + comp.mRootSet);
            Mod.Logger.Info("mSprite: " + comp.mSprite);
            Mod.Logger.Info("mSpriteName: " + comp.mSpriteName);
            Mod.Logger.Info("mSpriteSet: " + comp.mSpriteSet);
            Mod.Logger.Info("mStarted: " + comp.mStarted);
            Mod.Logger.Info("mTrans: " + comp.mTrans);
            Mod.Logger.Info("mType: " + comp.mType);
            Mod.Logger.Info("mUpdateAnchors: " + comp.mUpdateAnchors);
            Mod.Logger.Info("mUpdateFrame: " + comp.mUpdateFrame);
            Mod.Logger.Info("mWidth: " + comp.mWidth);
        }

        private void printPropsAndFields(BoxCollider comp)
        {
            Mod.Logger.Info("<BB>");
            Mod.Logger.Info("attachedRigidbody: " + comp.attachedRigidbody);
            Mod.Logger.Info("bounds: " + comp.bounds);
            Mod.Logger.Info("center: " + comp.center);
            Mod.Logger.Info("contactOffset: " + comp.contactOffset);
            Mod.Logger.Info("enabled: " + comp.enabled);
            //Mod.Logger.Info("alpha: " + comp.extents);
            Mod.Logger.Info("hideFlags: " + comp.hideFlags);
            Mod.Logger.Info("isTrigger: " + comp.isTrigger);
            Mod.Logger.Info("material: " + comp.material);
            Mod.Logger.Info("name: " + comp.name);
            Mod.Logger.Info("sharedMaterial: " + comp.sharedMaterial);
            Mod.Logger.Info("size: " + comp.size);
            Mod.Logger.Info("tag: " + comp.tag);
            Mod.Logger.Info("transform: " + comp.transform);
        }

        private void printPropsAndFields(UIExInput comp)
        {
            Mod.Logger.Info("<PROPS>");
            Mod.Logger.Info("cursorPosition: " + comp.cursorPosition);
            Mod.Logger.Info("defaultText: " + comp.defaultText);
            Mod.Logger.Info("enabled: " + comp.enabled);
            Mod.Logger.Info("hideFlags: " + comp.hideFlags);
            Mod.Logger.Info("isSelected: " + comp.isSelected);
            Mod.Logger.Info("name: " + comp.name);
            Mod.Logger.Info("selectionEnd: " + comp.selectionEnd);
            Mod.Logger.Info("selectionStart: " + comp.selectionStart);
            Mod.Logger.Info("tag: " + comp.tag);
            Mod.Logger.Info("useGUILayout: " + comp.useGUILayout);
            Mod.Logger.Info("value: " + comp.value);
            Mod.Logger.Info("Value_: " + comp.Value_);
            Mod.Logger.Info("<FIELDS>");
            Mod.Logger.Info("activeTextColor: " + comp.activeTextColor);
            Mod.Logger.Info("caretColor: " + comp.caretColor);
            Mod.Logger.Info("characterLimit: " + comp.characterLimit);
            Mod.Logger.Info("customString_: " + comp.customString_);
            Mod.Logger.Info("facadeButton_: " + comp.facadeButton_);
            Mod.Logger.Info("hideInput: " + comp.hideInput);
            Mod.Logger.Info("ignoreNextInputOnChangeEvent_: " + comp.ignoreNextInputOnChangeEvent_);
            Mod.Logger.Info("inactiveColor_: " + comp.inactiveColor_);
            Mod.Logger.Info("inputType: " + comp.inputType);
            Mod.Logger.Info("keyboardType: " + comp.keyboardType);
            Mod.Logger.Info("label: " + comp.label);
            Mod.Logger.Info("onChange: " + comp.onChange);
            Mod.Logger.Info("onChange_: " + comp.onChange_);
            Mod.Logger.Info("onFinish_: " + comp.onFinish_);
            Mod.Logger.Info("onReturnKey: " + comp.onReturnKey);
            Mod.Logger.Info("onStart_: " + comp.onStart_);
            Mod.Logger.Info("onSubmit: " + comp.onSubmit);
            Mod.Logger.Info("onValidate: " + comp.onValidate);
            Mod.Logger.Info("openedKeyboard_: " + comp.openedKeyboard_);
            Mod.Logger.Info("previousValue_: " + comp.previousValue_);
            Mod.Logger.Info("savedAs: " + comp.savedAs);
            Mod.Logger.Info("selectAllTextOnFocus: " + comp.selectAllTextOnFocus);
            Mod.Logger.Info("selectionColor: " + comp.selectionColor);
            Mod.Logger.Info("selectOnSubmit_: " + comp.selectOnSubmit_);
            Mod.Logger.Info("selectOnTab: " + comp.selectOnTab);
            Mod.Logger.Info("submitted_: " + comp.submitted_);
            Mod.Logger.Info("validation: " + comp.validation);
            Mod.Logger.Info("value_: " + comp.value_);
            Mod.Logger.Info("<FIELDSM>");
            Mod.Logger.Info("mBlankTex: " + comp.mBlankTex);
            Mod.Logger.Info("mCached: " + comp.mCached);
            Mod.Logger.Info("mCam: " + comp.mCam);
            Mod.Logger.Info("mCaret: " + comp.mCaret);
            Mod.Logger.Info("mDefaultColor: " + comp.mDefaultColor);
            Mod.Logger.Info("mDefaultText: " + comp.mDefaultText);
            Mod.Logger.Info("mDoInit: " + comp.mDoInit);
            Mod.Logger.Info("mHighlight: " + comp.mHighlight);
            Mod.Logger.Info("mLastAlpha: " + comp.mLastAlpha);
            Mod.Logger.Info("mLoadSavedValue: " + comp.mLoadSavedValue);
            Mod.Logger.Info("mNextBlink: " + comp.mNextBlink);
            Mod.Logger.Info("mOnGUI: " + comp.mOnGUI);
            Mod.Logger.Info("mPivot: " + comp.mPivot);
            Mod.Logger.Info("mPosition: " + comp.mPosition);
            Mod.Logger.Info("mSelectionEnd: " + comp.mSelectionEnd);
            Mod.Logger.Info("mSelectionStart: " + comp.mSelectionStart);
            Mod.Logger.Info("mSelectMe: " + comp.mSelectMe);
            Mod.Logger.Info("mSelectTime: " + comp.mSelectTime);
            Mod.Logger.Info("mValue: " + comp.mValue);
        }

        private void OnSelect(string valu, bool success)
        {

        }

        private void OnOk()
        {

        }

        private void OnCancel()
        {

        }
    }
}
