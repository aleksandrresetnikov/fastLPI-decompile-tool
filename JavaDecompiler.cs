using System.Diagnostics;

using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler
{
    public class JavaDecompiler : IJavaDecompiler
    {
        /// <summary>
        /// The path to the input file.
        /// </summary>
        private protected virtual string PathIn { get; set; }

        /// <summary>
        /// Path to the output file.
        /// </summary>
        private protected virtual string PathTo { get; set; }

        /// <summary>
        /// The path to the bat file to be executed by the decompiler.
        /// </summary>
        private protected virtual string DecompilerBatPath { get; set; }

        /// <summary>
        /// The path to the edited (performing) bat file to be executed by the decompiler.
        /// </summary>
        private protected virtual string DecompilerExeBatPath { get; set; }

        /// <summary>
        /// The path to the decompiler.
        /// </summary>
        private protected virtual string DecompilerPath { get; set; }

        /// <summary>
        /// Decompiler process.
        /// </summary>
        private protected virtual Process DecompilerProcess { get; set; }

        /// <summary>
        /// Run a process without creating a window.
        /// </summary>
        public virtual bool CreateNoWindow { get; set; } = false;

        /// <returns>void</returns>
        public virtual void Decompile(bool insertFile = false) =>
            throw new NonExistingMethodException();

        /// <returns>CreateNoWindow</returns>
        public virtual bool GetCreateNoWindow() =>
            throw new NonExistingMethodException();

        /// <returns>DecompilerBatPath</returns>
        public virtual string GetDecompilerBatPath() =>
            throw new NonExistingMethodException();

        /// <returns>DecompilerExeBatPath</returns>
        public virtual string GetDecompilerExeBatPath() =>
            throw new NonExistingMethodException();

        /// <returns>DecompilerPath</returns>
        public virtual string GetDecompilerPath() =>
            throw new NonExistingMethodException();

        /// <returns>DecompilerProcess</returns>
        public virtual Process GetDecompilerProcess() =>
            throw new NonExistingMethodException();

        /// <returns>PathIn</returns>
        public virtual string GetPathIn() =>
            throw new NonExistingMethodException();

        /// <returns>PathTo</returns>
        public virtual string GetPathTo() =>
            throw new NonExistingMethodException();
    }
}
