
using System.Diagnostics;
using UnityEngine;

public class PlayerSpriteRenderer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer { get; private set; }
    private HorizontalMuvment muvment;

    public Sprite idle;
    public Sprite jump;
    public Sprite slide;
    public AnimatedSprites run;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        muvment = GetComponentInParent<HorizontalMuvment>();
    }

    private void OnEnable()
    {
        spriteRenderer.enabled = true;
    }

    private void OnDisable()
    {
        spriteRenderer.enabled = false;
    }
    private void LateUpdate()
    {
        run.enabled = muvment.running;
        if (muvment.jumping)
        {
            spriteRenderer.sprite = jump;
        }
        else if (muvment.sliding)
        {
            spriteRenderer.sprite = slide;
        }
        else if (!muvment.running)
        {
            spriteRenderer.sprite = idle;
        }

    }
}
