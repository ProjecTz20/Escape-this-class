using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WhiteBoardMarker : MonoBehaviour
{
    [SerializeField] private Transform tip;
    [SerializeField] private int penSize = 5;

    private Renderer _renderer;
    private Color[] _color;
    private float _tipHeight;

    private RaycastHit _touch;
    private WhiteBoard _Whiteboard;
    private Vector2 _touchPos, _lastTouchedPos;
    private bool _touchedLastFrame;
    private Quaternion _lastTouchedRot;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = tip.GetComponent<Renderer>();
        _color = Enumerable.Repeat(_renderer.material.color, penSize*penSize).ToArray();
        _tipHeight = tip.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        Draw();
    }

    private void Draw()
    {
        if (Physics.Raycast(tip.position, transform.up, out _touch, _tipHeight))
        {
            if (_touch.transform.CompareTag("WhiteBoard"))
            {
                if (_Whiteboard == null)
                {
                    _Whiteboard = _touch.transform.GetComponent<WhiteBoard>();
                }

                _touchPos = new Vector2(_touch.textureCoord.x, _touch.textureCoord.y);

                var x = (int)(_touchPos.x * _Whiteboard.textureSize.x - (penSize / 2));
                var y = (int)(_touchPos.y * _Whiteboard.textureSize.y - (penSize / 2));

                if (y < 0 || y > _Whiteboard.textureSize.y || x < 0 || x > _Whiteboard.textureSize.x) return;

                if(_touchedLastFrame)
                {
                    _Whiteboard.texture.SetPixels(x, y, penSize, penSize, _color);

                    for(float f = 0.01f; f<1.0f; f+=0.01f)
                    {
                        var lerpx = (int)Mathf.Lerp(_lastTouchedPos.x, x, f);
                        var lerpy = (int)Mathf.Lerp(_lastTouchedPos.y, y, f);
                        _Whiteboard.texture.SetPixels(lerpx, lerpy, penSize, penSize, _color);
                    }

                    transform.rotation = _lastTouchedRot;

                    _Whiteboard.texture.Apply();
                }

                _lastTouchedPos = new Vector2(x, y);
                _lastTouchedRot = transform.rotation;
                _touchedLastFrame = true;
                return;
            }
        }

        _Whiteboard = null;
        _touchedLastFrame = false;
    }
}
